# Contributing guide
When contributing to this repository, please first discuss the change you wish to make via issue,
email, or any other method with the owner of this repository before making a change. 

## <b><u>_Step 1_</u></b> : Set up a working copy on your computer

Firstly you need a local fork of the the project, so go ahead and press the "fork" button in GitHub. This will create a copy of the repository in your own GitHub account and you'll see a note that it's been forked underneath the project name.

Now you need a copy locally, so find the "SSH clone URL" in the right hand column and use that to clone locally using a terminal:

```
$ git clone git@github.com:MonikaLyzwa/SeleniumAutomation.git
```

Finally, in this stage, you need to set up a new remote that points to the original project so that you can grab any changes and bring them into your local copy. Firstly clock on the link to the original repository – it's labeled "Forked from" at the top of the GitHub page. This takes you back to the projects main GitHub page, so you can find the "SSH clone URL" and use it to create the new remote, which we'll call upstream.

```
$ git remote add upstream git@github.com:MonikaLyzwa/SeleniumAutomation.git
```
You now have two remotes for this project on disk:

1. origin which points to your GitHub fork of the project. You can read and write to this remote.
1. upstream which points to the main project's GitHub repository. You can only read from this remote.

## <b><u>_Step 2_</u></b> : Do some work

### Branch
The number one rule is to put each piece of work on its own branch. If the project is using git-flow, then it will have both a master and a develop branch. The general rule is that if you are bug fixing, then branch from master and if you are adding a new feature then branch from develop. If the project only has a master branch, the branch from that.

For example, let's assume we're adding new UI tests for AutomationFramework project:

```
$ git checkout master
$ git pull upstream master && git push origin master
$ git checkout -b feature/readme-update
```

Firstly we ensure we're on the master branch. Then the git pull command will sync our local copy with the upstream project and the git push syncs it to our forked GitHub project. Finally we create our new branch. You can name your branch whatever you like, but it helps for it to be meaningful. Including the issue number is usually helpful. If the project uses git-flow as zend-validator does, then there are specific naming conventions where the branch is prefixed with "hotfix/" or "feature/".

Now you can do your work.

## <b><u>_Step 3_</u></b> : Create the pull request
To create a PR you need to push your branch to the origin remote and then press some buttons on GitHub.

To push a new branch:

```
$ git push -u feature/readme-update
```

This will create the branch on your GitHub project. The -u flag links this branch with the remote one, so that in the future, you can simply type git push origin.

Swap back to the browser and navigate to your fork of the project (https://github.com/MonikaLyzwa/SeleniumAutomation) and you'll see that your new branch is listed at the top with a handy "Compare & pull request" button:

![](https://github.com/MonikaLyzwa/SeleniumAutomation/blob/master/SeleniumFirst/2017-09contributing.png)

Go ahead and just press the button!

If you see a yellow box:

![](https://github.com/MonikaLyzwa/SeleniumAutomation/blob/master/SeleniumFirst/2017-09contributing.png)

just click the link which will take you to the project's <b>CONTRIBUTING</b> file.

It contains valuable information on how to work with the project's code base and will help you get your contribution accepted.

On this page, ensure that the "base fork" points to the correct repository and branch. Then ensure that you provide a good, succinct title for your pull request and explain why you have created it in the description box. Add any relevant issue numbers if you have them.

Scrolling down a bit, contains a diff of your changes. Double check that it contains what you expect.
Afterwards press the "Create pull request" button! :smiley:

```diff
Summing up:

- Fork the project & clone locally.
- Create an upstream remote and sync your local copy before you branch.
- Branch for each separate piece of work.
- Do the work, write good commit messages, and read the CONTRIBUTING file if there is one.
- Push to your origin repository.
- Create a new PR in GitHub.
```

# Opening issues
Open an issue to report bugs or to propose new features.

# Proposing pull requests
Pull requests are very welcome. Note that if you are going to propose drastic changes, be sure to open an issue for discussion first, to make sure that your PR will be accepted before you spend effort coding it.

# Documentation

This section includes any help you need with the documentation and where it can be found. Code needs explanation, and sometimes those who know the code well have trouble explaining it to someone just getting into it.

* Help us with documentation [here](https://github.com/MonikaLyzwa/SeleniumAutomation/wiki)

# Your first bugfix

This section should help a person get started with their very first bug fix and thinking through the problem.

If you have further questions, contact: monika_lyzwa@o2.pl
