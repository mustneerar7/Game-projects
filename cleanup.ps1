# Define the list of files and directories to remove
$filesToRemove = @(
    "Temp",
    "Library",
    "Obj",
    "Build",
    "Builds",
    "Logs",
    ".vscode",
    ".idea",
    "*.suo",
    "*.user",
    "*.userprefs",
    "*.pidb.meta",
    "sysinfo.txt",
    ".DS_Store",
    "Thumbs.db"
)

# Specify the root directory of your Unity project
$projectRoot = "C:\Path\To\Your\Unity\Project"

# Change the current directory to the project root
Set-Location -Path $projectRoot

# Remove each file and directory
foreach ($item in $filesToRemove) {
    Remove-Item -Path $item -Recurse -Force -ErrorAction SilentlyContinue
}

Write-Host "Cleanup complete."
