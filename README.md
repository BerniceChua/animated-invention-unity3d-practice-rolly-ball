# Animated Invention (Unity3D-practice) Rolly-Ball

## About

A simple game based on the [tutorial in Unity's website](http://unity3d.com/learn/tutorials/projects/roll-ball-tutorial), but improved because it has:

1. an intro screen with instructions on how the game controls work (WASD or arrow keys).
2. options to replay the game or quit the game.

In this game, you roll a ball to pick up little spinny-cubes.  You win the game if all the spinny-cubes are picked up.  

This README also contains:

1. things that I wish I knew when I started in terms of version control (that are not in the tutorials).
2. how to download and install Unity3D natively on Ubuntu (without using WinE)!!

## How did the name of this project come about?

I was starting a GitHub repo for this Unity3D project, and GitHub recommended the name.  It seems fitting, so I just stuck with it.

![Screenshot Of GitHub's name suggestion.](https://pbs.twimg.com/media/CevOIHOWwAELUaO.jpg:large "The Origins Of The Name")
[https://twitter.com/ChuaBernice/status/714891605136637952](https://twitter.com/ChuaBernice/status/714891605136637952 "How I got the name.")


### Technologies Used
- Unity3D
- C#
- git
- GitHub


### Contributor List - Who Made This?
- Bernice Anne W. Chua
  - [GitHub](https://github.com/BerniceChua)
  - [LinkedIn](https://linkedin.com/in/bernicechua415)
  - [Twitter](https://twitter.com/ChuaBernice)


## Contributing

I welcome any pull requestions people might have.


## Feedback

(coming soon!)

## Issues
### How To Download & Install Unity3D Natively On Ubuntu (without WinE)!!

Source To Download .deb file:

http://blogs.unity3d.com/2015/08/26/unity-comes-to-linux-experimental-build-now-available/

Download the .deb file.

In CLI:
cd to the dir where you downloaded the file.

```bash
sudo dpkg -i unity-editor-[version-number].deb
```

example:
```bash
sudo dpkg -i unity-editor-5.1.0f3+2015082501_amd64.deb
```

It will give you error messages of dependencies that need to be installed:

```bash
bernice@Little-Panda-Ubuntu:~/Downloads$ sudo dpkg -i unity-editor-5.1.0f3+2015082501_amd64.deb
Selecting previously unselected package unity-editor.
(Reading database ... 212058 files and directories currently installed.)
Preparing to unpack unity-editor-5.1.0f3+2015082501_amd64.deb ...
Unpacking unity-editor (5.1.0f3) ...
dpkg: dependency problems prevent configuration of unity-editor:
 unity-editor depends on lib32gcc1 (>= 1:4.1.1); however:
  Package lib32gcc1 is not installed.
 unity-editor depends on lib32stdc++6 (>= 4.6); however:
  Package lib32stdc++6 is not installed.
 unity-editor depends on libc6-i386 (>= 2.15); however:
  Package libc6-i386 is not installed.

dpkg: error processing package unity-editor (--install):
 dependency problems - leaving unconfigured
Processing triggers for gnome-menus (3.10.1-0ubuntu2) ...
Processing triggers for desktop-file-utils (0.22-1ubuntu1) ...
Processing triggers for bamfdaemon (0.5.1+14.04.20140409-0ubuntu1) ...
Rebuilding /usr/share/applications/bamf-2.index...
Processing triggers for mime-support (3.54ubuntu1.1) ...
Processing triggers for hicolor-icon-theme (0.13-1) ...
Errors were encountered while processing:
 unity-editor
```

If you try to `sudo apt-get -f install` lib32gcc1, lib32stdc++6, & libc6-i386, you will get these error messages:

```bash
bernice@Little-Panda-Ubuntu:~/Downloads$ sudo apt-get -f install lib32stdc++6
Reading package lists... Done
Building dependency tree       
Reading state information... Done
You might want to run 'apt-get -f install' to correct these:
The following packages have unmet dependencies:
 lib32stdc++6 : Depends: lib32gcc1 (>= 1:4.1.1) but it is not going to be installed
                Depends: libc6-i386 (>= 2.18) but it is not going to be installed
 unity-editor : Depends: lib32gcc1 (>= 1:4.1.1) but it is not going to be installed
                Depends: libc6-i386 (>= 2.15) but it is not going to be installed
                Recommends: ffmpeg but it is not installable or
                            libav-tools but it is not going to be installed
                Recommends: java6-runtime
                Recommends: monodevelop but it is not going to be installed
                Recommends: java7-jdk
E: Unmet dependencies. Try 'apt-get -f install' with no packages (or specify a solution).
bernice@Little-Panda-Ubuntu:~/Downloads$ sudo apt-get -f install libc6-i386
Reading package lists... Done
Building dependency tree       
Reading state information... Done
You might want to run 'apt-get -f install' to correct these:
The following packages have unmet dependencies:
 unity-editor : Depends: lib32gcc1 (>= 1:4.1.1) but it is not going to be installed
                Depends: lib32stdc++6 (>= 4.6) but it is not going to be installed
                Recommends: ffmpeg but it is not installable or
                            libav-tools but it is not going to be installed
                Recommends: java6-runtime
                Recommends: monodevelop but it is not going to be installed
                Recommends: java7-jdk
E: Unmet dependencies. Try 'apt-get -f install' with no packages (or specify a solution).
```

So the first thing you need to do is install libav-tools (if you use this, no need for ffmpeg)

After installing libav-tools, re-do:

```bash
sudo dpkg -i unity-editor-5.1.0f3+2015082501_amd64.deb
(Reading database ... 219384 files and directories currently installed.)
Preparing to unpack unity-editor-5.1.0f3+2015082501_amd64.deb ...
Unpacking unity-editor (5.1.0f3) over (5.1.0f3) ...
Setting up unity-editor (5.1.0f3) ...
Setting permissions on chrome-sandbox...
Done.
Processing triggers for gnome-menus (3.10.1-0ubuntu2) ...
Processing triggers for desktop-file-utils (0.22-1ubuntu1) ...
Processing triggers for bamfdaemon (0.5.1+14.04.20140409-0ubuntu1) ...
Rebuilding /usr/share/applications/bamf-2.index...
Processing triggers for mime-support (3.54ubuntu1.1) ...
Processing triggers for hicolor-icon-theme (0.13-1) ...
Processing triggers for libc-bin (2.19-0ubuntu6.7) ...
bernice@Little-Panda-Ubuntu:~/Downloads$ 

$ sudo apt-get install gdebi-core
$ sudo apt-get -f install
```

Unity3D should install correctly now! ^__^

(Don't forget to also install MonoDevelop, so that you can write scripts for your game.)


### Things That I Wish I Knew When I Started In Terms Of Version Control (that are not included in the tutorials).

Like any good developer, I like to use version control.  Plus, I work on my laptop when I'm not at home (where; and I work on my desktop when I'm at home (which I prefer to use because my desktop is more powerful).

Unity's website has amazing tutorials <http://unity3d.com/learn/tutorials/topics/interface-essentials> for beginners, but unfortunately if you want to look for anything about version control, you'd have to hunt for it.

These are the things I wish I knew, because I could have avoided a lot of delays and headaches had I known these before:



## License

[MIT](LICENSE)
