﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    public class FiveLetterDictionary
    {
        public static string fiveLetterWords(int randomNumber)
        {
            Dictionary<int, string> fiveDictionary = new Dictionary<int, string>()
            {
                { 1, "Abuse" },
                { 2, "Adult" },
                { 3, "Agent" },
                { 4, "Anger" },
                { 5, "Apple" },
                { 6, "Award" },
                { 7, "Basis" },
                { 8, "Beach" },
                { 9, "Birth" },
                { 10, "Block" },
                { 11, "Blood" },
                { 12, "Board" },
                { 13, "Brain" },
                { 14, "Bread" },
                { 15, "Break" },
                { 16, "Brown" },
                { 17, "Buyer" },
                { 18, "Cause" },
                { 19, "Chain" },
                { 20, "Chair" },
                { 21, "Chest" },
                { 22, "Chief" },
                { 23, "Child" },
                { 24, "China" },
                { 25, "Claim" },
                { 26, "Class" },
                { 27, "Clock" },
                { 28, "Coach" },
                { 29, "Coast" },
                { 30, "Court" },
                { 31, "Cover" },
                { 32, "Cream" },
                { 33, "Crime" },
                { 34, "Cross" },
                { 35, "Crowd" },
                { 36, "Crown" },
                { 37, "Cycle" },
                { 38, "Dance" },
                { 39, "Death" },
                { 40, "Depth" },
                { 41, "Doubt" },
                { 42, "Draft" },
                { 43, "Drama" },
                { 44, "Dream" },
                { 45, "Dress" },
                { 46, "Drink" },
                { 47, "Drive" },
                { 48, "Earth" },
                { 49, "Enemy" },
                { 50, "Entry" },
                { 51, "Error" },
                { 52, "Event" },
                { 53, "Faith" },
                { 54, "Fault" },
                { 55, "Field" },
                { 56, "Fight" },
                { 57, "Final" },
                { 58, "Floor" },
                { 59, "Focus" },
                { 60, "Force" },
                { 61, "Frame" },
                { 62, "Frank" },
                { 63, "Front" },
                { 64, "Fruit" },
                { 65, "Glass" },
                { 66, "Grant" },
                { 67, "Grass" },
                { 68, "Green" },
                { 69, "Group" },
                { 70, "Guide" },
                { 71, "Heart" },
                { 72, "Henry" },
                { 73, "Horse" },
                { 74, "Hotel" },
                { 75, "House" },
                { 76, "Image" },
                { 77, "Index" },
                { 78, "Input" },
                { 79, "Issue" },
                { 80, "Japan" },
                { 81, "Jones" },
                { 82, "Judge" },
                { 83, "Knife" },
                { 84, "Laura" },
                { 85, "Layer" },
                { 86, "Level" },
                { 87, "Lewis" },
                { 88, "Light" },
                { 89, "Limit" },
                { 90, "Lunch" },
                { 91, "Major" },
                { 92, "March" },
                { 93, "Match" },
                { 94, "Metal" },
                { 95, "Model" },
                { 96, "Money" },
                { 97, "Month" },
                { 98, "Motor" },
                { 99, "Mouth" },
                { 100, "Music" },
                { 101, "Night" },
                { 102, "Noise" },
                { 103, "North" },
                { 104, "Novel" },
                { 105, "Nurse" },
                { 106, "Offer" },
                { 107, "Order" },
                { 108, "Other" },
                { 109, "Owner" },
                { 110, "Panel" },
                { 111, "Paper" },
                { 112, "Party" },
                { 113, "Peace" },
                { 114, "Peter" },
                { 115, "Phase" },
                { 116, "Phone" },
                { 117, "Piece" },
                { 118, "Pilot" },
                { 119, "Pitch" },
                { 120, "Place" },
                { 121, "Plane" },
                { 122, "Plant" },
                { 123, "Plate" },
                { 124, "Point" },
                { 125, "Pound" },
                { 126, "Power" },
                { 127, "Press" },
                { 128, "Price" },
                { 129, "Pride" },
                { 130, "Prize" },
                { 131, "Proof" },
                { 132, "Queen" },
                { 133, "Radio" },
                { 134, "Range" },
                { 135, "Ratio" },
                { 136, "Reply" },
                { 137, "Right" },
                { 138, "River" },
                { 139, "Round" },
                { 140, "Route" },
                { 141, "Rugby" },
                { 142, "Scale" },
                { 143, "Scene" },
                { 144, "Scope" },
                { 145, "Score" },
                { 146, "Sense" },
                { 147, "Shape" },
                { 148, "Share" },
                { 149, "Sheep" },
                { 150, "Sheet" },
                { 151, "Shift" },
                { 152, "Shirt" },
                { 153, "Shock" },
                { 154, "Sight" },
                { 155, "Simon" },
                { 156, "Skill" },
                { 157, "Sleep" },
                { 158, "Smile" },
                { 159, "Smith" },
                { 160, "Smoke" },
                { 161, "Sound" },
                { 162, "South" },
                { 163, "Space" },
                { 164, "Speed" },
                { 165, "Spite" },
                { 166, "Sport" },
                { 167, "Squad" },
                { 168, "Staff" },
                { 169, "Stage" },
                { 170, "Start" },
                { 171, "State" },
                { 172, "Steam" },
                { 173, "Steel" },
                { 174, "Stock" },
                { 175, "Stone" },
                { 176, "Store" },
                { 177, "Study" },
                { 178, "Stuff" },
                { 179, "Style" },
                { 180, "Sugar" },
                { 181, "Table" },
                { 182, "Taste" },
                { 183, "Terry" },
                { 184, "Theme" },
                { 185, "Thing" },
                { 186, "Title" },
                { 187, "Total" },
                { 188, "Touch" },
                { 189, "Tower" },
                { 190, "Track" },
                { 191, "Trade" },
                { 192, "Train" },
                { 193, "Trend" },
                { 194, "Trial" },
                { 195, "Trust" },
                { 196, "Truth" },
                { 197, "Uncle" },
                { 198, "Union" },
                { 199, "Unity" },
                { 200, "Value" },
                { 201, "Video" },
                { 202, "Visit" },
                { 203, "Voice" },
                { 204, "Waste" },
                { 205, "Watch" },
                { 206, "Water" },
                { 207, "While" },
                { 208, "White" },
                { 209, "Whole" },
                { 210, "Woman" },
                { 211, "World" },
                { 212, "Youth" },
                { 213, "Admit" },
                { 214, "Adopt" },
                { 215, "Agree" },
                { 216, "Allow" },
                { 217, "Alter" },
                { 218, "Apply" },
                { 219, "Argue" },
                { 220, "Arise" },
                { 221, "Avoid" },
                { 222, "Begin" },
                { 223, "Blame" },
                { 224, "Break" },
                { 225, "Bring" },
                { 226, "Build" },
                { 227, "Burst" },
                { 228, "Carry" },
                { 229, "Catch" },
                { 230, "Cause" },
                { 231, "Check" },
                { 232, "Claim" },
                { 233, "Clean" },
                { 234, "Clear" },
                { 235, "Climb" },
                { 236, "Close" },
                { 237, "Count" },
                { 238, "Cover" },
                { 239, "Cross" },
                { 240, "Dance" },
                { 241, "Doubt" },
                { 242, "Drink" },
                { 243, "Drive" },
                { 244, "Enjoy" },
                { 245, "Enter" },
                { 246, "Exist" },
                { 247, "Fight" },
                { 248, "Focus" },
                { 249, "Force" },
                { 250, "Guess" },
                { 251, "Imply" },
                { 252, "Issue" },
                { 253, "Judge" },
                { 254, "Laugh" },
                { 255, "Learn" },
                { 256, "Leave" },
                { 257, "Let’s" },
                { 258, "Limit" },
                { 259, "Marry" },
                { 260, "Match" },
                { 261, "Occur" },
                { 262, "Offer" },
                { 263, "Order" },
                { 264, "Phone" },
                { 265, "Place" },
                { 266, "Point" },
                { 267, "Press" },
                { 268, "Prove" },
                { 269, "Raise" },
                { 270, "Reach" },
                { 271, "Refer" },
                { 272, "Relax" },
                { 273, "Serve" },
                { 274, "Shall" },
                { 275, "Share" },
                { 276, "Shift" },
                { 277, "Shoot" },
                { 278, "Sleep" },
                { 279, "Solve" },
                { 280, "Sound" },
                { 281, "Speak" },
                { 282, "Spend" },
                { 283, "Split" },
                { 284, "Stand" },
                { 285, "Start" },
                { 286, "State" },
                { 287, "Stick" },
                { 288, "Study" },
                { 289, "Teach" },
                { 290, "Thank" },
                { 291, "Think" },
                { 292, "Throw" },
                { 293, "Touch" },
                { 294, "Train" },
                { 295, "Treat" },
                { 296, "Trust" },
                { 297, "Visit" },
                { 298, "Voice" },
                { 299, "Waste" },
                { 300, "Watch" },
                { 301, "Worry" },
                { 302, "Would" },
                { 303, "Write" },
                { 304, "Above" },
                { 305, "Acute" },
                { 306, "Alive" },
                { 307, "Alone" },
                { 308, "Angry" },
                { 309, "Aware" },
                { 310, "Awful" },
                { 311, "Basic" },
                { 312, "Black" },
                { 313, "Blind" },
                { 314, "Brave" },
                { 315, "Brief" },
                { 316, "Broad" },
                { 317, "Brown" },
                { 318, "Cheap" },
                { 319, "Chief" },
                { 320, "Civil" },
                { 321, "Clean" },
                { 322, "Clear" },
                { 323, "Close" },
                { 324, "Crazy" },
                { 325, "Daily" },
                { 326, "Dirty" },
                { 327, "Early" },
                { 328, "Empty" },
                { 329, "Equal" },
                { 330, "Exact" },
                { 331, "Extra" },
                { 332, "Faint" },
                { 333, "FALSE" },
                { 334, "Fifth" },
                { 335, "Final" },
                { 336, "First" },
                { 337, "Fresh" },
                { 338, "Front" },
                { 339, "Funny" },
                { 340, "Giant" },
                { 341, "Grand" },
                { 342, "Great" },
                { 343, "Green" },
                { 344, "Gross" },
                { 345, "Happy" },
                { 346, "Harsh" },
                { 347, "Heavy" },
                { 348, "Human" },
                { 349, "Ideal" },
                { 350, "Inner" },
                { 351, "Joint" },
                { 352, "Large" },
                { 353, "Legal" },
                { 354, "Level" },
                { 355, "Light" },
                { 356, "Local" },
                { 357, "Loose" },
                { 358, "Lucky" },
                { 359, "Magic" },
                { 360, "Major" },
                { 361, "Minor" },
                { 362, "Moral" },
                { 363, "Naked" },
                { 364, "Nasty" },
                { 365, "Naval" },
                { 366, "Other" },
                { 367, "Outer" },
                { 368, "Plain" },
                { 369, "Prime" },
                { 370, "Prior" },
                { 371, "Proud" },
                { 372, "Quick" },
                { 373, "Quiet" },
                { 374, "Rapid" },
                { 375, "Ready" },
                { 376, "Right" },
                { 377, "Roman" },
                { 378, "Rough" },
                { 379, "Round" },
                { 380, "Royal" },
                { 381, "Rural" },
                { 382, "Sharp" },
                { 383, "Sheer" },
                { 384, "Short" },
                { 385, "Silly" },
                { 386, "Sixth" },
                { 387, "Small" },
                { 388, "Smart" },
                { 389, "Solid" },
                { 390, "Sorry" },
                { 391, "Spare" },
                { 392, "Steep" },
                { 393, "Still" },
                { 394, "Super" },
                { 395, "Sweet" },
                { 396, "Thick" },
                { 397, "Third" },
                { 398, "Tight" },
                { 399, "Total" },
                { 400, "Tough" },
                { 401, "Upper" },
                { 402, "Upset" },
                { 403, "Urban" },
                { 404, "Usual" },
                { 405, "Vague" },
                { 406, "Valid" },
                { 407, "Vital" },
                { 408, "White" },
                { 409, "Whole" },
                { 410, "Wrong" },
                { 411, "Young" }
            };
            string word = fiveDictionary[randomNumber];
            return word;
        }
    }
}
