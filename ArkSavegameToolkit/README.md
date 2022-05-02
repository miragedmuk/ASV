# Ark Savegame Toolkit
Basically libraries to analyze savegames files for ARK: Survival Evolved

A C# rewrite from Java of Qowyn's [ark-savegame-toolkit](https://github.com/Qowyn/ark-savegame-toolkit) v0.8.1 and some parts of [ark-tools](https://github.com/Qowyn/ark-tools) v0.6.4.

### SavegameToolkit

This is a library that actually reads the files of an ARK "Saved" folder. It also can write the content in Json format, can read the Json files and write back to binary files.

However, reading Json is not fully implemented, writing binary is not tested at all and certainly contains some errors that break the savegame files.
I also refactored some parts to better match the C# philosophy, or to be able to write C# code at all, or because I thought it is better structured in a different way.

### SavegameToolkitAdditions

A few parts that were originally part of ArkTools but are useful for other projects too.

## Thanks

Thanks to Qowyn for his great work to analyze the binary format of the ARK savegame files and his Java version of ArkTools/SavegameToolkit.
No thanks for the invention of the Java programming language. 90% of the translation was adjusting minor language differences, 9% was finding the equivalent C# expression, 1% was figuring out how it can be done in C#. The time effort seemed to be the opposite.
