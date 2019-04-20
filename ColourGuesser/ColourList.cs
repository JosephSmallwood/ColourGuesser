﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourGuesser
{
    public class ColourList
    {
        public Colour[] colours = {
            //new Colour("", r: , g: , b: ),
            new Colour("Absolute Zero", r: 0, g: 72, b: 186),
            new Colour("Acid Green", r: 176, g: 191, b: 26),
            new Colour("Aero", r: 124, g: 185, b: 232),
            new Colour("Aero Blue", r: 201, g: 255, b: 229),
            new Colour("Air Superiority Blue", r: 114, g: 160, b: 193),
            new Colour("Alablaster", r: 237, g: 234, b: 224),
            new Colour("Alice Blue", r: 240, g: 248, b: 255),
            new Colour("Alien Armpit", r: 197, g: 225, b: 122),
            new Colour("Alloy Orange", r: 196, g: 98, b: 16),
            new Colour("Almond", r: 239, g: 222, b: 205),
            new Colour("Amazon", r: 59, g: 122, b: 87),
            new Colour("Amber", r: 255, g: 191, b: 0),
            new Colour("Amethyst", r: 153, g: 102, b: 204),
            new Colour("Antique Brass", r: 205, g: 149, b: 117),
            new Colour("Antique Bronze", r: 102, g: 93, b: 30),
            new Colour("Antique Fuchsia", r: 145, g: 92, b: 131),
            new Colour("Antique Ruby", r: 132, g: 27, b: 45),
            new Colour("Antique White", r: 250, g: 235, b: 215),
            new Colour("Ao", r: 0, g: 128, b: 0),
            new Colour("Apple Green", r: 141, g: 182, b: 0),
            new Colour("Apricot", r: 251, g: 206, b: 177),
            new Colour("Aquamarine", r: 127, g: 255, b: 212),
            new Colour("Artic Lime", r: 208, g: 255, b: 20),
            new Colour("Army Green", r: 75, g: 83, b: 32),
            new Colour("Artichoke", r: 143, g: 151, b: 121),
            new Colour("Arylide Yellow", r: 233, g: 214, b: 107),
            new Colour("Ash Gray", r: 178, g: 190, b: 181),
            new Colour("Asparagus", r: 135, g: 169, b: 107),
            new Colour("Atomic Tangerine", r: 255, g: 153, b: 102),
            new Colour("Auburn", r: 165, g: 42, b: 42),
            new Colour("Aureolin", r: 253, g: 238, b: 0),
            new Colour("AuroMetalSaurus", r: 110, g: 127, b: 128),
            new Colour("Avocado", r: 86, g: 130, b: 3),
            new Colour("Azure", r: 240, g: 255, b: 255),
            new Colour("Baby Blue", r: 137, g: 207, b: 240),
            new Colour("Baby Blue Eyes", r: 161, g: 202, b: 241),
            new Colour("Baby Pink", r: 244, g: 194, b: 194),
            new Colour("Baby Powder", r: 254, g: 254, b: 250),
            new Colour("Baker-Miller Pink", r: 255, g: 145, b: 175),
            new Colour("Banana", r: 227, g: 207, b: 87),
            new Colour("Banana Mania", r: 250, g: 231, b: 181),
            new Colour("Barbie Pink", r: 218, g: 24, b: 132),
            new Colour("Barn Red", r: 124, g: 10, b: 2),
            new Colour("Battleship Grey", r: 132, g: 132, b: 130),
            new Colour("B'dazzled Blue", r: 46, g: 88, b: 148),
            new Colour("Beau Blue", r: 188, g: 212, b: 230),
            new Colour("Beaver", r: 159, g: 129, b: 112),
            new Colour("Beetroot", r: 142, g: 56, b: 142),
            new Colour("Beige", r: 245, g: 245, b: 220),
            new Colour("Biaque", r: 255, g: 228, b: 196),
            new Colour("Big Dip O’Ruby", r: 156, g: 37, b: 66),
            new Colour("Big Foot Feet", r: 217, g: 154, b: 108),
            new Colour("Bisque", r: 255, g: 228, b: 196),
            new Colour("Bistre", r: 61, g: 43, b: 31),
            new Colour("Bistre Brown", r: 150, g: 113, b: 23),
            new Colour("Bitter Lemon", r: 202, g: 224, b: 13),
            new Colour("Bitter Lime", r: 191, g: 255, b: 0),
            new Colour("Bittersweet", r: 254, g: 111, b: 94),
            new Colour("Bittersweet Shimmer", r: 191, g: 79, b: 81),
            new Colour("Blanched Almond", r: 255, g: 235, b: 205),
            new Colour("Black", r: 0, g: 0, b: 0),
            new Colour("Black-Bean", r: 61, g: 12, b: 2),
            new Colour("Black-Chocolate", r: 27, g: 24, b: 17),
            new Colour("Black-Coffee", r: 59, g: 47, b: 47),
            new Colour("Black-Coral", r: 84, g: 98, b: 111),
            new Colour("Black-Jungle Green", r: 0, g: 0, b: 0),
            new Colour("Black-Olive", r: 59, g: 60, b: 54),
            new Colour("Black-Shadows", r: 191, g: 175, b: 178),//////
            new Colour("Blue", r: 0, g: 0, b: 255),
            new Colour("Blue", r: 0, g: 0, b: 238),
            new Colour("Blue-Violet", r: 138, g: 43, b: 226),
            new Colour("Brick", r: 156, g: 102, b: 31),
            new Colour("Brown", r: 165, g: 42, b: 42),
            new Colour("BurlyWood", r: 222, g: 184, b: 135),
            new Colour("Burnt Sienna", r: 138, g: 54, b: 15),
            new Colour("Burnt Umber", r: 138, g: 51, b: 36),
            new Colour("Cadet Blue", r: 95, g: 158, b: 160),
            new Colour("Cadmium Orange", r: 255, g: 97, b: 3),
            new Colour("Cadmium Yellow", r: 255, g: 153, b: 18),
            new Colour("Carrot", r: 237, g: 145, b: 33),
            new Colour("Chartreuse", r: 127, g: 255, b: 0),
            new Colour("Chocolate", r: 210, g: 105, b: 30),
            new Colour("Cobalt", r: 61, g: 89, b: 171),
            new Colour("Cobalt Green", r: 61, g: 145, b:64),
            new Colour("Cold Gray", r: 128, g: 138, b: 135),
            new Colour("Coral", r: 255, g: 127, b: 80),
            new Colour("Cornflower Blue", r: 100, g: 149, b: 237),
            new Colour("Cornsilk", r: 255, g: 247, b: 220),
            new Colour("Crimson", r: 220, g: 20, b: 60),
            new Colour("Cyan", r: 0, g: 255, b: 255),
            new Colour("Dark Blue", r: 0, g: 0, b: 139),
            new Colour("Dark Golden Rod", r: 184, g: 134, b: 11),
            new Colour("Dark Gray", r: 85, g: 85, b: 85),
            new Colour("Dark Green", r: 0, g: 100, b: 0),
            new Colour("Dark Kahki", r: 240, g: 230, b: 140),
            new Colour("Dark Olive-Green", r: 85, g: 107, b: 47),
            new Colour("Dark Orange", r: 255, g: 140, b: 0),
            new Colour("Dark Orchid", r: 163, g: 50, b: 204),
            new Colour("Dark Red", r: 139, g: 0, b: 0),
            new Colour("Dark Salmon", r: 233, g: 150, b: 122),
            new Colour("Dark Sea Green", r: 193, g: 255, b: 193),
            new Colour("Dark Slate-Blue", r: 72, g: 61, b: 139),
            new Colour("Dark Slate-Gray", r: 47, g: 79, b: 79),
            new Colour("Dark Turquoise", r: 0, g: 206, b: 209),
            new Colour("Dark Violet", r: 148, g: 0, b: 211),
            new Colour("Deep Pink", r: 255, g: 20, b: 147),
            new Colour("Deep Sky Blue", r: 0, g: 191, b: 255),
            new Colour("Dodger Blue", r: 30, g: 144, b: 255),
            new Colour("Eggshell", r: 252, g: 230, b: 201),
            new Colour("Emerald Green", r: 0, g: 201, b: 87),
            new Colour("Flesh", r: 255, g: 125, b: 64),
            new Colour("Floral White", r: 255, g: 250, b: 240),
            new Colour("Firebrick", r: 178, g: 34, b: 34),
            new Colour("Forrest Green", r: 34, g: 139, b: 34),
            new Colour("Green", r: 0, g: 205, b: 0),
            new Colour("Green-Yellow", r: 173, g: 255, b: 47),
            new Colour("Ghost-White", r: 248, g: 248, b: 255),
            new Colour("Gold", r: 255, g: 215, b: 0),
            new Colour("Goldenrod", r: 218, g: 165, b: 32),
            new Colour("Honeydew", r: 240, g: 255, b: 240),
            new Colour("Hot Pink", r: 255, g: 105, b: 180),
            new Colour("Indian Red", r: 176, g: 23, b: 31),
            new Colour("Indigo", r: 75, g: 0, b: 130),
            new Colour("Ivory", r: 255, g: 255, b: 240),
            new Colour("Ivory-Black", r: 255, g: 255, b: 240),
            new Colour("Khaki", r: 240, g: 230, b: 140),
            new Colour("Lawn Green", r: 124, g: 252, b: 0),
            new Colour("Lavender", r: 230, g: 230, b: 250),
            new Colour("Lavender Blush", r: 255, g: 240, b: 245),
            new Colour("lemon Chiffon", r: 255, g: 250, b: 205),
            new Colour("Light Blue", r: 173, g: 216, b: 230),
            new Colour("Light Coral", r: 240, g: 128, b: 128),
            new Colour("Light Cyan", r: 224, g: 255, b: 255),
            new Colour("Light Golden Rod", r: 255, g: 236, b: 139),
            new Colour("Light Golden Rod Yellow", r: 250, g: 250, b: 210),
            new Colour("Light Gray", r: 170, g: 170, b: 170),
            new Colour("Light Pink", r: 255, g: 182, b: 185),
            new Colour("Light Salmon", r: 255, g: 160, b: 122),
            new Colour("Light Sea Green", r: 32, g: 178, b: 170),
            new Colour("Light Slate-Blue", r: 132, g: 112, b: 255),
            new Colour("Light Slate-Gray", r: 119, g: 136, b: 153),
            new Colour("Lignt Sky Blue", r: 135, g: 206, b: 250),
            new Colour("Light Steel-Blue", r: 176, g: 196, b: 22),
            new Colour("Light Yellow", r: 255, g: 255, b: 224),
            new Colour("Lime", r: 0, g: 255, b: 0),
            new Colour("Lime Green", r: 50, g: 205, b: 50),
            new Colour("Linen", r: 250, g: 240, b: 230),
            new Colour("Magenta", r: 255, g: 0, b: 255),
            new Colour("Manganese-Blue", r: 3, g: 168, b: 158),
            new Colour("Dark Magenta", r: 139, g: 0, b: 139),
            new Colour("Maroon", r: 255, g: 52, b: 179),
            new Colour("Medium Aquamarine", r: 102, g: 205, b: 170),
            new Colour("Medium Blue", r: 0, g: 0, b: 205),
            new Colour("Medium Orchid", r: 186, g: 85, b: 211),
            new Colour("Medium Purple", r: 147, g: 112, b: 219),
            new Colour("Medium Sea Green", r: 60, g: 179, b: 113),
            new Colour("Meduim Slate-blue", r: 123, g: 104, b: 238),
            new Colour("Medium Spring Green", r: 0, g: 250, b: 154),
            new Colour("Medium Turquoise", r: 72, g: 209, b: 204),
            new Colour("Medium Violet-Red", r: 199, g: 21, b: 133),
            new Colour("Melon", r: 227, g: 168, b: 105),
            new Colour("Midnight Blue", r: 25, g: 25, b: 112),
            new Colour("Mint", r: 189, g: 252, b: 201),
            new Colour("Mint Cream", r: 245, g: 255, b: 250),
            new Colour("Misty Rose", r: 255, g: 228, b: 225),
            new Colour("Moccasin", r: 255, g: 228, b: 181),
            new Colour("Navy", r: 0, g: 0, b: 128),
            new Colour("Navajowhite", r: 255, g: 222, b: 173),
            new Colour("Old Lace", r: 253, g: 245, b: 230),
            new Colour("Olive", r: 128, g: 128, b: 0),
            new Colour("Olive Drab", r: 107, g: 142, b: 35),
            new Colour("Orange", r: 255, g: 128, b: 0),
            new Colour("orange-Red", r: 255, g: 69, b: 0),
            new Colour("Orchid", r: 218, g: 113, b: 214),
            new Colour("Pale Golden Rod", r: 238, g: 232, b: 170),
            new Colour("Pale Green", r: 152, g: 251, b: 152),
            new Colour("Pale Turquoise", r: 187, g: 255, b: 255),
            new Colour("Pale Violet-Red", r: 219, g: 112, b: 147),
            new Colour("Papaya Whip", r: 255, g: 239, b: 213),
            new Colour("Peachpuff", r: 255, g: 218, b: 185),
            new Colour("Peacock", r: 51, g: 161, b: 201),
            new Colour("Pink", r: 255, g: 192, b: 203),
            new Colour("Plum", r: 255, g: 187, b: 255),
            new Colour("Powder Blue", r: 176, g: 224, b: 230),
            new Colour("Purple", r: 128, g: 0, b: 128),
            new Colour("Raw Sienna", r: 199, g: 97, b: 20),
            new Colour("Raspberry", r: 135, g: 38, b: 87),
            new Colour("Red", r: 255, g: 0, b: 0),
            new Colour("Rosy Brown", r: 188, g: 143, b: 143),
            new Colour("Royal Blue", r: 65, g: 105, b: 225),
            new Colour("Salmon", r: 198, g: 113, b: 113),
            new Colour("Sandy Bown", r: 244, g: 164, b: 96),
            new Colour("Sap Green", r: 48, g: 128, b: 20),
            new Colour("Seashell", r: 255, g: 245, b: 238),
            new Colour("Sea Green", r: 84, g: 255, b: 159),
            new Colour("Sepia", r: 94, g: 38, b: 18),
            new Colour("Sienna", r: 160, g: 82, b: 45),
            new Colour("Silver", r: 192, g: 192, b: 192),
            new Colour("Sky Blue", r: 135, g: 206, b: 235),
            new Colour("Slate-Gray", r: 112, g: 128, b: 144),
            new Colour("Slate-Blue", r: 106, g: 90, b: 205),
            new Colour("Snow", r: 255, g: 250, b: 250),
            new Colour("Spring Green", r: 0, g: 255, b: 127),
            new Colour("Steel-Blue", r: 70, g: 130, b: 180),
            new Colour("Tan", r: 210, g: 180, b: 140),
            new Colour("Teal", r: 0, g: 128, b: 128),
            new Colour("Thistle", r: 216, g: 191, b: 216),
            new Colour("Tomato", r: 255, g: 99, b: 71),
            new Colour("Turquiose", r: 64, g: 224, b: 208),
            new Colour("Turquiose-Blue", r:0, g: 199, b: 140),
            new Colour("Violet", r: 238, g: 130, b: 238),
            new Colour("Violet-Red", r: 255, g: 62, b: 150),
            new Colour("Yellow", r: 255, g: 255, b: 0),
            new Colour("Warm Gray", r: 128, g: 128, b: 105),
            new Colour("Wheat", r: 245, g: 222, b: 179),
            new Colour("White", r: 255, g: 255, b: 255),
        };
    }
}