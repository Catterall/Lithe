# Lithe
*Lithe /lʌɪð/; Thin, supple, and graceful.*

![Lithe main window](https://user-images.githubusercontent.com/66549839/84096073-d17f8400-a9f8-11ea-89f8-0c6208f3d93a.png)

Introduction:
-
Lithe is a free, windows desktop application to convert LaTeX equations to PNG files on the fly. Furtheremore, the application contains a helpful 'LaTeX snippets' windows, that can be used to add snippets of LaTeX code to the editor, so you don't have to remember every single thing. However, it is required that you know the basics of LaTeX - or at least the mathematical side of it.


Purpose:
-
The purpose of Lithe is simple. There is an abundance of websites and web applications that all allow a user to generate a PNG file from LaTeX code - particulary when converting equations and formulas to LaTeX. However, I couldn't find any desktop applications that could be used offline to acheive the same purpose so - in typical programmer fashion - I just made my own. Granted, it might not look as cool - or professional - as its contemparies, but as long as it is easily understood when looking at it; it's the functionality that counts.


Installation Guide:
-
Installing Lithe can be quite a pain if you don't read this guide - if you do read this guide, it's overwhelmingly easy to install.
- Firstly, you **must** have the following items installed onto your computer. If not, install them through the links below:
  - Tex Live: http://mirror.ctan.org/systems/texlive/tlnet/install-tl-windows.exe
  - Image Magick:https://imagemagick.org/script/download.php#windows
  - Ghostscript: https://www.ghostscript.com/download/gsdnld.html
  - Any tool that can unzip .7z files (WinRAR, 7zip, etc. ).

  Installing these requirements is not hard. Simply follow their installtion wizards carefully to avoid mistakes.

- Secondly, install a release of Lithe here: https://github.com/Catterall/Lithe/releases
- Thirdly, unzip the 7z release file to your desired location. This will give you access to the Lithe folder.
- Finally, run the Lithe.exe file to run the application.

*Notice: If you accidently break the application, perhaps by deleting a .bat file or any other mistake, you can reinstall the application anytime here.*


Usage Guide:
-
After running the Lithe.exe program, you'll be greeted with the main window, naturally. Here is an image of the main label. On the image, you will see several numbers. These numbers corrospond with the text below, describing what each thing does:

![labelled lithe](https://user-images.githubusercontent.com/66549839/84094837-9b8cd080-a9f5-11ea-8eda-b3807e1fd2bc.png)

- 1: This opens up a menu with several buttons. These buttons can be clicked to add snippets of LaTeX to your code.
- 2: This is where you write your LaTeX Code.
- 3: This is where you type the desired name of you resultant PNG file.
- 4: This is the button you pressed when done; it will create a PNG image inside the `generated images` folder.
- 5: This is the button that will take you to this page.
- 6: Exits Lithe (with confirmation).


How it all works:
-
The program first converts the LaTeX into a PDF file, then into a PNG file. This is why Ghost Script is required, as it allows working with PDF files.

After clicking the save button, the program saves a `.tex` file to the `generated images` folder named `formula.tex`. If there is no `generated images` folder, it creates it first. Then, a batch file is ran by the program containing the following code (where %1 is the LaTeX text in the editor box and where %2 is the desired name of the PNG file specified):
```
cd "generated images"
pdflatex "\def\formula{%1}\input{formula.tex}"
magick -density 300 formula.pdf -quality 90 formula.png
del formula.tex
del formula.aux
del formula.log
del formula.pdf
ren formula.png %2
```
The resultant file is a transparent, PNG file of the LaTeX you entered into the code.


Issues and Errors:
-
Firstly, it is beyond my control what you enter into the editor box. If you enter something over the top, stupid, bizzare, or a combination of all these features, expect the outcome to be the same. Grant it, the program will not break - but you may get some funny results. Here are a few of these results:
- Weird images and/or text on images not intended. To fix this, try learning some of the basics of LaTeX - especially equations.
- The CMD window does not disappear automatically, instead showing `?`. Simply press enter and move on, then check the images.

Secondly, opening `Lithe.exe` from the windows search menu, rather than file explorer or terminal, will cause an error. Why? No idea (something to do with not having access to a file path) - just don't do that and you'll avoid the error.

To report an issue or an error different to the ones described - or similar too - the ones above, see the following page:
https://github.com/Catterall/Lithe/issues


Planned features/additions:
-
In regards to the GitHub page, the GitHub wiki is on the way and will be here soon. Furtheremore, I will spend time commenting the `.vb` files in the source code above, allowing viewing users more clarity into the code; this will also come very soon.

In regards to the program, I suppose I could make a more fancy, modern background and add even more buttons to the LaTeX snippets menu.
Furthermore, I may add a new pop-up form allowing the user to customize how the PNG file, such as size, etc.

Project History:
-
Lithe originally started as, "Virtual Formulae", a free physics formula program that would allow users to quickly select a physics formula and work out the answer to a missing parameter. However, I quickly got overwhelmed, realising that adding every physics formula in existence to a program might take a while. However, I would not be beaten. After deleting Virtual Formulae I thought to myself, "What would be a good application that would be both simple to program as the beginner that I am and useful?". It was at this point - my mind filled with formulas, that I realised that I hadn't seen any offline LaTeX to PNG converter applications for people who don't understand TeX commands ever. Not even one. So, I made it.

First, I had to brainstorm. Unfortunately, my version of of brainstorming usually means drawing a picture in MS-Paint that I inevitably have to show everyone whilst not taking any care to be professional. So, here they are; my amazing artist skills:

![Project brainstorming.](https://user-images.githubusercontent.com/66549839/84093617-a5610480-a9f2-11ea-8eb1-3f0e92f40193.png)

Beautiful. Absolutely beautiful. Anyway, after brainstorming the main window I got to work actually doing work. I opened Visual Studio, mindlessly navigated to form applications since they're the only ones I can use at the moment (I *am* a beginner, after all!) and designed the main form. After around ~20 minutes of designing, the form would look like the form you can see at the top of this README.md file.

After this, I realised that most webstite contemparies of my program would often have side pannels, allowing the user to insert equations and formulas into their editor - so I made my own. Obviously, I didn't include every single thing those websites offer - after all, coding buttons in VB.net is time conusming after coding 55, let alone hundreds on my own - and my main focus was geared towards created the LaTex to PNG converter code, so I stopped after coding 55 of these options and moved towards creating the code, knowing that it would be the most important and time consuming (in terms of learning) part of the application to make. 

Most of my first attempts were complete disasters, I'm not afraid to admit that. For a start, I attempted to install Magick Images to Visual Studio - which was a bad idea. Then, I realised the my Visual Studio, for reasons I still don't know today, didn't even *contain* the configurations nessesary to add additional libraries and directories (and no, stackoverflow was not helpful; just repeated the same things over and over again - none of which worked) but finally I had an epiphany: "Why not just do this in .bat lol". So that's what I did. Unfortunately, this means that you have to install a bunch of things, although you'd still need to install *most* of them regardless (and image magick, the one you *may* not need to install if I was a God at coding, is a quick install anyway). Although, I'm still not sure whether that's true - for all I know you might still have needed to install them all regardless, so I'm going to move on (Man, libraries and stuff confuse me).

Eventually I created the .bat file, made it do a few things that you've already read further up the README.md file and now I only had one last thing to do; test it fully... OK it worked, no suprises, you wouldn't reading this if otherwise. Grant it, you can still mess up the application if you screw with it on purpose, but it isn't "Oh no, I need reinstall" levels of messed up - more just, "Oh no, I need to rerun the program and maybe delete that/those wonky image(s) I just made."

And that's pretty much it. The history of this project, now I can breathe a sigh of relief.
