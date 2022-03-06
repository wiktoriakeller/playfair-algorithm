﻿using Algorithms;

var playfair = new Playfair(new DuplicateRemover());
playfair.GenerateKeyTable("playfair example");
Console.WriteLine(playfair.Encipher("hide tee in the spot"));
Console.WriteLine(playfair.Decipher("bmodvixrkudmkfkv"));
