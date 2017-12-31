<#
.Synopsis
    This is a script to migrate an SVN reposistory into a Git repository
.DESCRIPTION
   This is a script to migrate a legacy SVN reposistory into a new Git repository.
   All revision history including author names are maintained along with tags and branches.
.EXAMPLE
   Get-Support
   PS C:\scripts> .\Migrate-SvnRepoToGit.ps1
    cmdlet .\migrate-SvnRepoToGit.ps1 at command pipeline position 1
    Supply values for the following parameters:
    repoUrl: http://svn-repo.com/myrepo/
    checkoutPath: C:\temp\checkoutfolder
	password: Password123
	originUrl: http://GitLab-repo.com/myrepo/
    In this example, the script is simply run and the parameters are input as they are mandatory.
.EXAMPLE
   Migrate-SvnRepoToGit.ps1 -repoUrl http://svn-repo.com/myrepo/ -checkoutPath C:\temp\checkoutfolder -password password123 -originUrl http://GitLab.com/repo
#>

##Paramaters
Param(
	[Parameter(Mandatory=$true)][string]$solutionName, 
	[Parameter(Mandatory=$true)][string]$projectName, 
	[Parameter(Mandatory=$true)][string]$workingDirPath
)

function RenameDirectories
{
    $dirs = Get-ChildItem -Path  $workingDirPath -Attributes Directory -Recurse -Force | where {$_.name -Match "SolutionName"}

    foreach($dir in $dirs)
    {
        $newName = $dir.Name -replace "SolutionName", $solutionName -replace "ProjectName", $projectName
        Rename-Item $dir.fullname.ToString().Trim() $newName;
        write-output $dir.name " => " $newName;
    }
}

function RenameFiles
{
    $files = Get-ChildItem -Path  $workingDirPath -File -Recurse -Force | where {$_.name -Match "SolutionName"}
        
    foreach($file in $files)
    {
        $newName = $file.Name -replace "SolutionName", $solutionName -replace "ProjectName", $projectName
        Rename-Item $file.fullname.ToString().Trim() $newName;
        write-output $file.name " => " $newName;
    }
}

function RenameFileReferences
{
    $files = Get-ChildItem -Path $workingDirPath -Recurse -Force

    foreach($file in $files)
    {
        (Get-Content $file.FullName).replace('MainProject', $solutionName).Replace('SubProject', $projectName) | Set-Content $file.FullName
    }
}

RenameDirectories
RenameFiles
RenameFileReferences