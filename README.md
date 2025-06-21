# TrainHub

## Steps for creating a new branch

### Step 1: First, clone the main branch
```bash
git clone https://github.com/Zanti00/TrainHub.git
```

- or clone it via visual studio

### Step 2: Go to Build > Rebuild Solution

### Step 3: Do your update/code

### Step 4: Commit and push to the branch

### Step 5: Pull a request


## What to do when the main branch is ahead of your branch

### Step 1: Switch to main branch and pull latest changes
- If there are unstaged changes commit or stash them, then pop it later on
### Step 2: Switch back to your branch
- Pop the stashed changes to your branch
### Step 3: Rebase your branch onto the updated main branch
- If there are conflicts, resolve them first
- Stage the resolved files
- Continue the rebase


## What to do when you encounter Fix locked executable issue ("The file is locked by:")

### Step 1: Go to Task manager > Details

### Step 2: Find "TrainHub.exe" then click end task

## How to install UI Framework

### Step 1: Go to Tools > NuGet Package Manager > Package Manager Console

### Step 2: Paste Install-Package CuoreUI.Winforms in the console

```
Install-Package CuoreUI.Winforms
```
