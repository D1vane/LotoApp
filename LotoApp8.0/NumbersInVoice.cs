﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoApp8._0
{
    public static class NumbersInVoice
    {
        /// <summary>
        /// Возвращает название аудиофайла по числу в стандартной скорости
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <returns></returns>
        public static string SwitchNumbers(int currentNumber, int speed)
        {
            if (speed == 1)
                return currentNumber switch
                {
                    1 => "1/voiceOne1x.wav",
                    2 => "2/voiceTwo1x.wav",
                    3 => "3/voiceThree1x.wav",
                    4 => "4/voiceFour1x.wav",
                    5 => "5/voiceFive1x.wav",
                    6 => "6/voiceSix1x.wav",
                    7 => "7/voiceSeven1x.wav",
                    8 => "8/voiceEight1x.wav",
                    9 => "9/voiceNine1x.wav",
                    10 => "10/voiceTen1x.wav",
                    11 => "11/voiceEleven1x.wav",
                    12 => "12/voiceTwelve1x.wav",
                    13 => "13/voiceThirteen1x.wav",
                    14 => "14/voiceFourteen1x.wav",
                    15 => "15/voiceFifteen1x.wav",
                    16 => "16/voiceSixteen1x.wav",
                    17 => "17/voiceSeventeen1x.wav",
                    18 => "18/voiceEighteen1x.wav",
                    19 => "19/voiceNineteen1x.wav",
                    20 => "20/voiceTwenty1x.wav",
                    21 => "21/voiceTwentyone1x.wav",
                    22 => "22/voiceTwentytwo1x.wav",
                    23 => "23/voiceTwentythree1x.wav",
                    24 => "24/voiceTwentyfour1x.wav",
                    25 => "25/voiceTwentyfive1x.wav",
                    26 => "26/voiceTwentysix1x.wav",
                    27 => "27/voiceTwentyseven1x.wav",
                    28 => "28/voiceTwentyeight1x.wav",
                    29 => "29/voiceTwentyNine1x.wav",
                    30 => "30/voiceThirty1x.wav",
                    31 => "31/voiceThirtyone1x.wav",
                    32 => "32/voiceThirtytwo1x.wav",
                    33 => "33/voiceThirtythree1x.wav",
                    34 => "34/voiceThirtyfour1x.wav",
                    35 => "35/voiceThirtyfive1x.wav",
                    36 => "36/voiceThirtysix1x.wav",
                    37 => "37/voiceThirtyseven1x.wav",
                    38 => "38/voiceThirtyeight1x.wav",
                    39 => "39/voiceThirtynine1x.wav",
                    40 => "40/voiceFourty1x.wav",
                    41 => "41/voiceFourtyone1x.wav",
                    42 => "42/voiceFourtytwo1x.wav",
                    43 => "43/voiceFourtythree1x.wav",
                    44 => "44/voiceFourtyfour1x.wav",
                    45 => "45/voiceFourtyfive1x.wav",
                    46 => "46/voiceFourtysix1x.wav",
                    47 => "47/voiceFourtyseven1x.wav",
                    48 => "48/voiceFourtyeight1x.wav",
                    49 => "49/voiceFourtynine1x.wav",
                    50 => "50/voiceFifty1x.wav",
                    51 => "51/voiceFiftyone1x.wav",
                    52 => "52/voiceFiftytwo1x.wav",
                    53 => "53/voiceFiftythree1x.wav",
                    54 => "54/voiceFiftyfour1x.wav",
                    55 => "55/voiceFiftyfive1x.wav",
                    56 => "56/voiceFiftysix1x.wav",
                    57 => "57/voiceFiftyseven1x.wav",
                    58 => "58/voiceFiftyeight1x.wav",
                    59 => "59/voiceFiftynine1x.wav",
                    60 => "60/voiceSixty1x.wav",
                    61 => "61/voiceSixtyone1x.wav",
                    62 => "62/voiceSixtytwo1x.wav",
                    63 => "63/voiceSixtythree1x.wav",
                    64 => "64/voiceSixtyfour1x.wav",
                    65 => "65/voiceSixtyfive1x.wav",
                    66 => "66/voiceSixtysix1x.wav",
                    67 => "67/voiceSixtyseven1x.wav",
                    68 => "68/voiceSixtyeight1x.wav",
                    69 => "69/voiceSixtynine1x.wav",
                    70 => "70/voiceSeventy1x.wav",
                    71 => "71/voiceSeventyone1x.wav",
                    72 => "72/voiceSeventytwo1x.wav",
                    73 => "73/voiceSeventythree1x.wav",
                    74 => "74/voiceSeventyfour1x.wav",
                    75 => "75/voiceSeventyfive1x.wav",
                    76 => "76/voiceSeventysix1x.wav",
                    77 => "77/voiceSeventyseven1x.wav",
                    78 => "78/voiceSeventyeight1x.wav",
                    79 => "79/voiceSeventynine1x.wav",
                    80 => "80/voiceEighty1x.wav",
                    81 => "81/voiceEightyone1x.wav",
                    82 => "82/voiceEightytwo1x.wav",
                    83 => "83/voiceEightythree1x.wav",
                    84 => "84/voiceEightyfour1x.wav",
                    85 => "85/voiceEightyfive1x.wav",
                    86 => "86/voiceEightysix1x.wav",
                    87 => "87/voiceEightyseven1x.wav",
                    88 => "88/voiceEightyeight1x.wav",
                    89 => "89/voiceEightynine1x.wav",
                    90 => "90/voiceNinety1x.wav",
                    _ => "errorInCode.wav",
                };
            else if (speed == 125)
                return currentNumber switch
                {
                    1 => "1/voiceOne125x.wav",
                    2 => "2/voiceTwo125x.wav",
                    3 => "3/voiceThree125x.wav",
                    4 => "4/voiceFour125x.wav",
                    5 => "5/voiceFive125x.wav",
                    6 => "6/voiceSix125x.wav",
                    7 => "7/voiceSeven125x.wav",
                    8 => "8/voiceEight125x.wav",
                    9 => "9/voiceNine125x.wav",
                    10 => "10/voiceTen125x.wav",
                    11 => "11/voiceEleven125x.wav",
                    12 => "12/voiceTwelve125x.wav",
                    13 => "13/voiceThirteen125x.wav",
                    14 => "14/voiceFourteen125x.wav",
                    15 => "15/voiceFifteen125x.wav",
                    16 => "16/voiceSixteen125x.wav",
                    17 => "17/voiceSeventeen125x.wav",
                    18 => "18/voiceEighteen125x.wav",
                    19 => "19/voiceNineteen125x.wav",
                    20 => "20/voiceTwenty125x.wav",
                    21 => "21/voiceTwentyone125x.wav",
                    22 => "22/voiceTwentytwo125x.wav",
                    23 => "23/voiceTwentythree125x.wav",
                    24 => "24/voiceTwentyfour125x.wav",
                    25 => "25/voiceTwentyfive125x.wav",
                    26 => "26/voiceTwentysix125x.wav",
                    27 => "27/voiceTwentyseven125x.wav",
                    28 => "28/voiceTwentyeight125x.wav",
                    29 => "29/voiceTwentyNine125x.wav",
                    30 => "30/voiceThirty125x.wav",
                    31 => "31/voiceThirtyone125x.wav",
                    32 => "32/voiceThirtytwo125x.wav",
                    33 => "33/voiceThirtythree125x.wav",
                    34 => "34/voiceThirtyfour125x.wav",
                    35 => "35/voiceThirtyfive125x.wav",
                    36 => "36/voiceThirtysix125x.wav",
                    37 => "37/voiceThirtyseven125x.wav",
                    38 => "38/voiceThirtyeight125x.wav",
                    39 => "39/voiceThirtynine125x.wav",
                    40 => "40/voiceFourty125x.wav",
                    41 => "41/voiceFourtyone125x.wav",
                    42 => "42/voiceFourtytwo125x.wav",
                    43 => "43/voiceFourtythree125x.wav",
                    44 => "44/voiceFourtyfour125x.wav",
                    45 => "45/voiceFourtyfive125x.wav",
                    46 => "46/voiceFourtysix125x.wav",
                    47 => "47/voiceFourtyseven125x.wav",
                    48 => "48/voiceFourtyeight125x.wav",
                    49 => "49/voiceFourtynine125x.wav",
                    50 => "50/voiceFifty125x.wav",
                    51 => "51/voiceFiftyone125x.wav",
                    52 => "52/voiceFiftytwo125x.wav",
                    53 => "53/voiceFiftythree125x.wav",
                    54 => "54/voiceFiftyfour125x.wav",
                    55 => "55/voiceFiftyfive125x.wav",
                    56 => "56/voiceFiftysix125x.wav",
                    57 => "57/voiceFiftyseven125x.wav",
                    58 => "58/voiceFiftyeight125x.wav",
                    59 => "59/voiceFiftynine125x.wav",
                    60 => "60/voiceSixty125x.wav",
                    61 => "61/voiceSixtyone125x.wav",
                    62 => "62/voiceSixtytwo125x.wav",
                    63 => "63/voiceSixtythree125x.wav",
                    64 => "64/voiceSixtyfour125x.wav",
                    65 => "65/voiceSixtyfive125x.wav",
                    66 => "66/voiceSixtysix125x.wav",
                    67 => "67/voiceSixtyseven125x.wav",
                    68 => "68/voiceSixtyeight125x.wav",
                    69 => "69/voiceSixtynine125x.wav",
                    70 => "70/voiceSeventy125x.wav",
                    71 => "71/voiceSeventyone125x.wav",
                    72 => "72/voiceSeventytwo125x.wav",
                    73 => "73/voiceSeventythree125x.wav",
                    74 => "74/voiceSeventyfour125x.wav",
                    75 => "75/voiceSeventyfive125x.wav",
                    76 => "76/voiceSeventysix125x.wav",
                    77 => "77/voiceSeventyseven125x.wav",
                    78 => "78/voiceSeventyeight125x.wav",
                    79 => "79/voiceSeventynine125x.wav",
                    80 => "80/voiceEighty125x.wav",
                    81 => "81/voiceEightyone125x.wav",
                    82 => "82/voiceEightytwo125x.wav",
                    83 => "83/voiceEightythree125x.wav",
                    84 => "84/voiceEightyfour125x.wav",
                    85 => "85/voiceEightyfive125x.wav",
                    86 => "86/voiceEightysix125x.wav",
                    87 => "87/voiceEightyseven125x.wav",
                    88 => "88/voiceEightyeight125x.wav",
                    89 => "89/voiceEightynine125x.wav",
                    90 => "90/voiceNinety125x.wav",
                    _ => "errorInCode.wav",
                };
            else if (speed == 15)
                return currentNumber switch
                {
                    1 => "1/voiceOne15x.wav",
                    2 => "2/voiceTwo15x.wav",
                    3 => "3/voiceThree15x.wav",
                    4 => "4/voiceFour15x.wav",
                    5 => "5/voiceFive15x.wav",
                    6 => "6/voiceSix15x.wav",
                    7 => "7/voiceSeven15x.wav",
                    8 => "8/voiceEight15x.wav",
                    9 => "9/voiceNine15x.wav",
                    10 => "10/voiceTen15x.wav",
                    11 => "11/voiceEleven15x.wav",
                    12 => "12/voiceTwelve15x.wav",
                    13 => "13/voiceThirteen15x.wav",
                    14 => "14/voiceFourteen15x.wav",
                    15 => "15/voiceFifteen15x.wav",
                    16 => "16/voiceSixteen15x.wav",
                    17 => "17/voiceSeventeen15x.wav",
                    18 => "18/voiceEighteen15x.wav",
                    19 => "19/voiceNineteen15x.wav",
                    20 => "20/voiceTwenty15x.wav",
                    21 => "21/voiceTwentyone15x.wav",
                    22 => "22/voiceTwentytwo15x.wav",
                    23 => "23/voiceTwentythree15x.wav",
                    24 => "24/voiceTwentyfour15x.wav",
                    25 => "25/voiceTwentyfive15x.wav",
                    26 => "26/voiceTwentysix15x.wav",
                    27 => "27/voiceTwentyseven15x.wav",
                    28 => "28/voiceTwentyeight15x.wav",
                    29 => "29/voiceTwentyNine15x.wav",
                    30 => "30/voiceThirty15x.wav",
                    31 => "31/voiceThirtyone15x.wav",
                    32 => "32/voiceThirtytwo15x.wav",
                    33 => "33/voiceThirtythree15x.wav",
                    34 => "34/voiceThirtyfour15x.wav",
                    35 => "35/voiceThirtyfive15x.wav",
                    36 => "36/voiceThirtysix15x.wav",
                    37 => "37/voiceThirtyseven15x.wav",
                    38 => "38/voiceThirtyeight15x.wav",
                    39 => "39/voiceThirtynine15x.wav",
                    40 => "40/voiceFourty15x.wav",
                    41 => "41/voiceFourtyone15x.wav",
                    42 => "42/voiceFourtytwo15x.wav",
                    43 => "43/voiceFourtythree15x.wav",
                    44 => "44/voiceFourtyfour15x.wav",
                    45 => "45/voiceFourtyfive15x.wav",
                    46 => "46/voiceFourtysix15x.wav",
                    47 => "47/voiceFourtyseven15x.wav",
                    48 => "48/voiceFourtyeight15x.wav",
                    49 => "49/voiceFourtynine15x.wav",
                    50 => "50/voiceFifty15x.wav",
                    51 => "51/voiceFiftyone15x.wav",
                    52 => "52/voiceFiftytwo15x.wav",
                    53 => "53/voiceFiftythree15x.wav",
                    54 => "54/voiceFiftyfour15x.wav",
                    55 => "55/voiceFiftyfive15x.wav",
                    56 => "56/voiceFiftysix15x.wav",
                    57 => "57/voiceFiftyseven15x.wav",
                    58 => "58/voiceFiftyeight15x.wav",
                    59 => "59/voiceFiftynine15x.wav",
                    60 => "60/voiceSixty15x.wav",
                    61 => "61/voiceSixtyone15x.wav",
                    62 => "62/voiceSixtytwo15x.wav",
                    63 => "63/voiceSixtythree15x.wav",
                    64 => "64/voiceSixtyfour15x.wav",
                    65 => "65/voiceSixtyfive15x.wav",
                    66 => "66/voiceSixtysix15x.wav",
                    67 => "67/voiceSixtyseven15x.wav",
                    68 => "68/voiceSixtyeight15x.wav",
                    69 => "69/voiceSixtynine15x.wav",
                    70 => "70/voiceSeventy15x.wav",
                    71 => "71/voiceSeventyone15x.wav",
                    72 => "72/voiceSeventytwo15x.wav",
                    73 => "73/voiceSeventythree15x.wav",
                    74 => "74/voiceSeventyfour15x.wav",
                    75 => "75/voiceSeventyfive15x.wav",
                    76 => "76/voiceSeventysix15x.wav",
                    77 => "77/voiceSeventyseven15x.wav",
                    78 => "78/voiceSeventyeight15x.wav",
                    79 => "79/voiceSeventynine15x.wav",
                    80 => "80/voiceEighty15x.wav",
                    81 => "81/voiceEightyone15x.wav",
                    82 => "82/voiceEightytwo15x.wav",
                    83 => "83/voiceEightythree15x.wav",
                    84 => "84/voiceEightyfour15x.wav",
                    85 => "85/voiceEightyfive15x.wav",
                    86 => "86/voiceEightysix15x.wav",
                    87 => "87/voiceEightyseven15x.wav",
                    88 => "88/voiceEightyeight15x.wav",
                    89 => "89/voiceEightynine15x.wav",
                    90 => "90/voiceNinety15x.wav",
                    _ => "errorInCode.wav",
                };
            else if (speed == 175)
                return currentNumber switch
                {
                    1 => "1/voiceOne175x.wav",
                    2 => "2/voiceTwo175x.wav",
                    3 => "3/voiceThree175x.wav",
                    4 => "4/voiceFour175x.wav",
                    5 => "5/voiceFive175x.wav",
                    6 => "6/voiceSix175x.wav",
                    7 => "7/voiceSeven175x.wav",
                    8 => "8/voiceEight175x.wav",
                    9 => "9/voiceNine175x.wav",
                    10 => "10/voiceTen175x.wav",
                    11 => "11/voiceEleven175x.wav",
                    12 => "12/voiceTwelve175x.wav",
                    13 => "13/voiceThirteen175x.wav",
                    14 => "14/voiceFourteen175x.wav",
                    15 => "15/voiceFifteen175x.wav",
                    16 => "16/voiceSixteen175x.wav",
                    17 => "17/voiceSeventeen175x.wav",
                    18 => "18/voiceEighteen175x.wav",
                    19 => "19/voiceNineteen175x.wav",
                    20 => "20/voiceTwenty175x.wav",
                    21 => "21/voiceTwentyone175x.wav",
                    22 => "22/voiceTwentytwo175x.wav",
                    23 => "23/voiceTwentythree175x.wav",
                    24 => "24/voiceTwentyfour175x.wav",
                    25 => "25/voiceTwentyfive175x.wav",
                    26 => "26/voiceTwentysix175x.wav",
                    27 => "27/voiceTwentyseven175x.wav",
                    28 => "28/voiceTwentyeight175x.wav",
                    29 => "29/voiceTwentyNine175x.wav",
                    30 => "30/voiceThirty175x.wav",
                    31 => "31/voiceThirtyone175x.wav",
                    32 => "32/voiceThirtytwo175x.wav",
                    33 => "33/voiceThirtythree175x.wav",
                    34 => "34/voiceThirtyfour175x.wav",
                    35 => "35/voiceThirtyfive175x.wav",
                    36 => "36/voiceThirtysix175x.wav",
                    37 => "37/voiceThirtyseven175x.wav",
                    38 => "38/voiceThirtyeight175x.wav",
                    39 => "39/voiceThirtynine175x.wav",
                    40 => "40/voiceFourty175x.wav",
                    41 => "41/voiceFourtyone175x.wav",
                    42 => "42/voiceFourtytwo175x.wav",
                    43 => "43/voiceFourtythree175x.wav",
                    44 => "44/voiceFourtyfour175x.wav",
                    45 => "45/voiceFourtyfive175x.wav",
                    46 => "46/voiceFourtysix175x.wav",
                    47 => "47/voiceFourtyseven175x.wav",
                    48 => "48/voiceFourtyeight175x.wav",
                    49 => "49/voiceFourtynine175x.wav",
                    50 => "50/voiceFifty175x.wav",
                    51 => "51/voiceFiftyone175x.wav",
                    52 => "52/voiceFiftytwo175x.wav",
                    53 => "53/voiceFiftythree175x.wav",
                    54 => "54/voiceFiftyfour175x.wav",
                    55 => "55/voiceFiftyfive175x.wav",
                    56 => "56/voiceFiftysix175x.wav",
                    57 => "57/voiceFiftyseven175x.wav",
                    58 => "58/voiceFiftyeight175x.wav",
                    59 => "59/voiceFiftynine175x.wav",
                    60 => "60/voiceSixty175x.wav",
                    61 => "61/voiceSixtyone175x.wav",
                    62 => "62/voiceSixtytwo175x.wav",
                    63 => "63/voiceSixtythree175x.wav",
                    64 => "64/voiceSixtyfour175x.wav",
                    65 => "65/voiceSixtyfive175x.wav",
                    66 => "66/voiceSixtysix175x.wav",
                    67 => "67/voiceSixtyseven175x.wav",
                    68 => "68/voiceSixtyeight175x.wav",
                    69 => "69/voiceSixtynine175x.wav",
                    70 => "70/voiceSeventy175x.wav",
                    71 => "71/voiceSeventyone175x.wav",
                    72 => "72/voiceSeventytwo175x.wav",
                    73 => "73/voiceSeventythree175x.wav",
                    74 => "74/voiceSeventyfour175x.wav",
                    75 => "75/voiceSeventyfive175x.wav",
                    76 => "76/voiceSeventysix175x.wav",
                    77 => "77/voiceSeventyseven175x.wav",
                    78 => "78/voiceSeventyeight175x.wav",
                    79 => "79/voiceSeventynine175x.wav",
                    80 => "80/voiceEighty175x.wav",
                    81 => "81/voiceEightyone175x.wav",
                    82 => "82/voiceEightytwo175x.wav",
                    83 => "83/voiceEightythree175x.wav",
                    84 => "84/voiceEightyfour175x.wav",
                    85 => "85/voiceEightyfive175x.wav",
                    86 => "86/voiceEightysix175x.wav",
                    87 => "87/voiceEightyseven175x.wav",
                    88 => "88/voiceEightyeight175x.wav",
                    89 => "89/voiceEightynine175x.wav",
                    90 => "90/voiceNinety175x.wav",
                    _ => "errorInCode.wav",
                };
            else
                return currentNumber switch
                {
                    1 => "1/voiceOne2x.wav",
                    2 => "2/voiceTwo2x.wav",
                    3 => "3/voiceThree2x.wav",
                    4 => "4/voiceFour2x.wav",
                    5 => "5/voiceFive2x.wav",
                    6 => "6/voiceSix2x.wav",
                    7 => "7/voiceSeven2x.wav",
                    8 => "8/voiceEight2x.wav",
                    9 => "9/voiceNine2x.wav",
                    10 => "10/voiceTen2x.wav",
                    11 => "11/voiceEleven2x.wav",
                    12 => "12/voiceTwelve2x.wav",
                    13 => "13/voiceThirteen2x.wav",
                    14 => "14/voiceFourteen2x.wav",
                    15 => "15/voiceFifteen2x.wav",
                    16 => "16/voiceSixteen2x.wav",
                    17 => "17/voiceSeventeen2x.wav",
                    18 => "18/voiceEighteen2x.wav",
                    19 => "19/voiceNineteen2x.wav",
                    20 => "20/voiceTwenty2x.wav",
                    21 => "21/voiceTwentyone2x.wav",
                    22 => "22/voiceTwentytwo2x.wav",
                    23 => "23/voiceTwentythree2x.wav",
                    24 => "24/voiceTwentyfour2x.wav",
                    25 => "25/voiceTwentyfive2x.wav",
                    26 => "26/voiceTwentysix2x.wav",
                    27 => "27/voiceTwentyseven2x.wav",
                    28 => "28/voiceTwentyeight2x.wav",
                    29 => "29/voiceTwentyNine2x.wav",
                    30 => "30/voiceThirty2x.wav",
                    31 => "31/voiceThirtyone2x.wav",
                    32 => "32/voiceThirtytwo2x.wav",
                    33 => "33/voiceThirtythree2x.wav",
                    34 => "34/voiceThirtyfour2x.wav",
                    35 => "35/voiceThirtyfive2x.wav",
                    36 => "36/voiceThirtysix2x.wav",
                    37 => "37/voiceThirtyseven2x.wav",
                    38 => "38/voiceThirtyeight2x.wav",
                    39 => "39/voiceThirtynine2x.wav",
                    40 => "40/voiceFourty2x.wav",
                    41 => "41/voiceFourtyone2x.wav",
                    42 => "42/voiceFourtytwo2x.wav",
                    43 => "43/voiceFourtythree2x.wav",
                    44 => "44/voiceFourtyfour2x.wav",
                    45 => "45/voiceFourtyfive2x.wav",
                    46 => "46/voiceFourtysix2x.wav",
                    47 => "47/voiceFourtyseven2x.wav",
                    48 => "48/voiceFourtyeight2x.wav",
                    49 => "49/voiceFourtynine2x.wav",
                    50 => "50/voiceFifty2x.wav",
                    51 => "51/voiceFiftyone2x.wav",
                    52 => "52/voiceFiftytwo2x.wav",
                    53 => "53/voiceFiftythree2x.wav",
                    54 => "54/voiceFiftyfour2x.wav",
                    55 => "55/voiceFiftyfive2x.wav",
                    56 => "56/voiceFiftysix2x.wav",
                    57 => "57/voiceFiftyseven2x.wav",
                    58 => "58/voiceFiftyeight2x.wav",
                    59 => "59/voiceFiftynine2x.wav",
                    60 => "60/voiceSixty2x.wav",
                    61 => "61/voiceSixtyone2x.wav",
                    62 => "62/voiceSixtytwo2x.wav",
                    63 => "63/voiceSixtythree2x.wav",
                    64 => "64/voiceSixtyfour2x.wav",
                    65 => "65/voiceSixtyfive2x.wav",
                    66 => "66/voiceSixtysix2x.wav",
                    67 => "67/voiceSixtyseven2x.wav",
                    68 => "68/voiceSixtyeight2x.wav",
                    69 => "69/voiceSixtynine2x.wav",
                    70 => "70/voiceSeventy2x.wav",
                    71 => "71/voiceSeventyone2x.wav",
                    72 => "72/voiceSeventytwo2x.wav",
                    73 => "73/voiceSeventythree2x.wav",
                    74 => "74/voiceSeventyfour2x.wav",
                    75 => "75/voiceSeventyfive2x.wav",
                    76 => "76/voiceSeventysix2x.wav",
                    77 => "77/voiceSeventyseven2x.wav",
                    78 => "78/voiceSeventyeight2x.wav",
                    79 => "79/voiceSeventynine2x.wav",
                    80 => "80/voiceEighty2x.wav",
                    81 => "81/voiceEightyone2x.wav",
                    82 => "82/voiceEightytwo2x.wav",
                    83 => "83/voiceEightythree2x.wav",
                    84 => "84/voiceEightyfour2x.wav",
                    85 => "85/voiceEightyfive2x.wav",
                    86 => "86/voiceEightysix2x.wav",
                    87 => "87/voiceEightyseven2x.wav",
                    88 => "88/voiceEightyeight2x.wav",
                    89 => "89/voiceEightynine2x.wav",
                    90 => "90/voiceNinety2x.wav",
                    _ => "errorInCode.wav",
                };
        }
    }
}
