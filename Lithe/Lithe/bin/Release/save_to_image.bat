cd "generated images"
pdflatex "\def\formula{%1}\input{formula.tex}"
magick -density 300 formula.pdf -quality 90 formula.png
del formula.tex
del formula.aux
del formula.log
del formula.pdf
ren formula.png %2