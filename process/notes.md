# Notes
Voici quelques notes générales sur Blender et ses particularités.

## Raccourcis + Hover
Certains (tous ?) raccourcis ne marchent pas si le pointeur de la souris n'est pas à l'intérieur de la fenêtre concernée. Par exemple, la touche `n` n'active pas `Tool`, `View`, et cætera si on n'est pas sur le `3d Viewport`.

## Références bibliothèques Blender
- [GeoScatter](https://www.geoscatter.com)
- [IvyGen](https://extensions.blender.org/add-ons/ivygen/)
- [Polyhaven](https://polyhaven.com/textures/terrain)
- [Blenderkit](https://www.blenderkit.com/get-blenderkit/)

Pour désactiver, par exemple `IvyGen`, retourne dans les préférences et décocher. Pour carrément l'enlever, il faut aller (sur macOS) dans le dossier `/Users/username/Library/Application Support/Blender/4.#/extensions` et effacer le dossier de l'extension, ou du fichier Python, par exemple ici `./ivygen/__init__.py`.

## Normals
Pour voir les normals (petites lignes bleues), il faut d'abord activer le bouton `Viewport Overlay`, puis à l'intérieur du sous-menu `Mesh Edit Mode Overlays` de ce celui-ci activer les options de visualisation des `Normals` :

![](images/mesh-edit-mode-overlays.png)

On peut aussi déterminer la taille de ces lignes.

## Glisser
Un truc pratique : quand on sélectionne un arrêt, on peut appuyer deux fois sur la touche `G` (pour `Grab`), ce qui le met en mode glisser (`Edge Slide`).

![](images/edge-slide.png)