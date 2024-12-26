# GIF settings
Vers la fin des notes dans [process](./), j'ai commencé à améliorer les GIF animés, en créant une palette :

```
% ffmpeg -y -i filename-of-movie.mov -vf palettegen palette.png
```

Puis on se sert de cette palette pour créer le `GIF` final :

```
% ffmpeg -y -i name-of-movie.mov -i palette.png -filter_complex paletteuse -r 10 name-of-movie.gif
```

Si on veut redimensionner :

```
% ffmpeg -y -i movie-name.mov -i palette.png -filter_complex paletteuse -r 10 -s 1160x720 movie-name.gif
```