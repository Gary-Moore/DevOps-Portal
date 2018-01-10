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
	[Parameter(Mandatory=$true)][string]$repoUrl, 
	[Parameter(Mandatory=$true)][string]$workingDirPath
)

Write-Progress "Pushing solution to gitlab repository"

# Initialise git repo
cd $workingDirPath
git init
# Add remote to gitlab url
git remote add origin $repoUrl
# Add all files
git add .
# Create first commit
git commit -m "Initial commit"
# push to gitlab
git push -u origin master