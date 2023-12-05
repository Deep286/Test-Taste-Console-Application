package _Self.buildTypes

import jetbrains.buildServer.configs.kotlin.*
import jetbrains.buildServer.configs.kotlin.buildFeatures.perfmon
import jetbrains.buildServer.configs.kotlin.buildSteps.DotnetMsBuildStep
import jetbrains.buildServer.configs.kotlin.buildSteps.dotnetMsBuild
import jetbrains.buildServer.configs.kotlin.buildSteps.dotnetPublish
import jetbrains.buildServer.configs.kotlin.buildSteps.nuGetInstaller
import jetbrains.buildServer.configs.kotlin.triggers.vcs

object Build : BuildType({
    name = "Build"

    artifactRules = """test-and-taste-developer-exercise\Test-Taste-Console-Application\** => Artifact"""

    vcs {
        root(HttpsGithubComDeep286TestTasteConsoleApplicationGitRefsHeadsMain)
    }
    steps {
        nuGetInstaller {
            name = "NuGet Install"
            toolPath = "%teamcity.tool.NuGet.CommandLine.6.1.0%"
            projects = "test-and-taste-developer-exercise/Test-Taste-Console-Application.sln"
            updatePackages = updateParams {
            }
        }
        dotnetMsBuild {
            name = "build test-and-taste-developer-exercise/Test-Taste-Console-Application/Test-Taste-Console-Application.sln"
            projects = "test-and-taste-developer-exercise/Test-Taste-Console-Application/Test-Taste-Console-Application.sln"
            version = DotnetMsBuildStep.MSBuildVersion.CrossPlatform
            param("dotNetCoverage.dotCover.home.path", "%teamcity.tool.JetBrains.dotCover.CommandLineTools.DEFAULT%")
        }
        dotnetMsBuild {
            name = "build test-and-taste-developer-exercise/Test-Taste-Console-Application.sln"
            projects = "test-and-taste-developer-exercise/Test-Taste-Console-Application.sln"
            version = DotnetMsBuildStep.MSBuildVersion.CrossPlatform
            param("dotNetCoverage.dotCover.home.path", "%teamcity.tool.JetBrains.dotCover.CommandLineTools.DEFAULT%")
        }
        dotnetPublish {
            name = "create installer"
            id = "create_installer"
            projects = "test-and-taste-developer-exercise/Test-Taste-Console-Application.sln test-and-taste-developer-exercise/Test-Taste-Console-Application/Test-Taste-Console-Application.csproj"
            param("dotNetCoverage.dotCover.home.path", "%teamcity.tool.JetBrains.dotCover.CommandLineTools.DEFAULT%")
        }
    }
    triggers {
        vcs {
        }
    }

    features {
        perfmon {
        }
    }
})
