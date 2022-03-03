# https://www.atlassian.com/git/tutorials/using-branches
# ---- clone all branches and check specific branch
# git clone -b <branchname> <remote-repo-url>
# git clone --branch <branchname> <remote-repo-url>
# ---- clone only specific branch
# git clone -b <branchname> --single-branch <remote-repo-url>
git clone -b Patryk_Najgebauer https://github.com/department-intelligent-computer-systems/Advanced_Internet_Programming_Erasmus.git

# ---- show local branch list (-a branch list on serwer)
git branch 

# ---- select branch
git checkout <branchname> 

# ---- create branch
git branch <branchname> 

# ---- delete branch (-D - force)
git branch -d <branchnam 

# Start a new branch fro main
git checkout -b new-feature main
git add <file> # add files to repo 
git commit -m "Start a feature" # commit changes

# Merge in the new-feature branch
git checkout main # go to main branch
git merge new-feature # marge main with brach
git branch -d new-feature # remove branch


# git pull # poranie zmian
# git push # wysłąnie comitowanych zmian