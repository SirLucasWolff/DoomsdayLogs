using System.Diagnostics;

namespace DoomsdayLogs.PackagesManager
{
    public class PackagesManager
    {
        private string NugetPath;

        public void Packages()
        {
            NugetPath = "C:\\nuget.exe";

            string packageId1 = "System.Resources.Extensions";
            string packageVersion1 = "7.0.0";
            string packageId2 = "System.Drawing.Common";
            string packageVersion2 = "7.0.0";
            string packageId3 = "Microsoft.EntityFrameworkCore";
            string packageVersion3 = "7.0.9";
            string packageId4 = "Microsoft.VisualStudio.Shell.Framework";
            string packageVersion4 = "17.6.36389";

            if (IsPackageInstalled(packageId1))
            {
                if (!IsPackageWithLastVersion(packageId1, packageVersion1))
                    UpdatePackage(packageId1, packageVersion1);
            }
            else
            {
                InstallPackage(packageId1, packageVersion1);
            }

            if (IsPackageInstalled(packageId2))
            {
                if (!IsPackageWithLastVersion(packageId2, packageVersion2))
                    UpdatePackage(packageId2, packageVersion2);
            }
            else
            {
                InstallPackage(packageId2, packageVersion2);
            }

            if (IsPackageInstalled(packageId3))
            {
                if (!IsPackageWithLastVersion(packageId3, packageVersion3))
                    UpdatePackage(packageId3, packageVersion3);
            }
            else
            {
                InstallPackage(packageId3, packageVersion3);
            }

            if (IsPackageInstalled(packageId4))
            {
                if (!IsPackageWithLastVersion(packageId4, packageVersion4))
                    UpdatePackage(packageId4, packageVersion4);
            }
            else
            {
                InstallPackage(packageId4, packageVersion4);
            }
        }

        public bool IsPackageInstalled(string packageId)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = NugetPath,
                Arguments = $"list {packageId}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Check if the package is listed in the output
                return output.Contains(packageId);
            }
        }

        public bool IsPackageWithLastVersion(string packageId, string version)
        {
            string arguments = $"list {packageId} -Version {version} -AllVersions";
            var processInfo = new ProcessStartInfo
            {
                FileName = NugetPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Check if the package with the specified version is listed in the output
                return output.Contains($"{packageId} {version}");
            }
        }

        public void InstallPackage(string packageId, string version = null)
        {
            NugetPath = "C:\\nuget.exe";

            string arguments = $"install {packageId}";
            if (!string.IsNullOrEmpty(version))
            {
                arguments += $" -Version {version}";
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = NugetPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = @"C:\Doomsday Logs\WinFormsApp1"
            };

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
            }
        }

        public void UpdatePackage(string packageId, string version = null)
        {
            string arguments = $"update {packageId}";
            if (!string.IsNullOrEmpty(version))
            {
                arguments += $" -Version {version}";
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = NugetPath,
                Arguments = arguments,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = System.Diagnostics.Process.Start(processInfo))
            {
                process.WaitForExit();
            }
        }
    }
}
