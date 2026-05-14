using System.Collections.Generic;

namespace YorubaCatholicHymn.Models
{
    public static class HymnData
    {
        public static List<Hymn> Hymns = new()
    {
        new Hymn
        {
            Number = "1",
            Title = "E MAA WO'LE",
            Category = "ORIN AKOWOLE",
            Author = "Alufaa Т. М. Ilesanmi",
            Chorus = new List<string>
            {
            },
           Verses = new List<Verse>
{
    new Verse
    {
        Number = "1",
        Lines = new List<string>
        {
            "E maa wo'lẹ, e maa rora o     )",
            "Ojisẹ Olodumare ti a ya si mimo )2ce",
            "'Bukun fun wa, f'oju rere wo wa",
            "Ojiṣe Ọlọrun, jiṣe rere fun wa",
            "K'ibukun Ọlọrun, ko ba wa gbe!",
            "E maa wo 'lẹ, e maa rora            )",
            "Ojiṣe Olodumare ti a ya si mimo  )2ce",
        }
    },
    new Verse
    {
        Number = "2",
        Lines = new List<string>
        {
            "Ipo ti a gbe o si o, o l'ewu",
            "Eru ti a gbe fun o ru, o wuwo",
            "Sugbon ajaga Olodumare ni, o fuye",
            "Bi ẹ ba ti le m'Ọlọrun l'oba, o ti buse (2ce)",
            "E maa wo 'lẹ, e maa rora           )",
            "Ojiṣe Olodumare ti a ya si mimo )2ce",
        }
    },
    new Verse
    {
        Number = "3",
        Lines = new List<string>
        {
            "L'abẹ aaboo Jesu Kristi l'a kepe Baba (2ce)",
            "K'O f'okan re se 'le.  )",
            "K'O fi se 'bugbe ayo )2ce",
            "K'O le se Baba pe fun wa",
            "E maa wo 'le, e maa rora.           )",
            "Ojiṣe Olodumare ti a ya si mimo  )2ce",
        }
    },
}
        },
        new Hymn
        {
            Number = "2",
            Title = "IWENUMO (1) (Asperges)",
            Category = "ORIN AKOWOLE",
            Author = "P. A. Fragoso",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
    {
        new Verse
        {
            Number = "Alufaa:",
            Lines = new List<string>
            {
                "Wẹ mi mọ Ọlọrun Baba",
            }
        },
        new Verse
        {
            Number = "Ijo:",
            Lines = new List<string>
            {
                "F'ewe ak'eeri wẹ mi o",
                "N ba le funfun b'ẹgbon owu",
                "Ki n le yẹ l'iwaju Rẹ (3)",
                "Nba le funfun bi ẹgbon owu,",
                "Ki n le yẹ l'iwaju Rẹ.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Wẹ mì mọ Oluwa Ọmọ",
                "Fẹbo mimo Rẹ mẹ mi o",
                "Pelu awọn ayanfẹ Rẹ,",
                "Mu mi jere ọrun rere. (3)",
                "Pelu awon Ayanfẹ Rẹ",
                "Mu mi jere ọrun rere.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Wẹ mi mọ Ẹmi Mimo",
                "Oloore-ofẹ ailopin",
                "Dari ibajẹ mi ji mi",
                "Ki nle ye fun 'le Re (3)",
                "Dari ibajẹ mi ji mi",
                "Ki nle yẹ fun 'le Re.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ogo ni fun Baba ati fun Ọmọ (2)",
                "Ati fun Ẹmi Mimọ o",
                "B'o ti wa l'atetekose,",
                "Bẹẹni yoo si maa ri nisisiyi",
                "At'aiye ti ko ni'pẹkun",
                "Aṣẹ, Amin o, Ase.",
            }
        },
    }

        },
        new Hymn
        {
            Number = "3",
            Title = "IWENUMO (2) OMI AJINDE",
            Category = "ORIN AKOWOLE",
            Author = "P. A. Fragoso",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Alufaa:",
                    Lines = new List<string>
                    {
                        "Fi aanu Re han wa, Oluwa, Aleluya",
                        "Fi aanu Re han wa, Oluwa, Aleluya",
                        "Oluwa gbo adura mi,",
                        "Ki Oluwa wa pelu yin,",
                    }
                },
                new Verse
                {
                    Number = "Ijo:",
                    Lines = new List<string>
                    {
                        "Ki o si fun wa ni Igbala Rẹ;",
                        "Ki o si fun wa ni Igbala Rẹ;",
                        "Ki O si jẹ ki igbe mi wa s'odo Re,",
                        "Ki o si wa pelu re.",
                    }
                },
                new Verse
{
    Number = "1",
    Lines = new List<string>
    {
        "Mo ri omi t'o nṣan jade",
        "L'at' apa otun Ile Ọlọrun",
        "Ewo ob'o ti tu ni l'ara to o",
        "Aleluya.",
    }
},
new Verse
{
    Number = "2",
    Lines = new List<string>
    {
        "Gbogbo awọn ẹni ti a f'omi yi wọn",
        "Ni yio si ri igbala,",
        "Igbala ti duro de wọn o;",
        "Wọn o ko'rin iyin si Ọlọrun",
        "Aleluya, Aleluya.",
    }
},
new Verse
{
    Number = "3",
    Lines = new List<string>
    {
        "E maa yin Oluwa      Aleluya",
        "Nitori ti O ṣeun jojo",
        "Eyin orilẹ ede aiye;",
        "Eyin eniyan Ọlọrun;",
        "Aanu Rẹ duro lae;",
        "Otito Rẹ duro ti wa.",
    }
},
new Verse
{
    Number = "4",
    Lines = new List<string>
    {
        "Ogo ni fun Baba ati fun Ọmọ, (2ce)",
        "Ati fun Ẹmi Mimo o,",
        "B' O ti wa l'atetekose,",
        "Bẹẹ ni yio si maa ri",
        "Nisisiyi, at'aiye ti ko ni 'pẹkun,",
        "Amin, Aleluya! Aleluya! Aleluya!",
    }
},
            }
        },
        new Hymn
        {
            Number = "4",
            Title = "ONIGBAGBO E SIN BABA",
            Category = "ORIN AKOWOLE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
{
    Number = "1",
    Lines = new List<string>
    {
        "Onigbagbo ẹ sin Baba o, nile Ọlọrun o (2ce)",
        "Sis'Olugbala lo yẹ wa si, ẹ wa sin Baba o",
        "E, e, e; ẹ sin Baba o (2ce)",
        "Onigbagbo sin Baba o, nile Ọlọrun o.",
    }
},
new Verse
{
    Number = "2",
    Lines = new List<string>
    {
        "Onigbagbọ ẹ yin Baba o, nile Ọlọrun o (2ce)",
        "E kọrin iyin ati t'ọpẹ, ẹ fi yin Baba o",
        "E, e, e; e yin Baba o (2ce)",
        "Onigbagbọ ẹ yin Baba o, nile Ọlọrun o.",
    }
},
new Verse
{
    Number = "3",
    Lines = new List<string>
    {
        "Onigbagbọ ẹ se rere o, nile Ọlọrun o (2ce)",
        "Olodumare Ọba ikẹ, Ọba rere ni o",
        "E, e, e; e se rere o (2ce)",
        "Onigbagbọ ẹ se rere o, nile Ọlọrun o.",
    }
},
new Verse
{
    Number = "4",
    Lines = new List<string>
    {
        "Onigbagbọ ẹ fifẹ lo-po, nile Ọlọrun o (2ce)",
        "Jesu Enit'o ni wa, Ọba ifẹ ni o",
        "E, e, e; ẹ fifẹ lo-pọ (2ce)",
        "Onigbagbọ e fifẹ lopo, nile Ọlọrun o.",
    }
},
new Verse
{
    Number = "5",
    Lines = new List<string>
    {
        "Onigbagbọ ẹ gbadura pọ, nile Ọlọrun o (3ce)",
        "Awimayehun a gbo ti yin, biẹ ba ke si o",
        "E, e, e; ẹ gbadura pọ (2ce)",
        "Onigbagbọ e gbadura pọ nile Ọlọrun o.",
    }
},
            }
        },
        new Hymn
        {
            Number = "5",
            Title = "Ẹ KORIN AYỌ",
            Category = "ORIN AKOWOLE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
{
    Number = "1",
    Lines = new List<string>
    {
        "Inu mi dun nigbati mo gbọ pe",
        "E je k'a lo s'ile Oluwa.",
    }
},
new Verse
{
    Number = "Egbe:",
    Lines = new List<string>
    {
        "Ẹ kọ rin ayọ, (2ce)",
        "Ẹ kọ 'rin ayọ si Oluwa.",
    }
},
new Verse
{
    Number = "2",
    Lines = new List<string>
    {
        "K'a fi t'ayot'ayo ko rin si Oluwa Oba Ogo,",
        "Ẹ ko'rin ayo.",
    }
},
new Verse
{
    Number = "3",
    Lines = new List<string>
    {
        "K'a fi opẹ fun Un, ka fi iyin fun Un",
        "K'a si yin In l'ogo nipa kikoʻrin.",
    }
},
new Verse
{
    Number = "4",
    Lines = new List<string>
    {
        "Ẹ gbe okan nyin s'oke lati yin Oluwa,",
        "Bi ti awọn Angeli t'o nf'orin yin In.",
    }
},
new Verse
{
    Number = "5",
    Lines = new List<string>
    {
        "Ka fi imoore wa han si Oluwa,",
        "Eni ti iyin ati ola ye fun.",
    }
},
            }
        },
        new Hymn
{
    Number = "6",
    Title = "PSALMU 118",
    Category = "ORIN AKOWOLE",
    Author = "Ẹgbẹ Akọrin Oṣogbo",
    Chorus = new List<string>
    {
        "Eyi ni ojo ti Oluwa da, ẹ jẹ ki a maa yo",
        "Ki inu wa si maa dun ninu rẹ.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹ fi ope fun Oluwa, nitoriti o ṣeun,",
                "nitoriti aanu re duro laelae.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Jẹ ki Israeli ki o wi nisisiyi pe,",
                "aanu rẹ duro laelae.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ọwo otun Oluwa li agbega:",
                "Ọwo otun Oluwa nṣe agbara.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ẹmi ki yio ku, bikoṣe yiye,",
                "ki Ẹmi ki o si maa rohin iṣẹ Oluwa.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Ṣi ilẹkun enu-Ọna ododo silẹ fun mi:",
                "Ẹmi o ba ibẹ wole, Ẹmi o maa yin Oluwa.",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Eyi li ẹnu-ọna Oluwa,",
                "ti awọn olododo yio ba wole.",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Ẹmi o yin Ọ; nitori ti iwo gbohun mi, iwo si di igbala mi.",
            }
        },
        new Verse
        {
            Number = "8",
            Lines = new List<string>
            {
                "Okuta ti awọn Ọmọle ko silẹ li o di pataki igun ile.",
            }
        },
        new Verse
        {
            Number = "9",
            Lines = new List<string>
            {
                "Lati odo Oluwa li eyi: o ṣe iyanu li oju wa",
            }
        },
        new Verse
        {
            Number = "10",
            Lines = new List<string>
            {
                "E fi ope fun Oluwa; nitori ti o ṣeun:",
                "nitori-ti aanu rẹ duro laelae.",
            }
        },
        new Verse
        {
            Number = "11",
            Lines = new List<string>
            {
                "Ogo ni fun Baba ati Ọmọ ati fun Ẹmi Mimọ:",
            }
        },
        new Verse
        {
            Number = "12",
            Lines = new List<string>
            {
                "Bi o ti wa latetekose, mbẹ nisisiyi, bẹẹni titi aiye.",
            }
        },
    }
},
new Hymn
{
    Number = "7",
    Title = "ẸMI ỌRUN JỌWỌ WA",
    Category = "ORIN AKOWOLE",
    Author = "J. O. Ajibola",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹmi ọrun jọwọ wa",
                "Olugbala Ọba jọwọ o,",
                "Jẹki ẹmi Rẹ, Baba iye",
                "Ko wa ba sori gbogbo wa.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Iwa eeri wa gbogbo   )",
                "Jọwọ forifji wa ọ        )2ce",
                "Jọwọ foriji wa o, Oluwa",
                "Jọwọ foriji wa o",
                "Iwa eeri wa gbogbo",
                "Jọwọ foriji wa o.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹmi ọrun jọwọ wa",
                "Olugbala Ọba jọwọ o",
                "Jẹ ki 'bukun Rẹ Baba iye",
                "Wa, ko rọ s'ori gbogbo wa.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ẹmi ọrun jọwọ wa",
                "Olugbala Ọba jọwọ o",
                "Jẹ ki 'tunu Rẹ, Baba iye",
                "Wa j'ẹbun kari gbogbo wa.",
            }
        },
    }
},
new Hymn
{
    Number = "8",
    Title = "WA BA WA GBE",
    Category = "ORIN AKOWOLE",
    Author = "Alufaa T. M. Ilesanmi",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Wa ba wa gbe (2ce).",
                "Ẹmi mimọ Olutunu o,",
                "Wa ba wa gbe.",
                "Ẹmi mimọ Olutunu",
                "Tan 'na ifẹ o",
                "Ran imọlẹ rẹ sinu wa",
                "Ẹmi Ọlọrun tòótọ,",
                "Ran imọlẹ Rẹ sinu wa",
                "Ẹmi aiyeraiye.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "M'aye ye wa (2ce)",
                "Ẹmi mimọ Olutunu O",
                "M'aye yẹ wa",
                "Ẹmi mimọ Olutunu",
                "A wolẹ fun O.",
                "Wa tan 'mọlẹ Rẹ nijọ gbogbo",
                "Ẹmi Ọlọrun tootọ,",
                "Wa tan 'molẹ Rẹ nijọ gbogbo",
                "Ẹmi aiyeraiye.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Wa da wa si (2ce)",
                "Ẹmi mimo a bẹ Ọ o",
                "Wa da wa si.",
                "Ṣaanu fun wa, fọna han wa",
                "A ke pe Ọ o",
                "Ma-yanfẹ Rẹ duro ṣinṣin",
                "Ẹmi aiyaraiye.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ọba ogo (2ce)",
                "Awa n kigbe pe Ọ o",
                "Ọba ogo,",
                "Ẹmi mimo la bẹbẹ fun",
                "A fe 'bukun o",
                "Ki 'bukun Rẹ ko je ti wa",
                "Ẹmi Ọlọrun ran wa lọwọ",
                "Ki 'bukun Rẹ ko je ti wa",
                "Ẹmi aiyeraiye.",
            }
        },
    }
},
new Hymn
{
    Number = "9",
    Title = "JESU OLUWA",
    Category = "ORIN AKOWOLE",
    Author = "Michael Adu",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "Jesu Oluwa, Awa ọmọ rẹ de l'ọjọ oni o, a de o(2ce)",
                "Maria Mimọ Awa ọmọ rẹ de l'ọjọ oni o, a de o (2ce)",
                "Awa ọmọ Ọlọrun de lati wa yin Ọlọrun l'ogo l'ọjọ oni,",
                "Baba mimọ ṣaanu wa, ma jẹ k'a r'ibi aiye.",
                "Oloore ọfẹ, Oloore ọfẹ, f'oju ire wo wa Maria; awa ọmọ rẹ (2ce)",
                "K'a to kuro n'ile o' lati juba Ọlọrun k'a to bẹrẹ isin wa",
                "Lati juba Maria, Iya mimọ jọwọ wa gb'adura ọmọ rẹ",
                "Maria Iya mimọ t'ọmọde t'agba, t'agba Ijọ l'o nkigbe pe ọ.",
                "Ma ṣalai gb'adura wa o, Iya mimọ.",
                "Bẹ Jesu Ọmọ rẹ fun wa k'o wa gba wa la.",
                "Iwọnyi l'a ntọrọ lọwọ rẹ Iya, Maria.",
                "Awa ọmọ rẹ de o, a de o, a de o; a de o; a de o; a de.",
            }
        },
    }
},
       new Hymn
{
    Number = "10",
    Title = "ISOKALE ẸMI MIMO",
    Category = "ORIN AKOWOLE",
    Author = "E. A. Alao",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Wa o, Ẹmi Mimọ O, Mẹtalọkan; jọwọ wa sọkalẹ",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Jọwọ wa, Mẹtalọkan, jọwọ wa; Mẹtalọkan",
                "Olutunu Ọba Iye, Jọwọ wa o",
                "Olugbala s'amona wa.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Mẹtalọkan jọwọ wa s'inu ọkan wa",
                "Ki o si da ina ifẹ Rẹ s'inu wa.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Olutunu jọwọ wa, Iwọ ni imọlẹ wa",
                "Olugbala Ọba Iye, dakun jọwọ wa.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ẹmi ọrun jọwọ wa, tan imọlẹ Rẹ s'inu wa",
                "Olupese Ọba Iye, tan imọlẹ Rẹ yi wa ka.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Ran Ẹmi Rẹ jade wa, Olutunu Ọba iye",
                "Mẹtalọkan jọwọ wa o, s'amọna wa.",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Wa gba ẹmi wa la, ki O si ba s'ori wa",
                "Jẹ ki ayọ kari wa. Mẹtalọkan.",
            }
        },
    }
},
new Hymn
{
    Number = "11",
    Title = "K'O WA BA WA GBE",
    Category = "ORIN AKOWOLE",
    Author = "C. S. O. Balufọ",
    Chorus = new List<string>
    {
        "K'o wa ba wa gbe (2ce)",
        "Ẹbùn meje l'a ntọrọ",
        "K'o wa ba wa gbe.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹbùn ọgbọn ẹbun agbara",
                "K'o wa ba wa gbe.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹbùn imọran, ẹbun agbara",
                "K'o wa ba wa gbe.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ẹbùn ìmọ, ẹbun ifọkansin",
                "K'o wa ba wa gbe.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ẹbùn ìbẹrù, iberu Oluwa",
                "K'o wa ba wa gbe.",
            }
        },
    }
},
new Hymn
{
    Number = "12",
    Title = "RAN IMỌLẸ RẸ JADE",
    Category = "ORIN AKOWOLE",
    Author = "Ẹgbẹ Akọrin Oṣogbo",
    Chorus = new List<string>
    {
        "Ran imọlẹ Rẹ jade",
        "Ran otitọ Rẹ jade",
        "Awọn ni yio-ṣamona mi lọ s'ori oke Rẹ.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Oluwa ni imọlẹ mi",
                "Oluwa ni agbara mi",
                "Ẹru ẹnikan ko le ba mi.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Oluwa ni alaabo mi",
                "Oluwa ni O ntọjú mi",
                "Oluwa gb'ogun t'awọn ota.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ogo ni fun Baba mi",
                "Ogo ni fun Ọmọ Rẹ o",
                "Ogo ni fun Ẹmi mimọ.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Bi O ti wa latetekọsẹ",
                "Bẹẹ ni nisisiyi",
                "Bẹẹ ni titi aiye.",
            }
        },
    }
},
new Hymn
{
    Number = "13",
    Title = "WA ẸMI MIMỌ",
    Category = "ORIN AKOWOLE",
    Author = "H. A. Ọrẹdipẹ",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Wa o, wa ba wa sin      )",
                "Ẹmi Olutunu wa o jare  )2ce",
                "K'o wa lati 'bugbe loke           )",
                "K'o wa fún wa l'agbara Rẹ.   )2ce",
                "Wa o, wa ba wa sin,",
                "Ẹmi Olutunu wa o jare.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Wa o, wa ba wa sin",
                "Ẹmi Baba jọwọ wa o jare (2ce)",
                "Jọwọ dakun gba wa l'aye",
                "K'a le ba wọn yin Ọ l'ogo (2ce)",
                "Wa o, wa ba wa sin,",
                "Ẹmi Baba jọwọ wa o jare.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Wa o, Ẹmi iye,",
                "Jọwọ ma ṣai kun 'nu wa o jare (2ce)",
                "Ẹmi okun at'alaafia,",
                "Ko ma ba wa rin lojo gbogbo (2ce)",
                "Wa o, Ẹmi iye,",
                "jọwọ ma ṣai kun 'nu wa o jare.",
            }
        },
    }
},
        new Hymn
{
    Number = "14",
    Title = "WA BA MI GBE",
    Category = "ORIN AKOWOLE",
    Author = "Unknown",
    Chorus = new List<string>
    {
        "Ẹmi Mimọ Olutunu",
        "Wa ba mi gbe",
        "Ẹmi Mimọ Olutunu o",
        "Wa ba mi gbe.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Wa ba mi gbe ninu ile",
                "Wa ba mi ghe lona gbogbo",
                "Irin ajo ni mo wa o",
                "Wa ba mi gbe.",
            }
        },
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Wa ba mi gbe ninu iṣe",
                "Wa ba mi gbe ni isimi",
                "Irin ajo ni mo wa o",
                "Wa ba mi gbe.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Wa ba mi gbe ninu ipọnju",
                "Wa ba mi gbe ninu ayọ",
                "Ìrẹlẹ ni mo fi bẹ Ọ",
                "Wa ba mi gbe.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Imọlẹ aiyeraiye",
                "Wa ba mi gbe",
                "Okunkun ni mo wa o",
                "Wa ba mi gbe.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Wa ba mi gbe nijọ gbogbo",
                "Wa ba mi gbe lẹhin ọla",
                "Titi aiye ainipẹkun",
                "Wa ba mi gbe.",
            }
        },
    }
},
new Hymn
{
    Number = "15",
    Title = "ỌDUN MIMỌ KORPUS KRISTI (ORIN IWỌLE Ps. 80)",
    Category = "ORIN AKOWOLE",
    Author = "Jerome Ojo",
    Chorus = new List<string>
    {
        "Oluranlọwọ l'Ọlọrun wa",
        "Ẹ ho iho ayọ s'Oluwa",
        "Ẹ ho iho ayọ s'Oluwa",
        "Ẹ kọrin ogo s'Olugbala.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹ f'ijo, f'ayọ yin Oluwa",
                "Olubukun l'ọba ogo",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ninu ipọnju mi Oluwa",
                "Iwọ nikan l'olutunu mi.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ko s'ọba meji af'Oluwa",
                "Ọ-bangiji onibu ọrẹ",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Iwo l'Oluwa Ọlọrun mi",
                "Oludande-Oba rere.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "O f'onjẹ iye fun wa jẹ",
                "O f'ẹjẹ mimọ ra wa pada.",
            }
        },
    }
},
new Hymn
{
    Number = "16",
    Title = "JỌWỌ JARE WA BA WA GBE",
    Category = "ORIN AKOWOLE",
    Author = "Unknown",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Baba Olodumare Ọlọrun aiyeraiye",
                "Awa ọmọ Rẹ l'a pejọ pọ l'ẹsẹ Rẹ.",
                "Ọlọrun Baba, Ọlọrun Ọmọ, Ọlọrun Ẹmi Mimọ",
                "Awa ọmọ rẹ la pejọ pọ l'ẹsẹ Rẹ.",
                "Baba Olugbala Ọba Mimọ, Ọbangiji Olufiji ẹsẹ",
                "Awa Ọmọ rẹ l'a pejọ pọ l'ẹsẹ Rẹ",
                "Da wa si Baba Olodumare f'ibukun rẹ sori wa",
                "K'a si le j'ẹni atẹwogba l'ọdọ re titi lae",
                "Awa Ọmọ rẹ la pejọ pọ l'ẹsẹ Re.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Jọwọ jare wa ba wa gbe, Baba Mimọ",
                "Jọwọ jare wa ba wa gbe, Baba Mimọ",
                "Jọwọ jare wa ba wa gbe, Baba Mimọ",
                "Jọwọ jare wa ba wa gbe o",
            }
        },
        new Verse
        {
            Number = "Gbogbo:",
            Lines = new List<string>
            {
                "Jọwọ jare wa ba wa gbe, Baba Mimọ",
                "Jọwọ jare wa ba wa gbe o, Olufiji ẹsẹ",
                "Jọwọ jare wa ba wa gbe. Amin.",
            }
        },
    }
},
new Hymn
{
    Number = "17",
    Title = "IBA FUN ỌLỌRUN EDUMARE",
    Category = "ORIN AKOWOLE",
    Author = "H. A. Ọrẹdipẹ",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "Iba f'Ọlọrun Edumare (2ce)",
                "Ọba t'o l'aiye Iwọ ni 'yin yẹ",
                "Iba f'Ọlọrun Edumare,",
                "Iba fun Baba, Iba fun ọmọ",
                "Iba f'ọlọrun Edumare,",
                "Iba fun Ẹmi Olutunu",
                "Iba f'ọlọrun Edumare,",
                "Awa n juba k'iba wa sẹ",
                "Iba f'ọlọrun Edumare,",
                "Ariwarẹhin, Alewileṣe",
                "Iba f'ọlọrun Edumare,",
                "Jehofa Ọba Iwọ ni Mimọ",
                "Iba f'ọlọrun Edumare",
                "Ọbangiji Ọba Ogo",
                "Iba f'ọlọrun Edumare",
                "Dari ẹsẹ wa jiwa l'aiye",
                "Iba f'ọlọrun Edumare,",
                "Iba f'ọlọrun Edumare,",
                "Ọba to l'aiye Iwọ ni 'yin yẹ",
                "Iba f'ọlọrun Edumare.",
            }
        },
    }
},

        new Hymn
{
    Number = "18",
    Title = "BABA WA, A DE O",
    Category = "ORIN AKOWOLE",
    Author = "G. O. Kaṣimawo",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Baba wa, a de o, (2ce)",
                "A de, awa yin Ọ o,",
                "A wa f'ifẹ Rẹ han,",
                "Baba wa, a de o.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Baba wa mi si wa, (2ce)",
                "A de wa yin Ọ o,",
                "A wa f'ifẹ Rẹ han,",
                "Baba wa mi siwa.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Baba fetisi wa (2ce)",
                "A kigbe si Baba o,",
                "K'o ma ta wa danu,",
                "Baba wa feti si wa.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Baba wa dakun (2ce)",
                "Baba foriji wa o,",
                "Wa fun wa ni 'joko,",
                "Baba wa dakun.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Baba wa oloore (2ce)",
                "Oluwa ye jọwọ o,",
                "Fun wa ni 'fokansin",
                "Baba wa oloore.",
            }
        },
    }
},
new Hymn
{
    Number = "19",
    Title = "BABA, AWA ỌMỌ RẸ DE",
    Category = "ORIN AKOWOLE",
    Author = "Oloye S. O. Ajala",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Baba awa Ọmọ Re de o Baba jọwọ ye (2ce)",
                "A ke si Ọ dakun ṣaanu fun wa",
                "A bẹbẹ, a bẹbẹ wa mi si wa",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Baba ran wa lowo o(2ce)",
                "Baba fun wa l'ayọ, fun wa l'agbara",
                "A bẹbẹ wa mi si wa",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Baba awa fẹ ri Ọ (2ce)",
                "Baba fun wa niye, fun wa lọgbọn o",
                "A bẹbẹ, a bẹbẹ wa mi si wa",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Baba jọwọ gbọ tiwa(2ce)",
                "Baba tẹwo gb'ẹbo wa ka le jẹ tirẹ",
                "A bẹbẹ, a bẹbẹ wa mi si wa",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Baba jọwọ bukun fun wa Baba jọwọ ye (2ce)",
                "Baba, jẹki a raye de odo rẹ",
                "A bẹbẹ, a bẹbẹ wa mi ai wa",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Baba awa ke si Ọ (2ce)",
                "Baba maṣe huwa si wa bi ẹsẹ wa",
                "A bẹbẹ, a bẹbẹ wa mi si wa",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Baba awa mbẹ o (2ce)",
                "Ẹbọ ọpẹ at'iyin l'awa ru si ọ",
                "A bẹbẹ a bẹbẹ wa mi si wa",
            }
        },
    }
},
new Hymn
{
    Number = "20",
    Title = "GBỌKANLE JESU",
    Category = "ORIN AKOWOLE",
    Author = "Joseph Ọkẹ",
    Chorus = new List<string>
    {
        "Gbọkanle Jesu, Ọrẹ mi",
        "Gbokanle Jesu onigbagbọ",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Oun l'ọba t'o fi wa saiye",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Lati ra wa pada f'Ọlọrun",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "O w'aiye o fara re gbọgbẹ",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "O f'ara Rẹ rúbọ fun igbala wa",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Onigbagbọ ẹ ronu yin",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Ki ẹ gbọ t'Oluwa ọrun",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Gbọkanle Jesu Ọrẹ mi o",
                "Gbokanle Jesu onigbagbọ.",
            }
        },
    }
},
new Hymn
{
    Number = "20",
    Title = "GBỌKANLE JESU",
    Category = "ORIN AKOWOLE",
    Author = "Joseph Ọkẹ",
    Chorus = new List<string>
    {
        "Gbọkanle Jesu, Ọrẹ mi",
        "Gbokanle Jesu onigbagbọ",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Oun l'ọba t'o fi wa saiye",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Lati ra wa pada f'Ọlọrun",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "O w'aiye o fara re gbọgbẹ",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "O f'ara Rẹ rúbọ fun igbala wa",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Onigbagbọ ẹ ronu yin",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Ki ẹ gbọ t'Oluwa ọrun",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Gbọkanle Jesu Ọrẹ mi o",
                "Gbokanle Jesu onigbagbọ.",
            }
        },
    }
},
new Hymn
{
    Number = "21",
    Title = "JESU NPE WA",
    Category = "ORIN AKOWOLE",
    Author = "Joseph Ọkẹ",
    Chorus = new List<string>
    {
        "Jesu npe wa o alaaye",
        "Alaaye ẹ maa bọ o",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "O np'ọmọde o, O np'alagba",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹ sare wa ki ẹ yin Oluwa",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ẹ gbohunro, ẹ yin Ọlọrun",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ẹ ronu yin wo, ẹ p'iwada",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Ma rọnu, pẹhinda, woju Olu",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Mu ọkan rẹ f'Oluwa Jesu",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Afẹ aiye ko mu igbala wa",
            }
        },
        new Verse
        {
            Number = "8",
            Lines = new List<string>
            {
                "Igbala rẹ mbẹ lọwọ Jesu",
            }
        },
        new Verse
        {
            Number = "9",
            Lines = new List<string>
            {
                "Wa 'le Olu, maṣe ronu, Ọmọ Jesu",
            }
        },
        new Verse
        {
            Number = "10",
            Lines = new List<string>
            {
                "Mura si'wa re o, bẹrù ẹsẹ",
            }
        },
    }
},
        new Hymn
{
    Number = "22",
    Title = "RANTI O",
    Category = "ORIN AKOWOLE",
    Author = "Ẹgbẹ Akọrin Oṣogbo",
    Chorus = new List<string>
    {
        "Ranti o, ranti o",
        "Ranti pe Ọba alailẹsẹ",
        "O ku fun wa.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Iwọ òṣìkà",
                "Iwọ Abanijẹ",
                "Ranti pe Ọba alailẹsẹ",
                "O ku fun ọ",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Iwọ ọdàlẹ",
                "Iwọ aṣeke",
                "Ranti pe Ọba alailẹsẹ",
                "O ku fun o",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Iwo eniyan",
                "Ọmọ Ọlọrun",
                "Ranti pe Ọba alailẹsẹ",
                "O ku fun ọ.",
            }
        },
    }
},
new Hymn
{
    Number = "23",
    Title = "A TI MURA ΤΑΝ",
    Category = "ORIN AKOWOLE",
    Author = "Oloye S. O. Ajala ati Mrs. Babalola",
    Chorus = new List<string>
    {
        "A ti mura tan ṣe k'a jọlọ (2ce)",
        "K'awa jumọ la yin Baba.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Baba alaanu olinu 're, Eni ti ki taro ẹsẹ",
                "A fi k'o ṣaanu",
                "Awọn ọmọ Rẹ l'ọna ara.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ṣebi ẹsẹ Adamu re sọ wa d'ọta Baba",
                "K'o yi le wa sonu s'ẹhin gbogbo",
                "S'inu aiye oṣi.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ọrọ agba iyi pe bi a ba f'ọtun bọmọ wi",
                "A tun f'osi fa m'ọra pada",
                "Ti wa pẹ, ìyẹn ṣe'un ara.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Baba ti binu li 'wọn",
                "O tun gb'ọrọ wa yẹwo",
                "O ṣaanu tan, O tun ṣe 'leri Olugbala,",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Jesu re Eni to Baba bẹ",
                "Pe k'o m'oju kuro ninu ẹsẹ wa",
                "K'a tun pada d'ọmọ Edumare.",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Igi agbelebu nre Jesu fi ṣ'abukala",
                "Tọ Baba lọ l'oke",
                "K'o to ba ni bẹbẹ ẹsẹ.",
            }
        },
        new Verse
        {
            Number = "7",
            Lines = new List<string>
            {
                "Ẹjẹ Jesu re ta 'lẹ bi epo",
                "K'o to le gb'ẹnu l'ẹbẹ wa lọdọ Baba",
                "Iyi ki binu ọmọ Rẹ lai gbebe",
            }
        },
        new Verse
        {
            Number = "8",
            Lines = new List<string>
            {
                "Iṣẹ yi Jesu ṣe l'ori agbelebu",
                "Ng roo gbe le wa lọwọ pe k'a",
                "Ma d'igba fi bẹ Baba, eyi ma dẹ pọ.",
            }
        },
        new Verse
        {
            Number = "9",
            Lines = new List<string>
            {
                "A pejọ l'eni k'a tun wa bẹ Baba",
                "Bi Jesu ti pe k'a maa ṣe li 'gbi",
                "O ng'ori agbelebu lọ lẹrikan.",
            }
        },
        new Verse
        {
            Number = "10",
            Lines = new List<string>
            {
                "Baba Olinure, a tunde",
                "Ẹjẹ Ọmọ Rẹ Jesu nre a fi bẹ Ọ, forijin wa",
                "K'o fun wa l'alaafia awa ma bẹbẹ ọ.",
            }
        },
    }
},
new Hymn
{
    Number = "24",
    Title = "RAN IMỌLẸ RẸ JADE",
    Category = "ORIN AKOWOLE",
    Author = "Ẹgbẹ Akọrin Bodija",
    Chorus = new List<string>
    {
        "Ran imolẹ Re jade",
        "Ran otitọ Rẹ Jade,",
        "Awọn ni yio ṣ'amọna mi",
        "Lọ s'ori oke Rẹ.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ojiṣe Ọba Mimọ",
                "Mu wa bọ s'ile ogo,",
                "Ile ayọ n'ile Re",
                "Ọba ogo.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ojiṣẹ Oba Mimọ",
                "Mu wa bo s'ile ogo,",
                "K'a jọsin ni'le Rẹ",
                "Ọba ogo.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Deri Baba Mimo.",
                "Ba wa rin l'ọjọ oni,",
                "Oluwa pe wa sọdọ Rẹ",
                "Ọba ogo.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Awa de Baba Mimo,",
                "Lati sin Ọ l'ojo oni",
                "Dakun gb'adura wa,",
                "Ọba ogo.",
            }
        },
    }
},
        new Hymn
        {
            Number = "25",
            Title = "OLUWA NI OLUṢO AGUTAN MI",
            Category = "ORIN AKOWOLE",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Oluwa ni Olùṣọ Agutan mi",
                "Ẹmi ki yio ṣalaini o",
                "Oluwa ni Alaabo mi, Oluwa ni.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O mu mi de'po ti mo wa lọjọ oni",
                        "O gba mi lọwọ ewu",
                        "O ṣe amọna mi fun mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa l'oke l'o nṣamona onígbàgbọ",
                        "B'ọjọ oni yio s'ọjọ re",
                        "O di ọwọ rẹ Oloore.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Niṣẹ oojọ mi, Oluwa ni Oludari",
                        "Ni ọna ti mo nrin o",
                        "Oun ni Atọkun mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "26",
            Title = "OJISE OBA MIMO",
            Category = "ORIN AKOWOLE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Ẹyin ojise Ọba Mimọ",
                "Ẹnyin angeli Ọlọrun Ọba",
                "Ẹ fiyin f'Ọlọrun l'oke ọrun",
                "Ẹni mimọ, Ẹ fiyin f'Ọlọrun aiyeraiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin ọrun Oluwa	E fiyin f'Ọlọrun Ọba",
                        "Omi to mbẹ labẹ ọrun",
                        "Eyin agbara ọrun",
                        "ọrun at'osupa",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Irawo oju ọrun:",
                        "Iṣan ati iho omi",
                        "Eyin Ẹmi ọrun",
                        "Ina ati oru",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ikuku ati manamana.",
                        "Eyin orile aiye gbogbo",
                        "Gegele ati petele",
                        "Odo at'omi okun",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Eranko igbo ati ile",
                        "Eyin Ọmọ eniyan",
                        "Eyin Ọmọ Israeli",
                        "Eyin alufaa Ọlọrun",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Otutu ati Ooru",
                        "Oginitin at'otutu",
                        "Idi omi yinyin",
                        "Imolẹ at'okunkun",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Eyin ẹda afaiyafa",
                        "Osan ati oru",
                        "Eyin ẹda inu omi",
                        "Eyin eiye oju ọrun",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Eyin iranse Ọlọrun",
                        "Eyin omi okun",
                        "Iwo pkan mimo julo",
                        "Anania, Asaria ati Misaẹli",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "27",
            Title = "AKOWOLE FUN BISOBU ATI AWON OLORI ALASE EKELESIA MIRAN ATI FUN ODUN PETERU MIMO",
            Category = "ORIN AKOWOLE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Peteru mimo",
                "Iwo ni apata igbala",
                "Lori okuta yii",
                "L'Ẹmi o kole Ijo eniyan mi si",
                "Gbogbo agbara ọrun Apadi",
                "Ki yio le bo ri re.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun dide",
                        "Fun Ijọ Rẹ ni isokan",
                        "Pa Papa mimo mọ",
                        "Ki o si f'ẹsẹ rẹ mulẹ",
                        "Ki o le maa pa-se",
                        "Fun gbogbo aiye",
                        "Ki gbogbo aiye Le maa se ifẹ Re.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun dide",
                        "Bori awọn ọta Re",
                        "So awọn ojiṣẹ Re",
                        "Ki o si fun wọn niforiti",
                        "Ki wọn le maa tan",
                        "Ifẹ Rẹ si gbogbo aiye",
                        "Ki gbogbo aiye Le maa se ifẹ Re.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọrun dide",
                        "Daboobo orilẹ ede wa",
                        "Fun awọn oba ni alaafia",
                        "Ogbọn ati oye",
                        "Ki wọn le maa mọ Ọ",
                        "Ni oba awọn oba",
                        "Ki gbogbo wa le wa Ni iṣokan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọlọrun dide",
                        "Daboobo orilẹ ede wa",
                        "Fun awon alakово wa.",
                        "Ni alaafia, ogbọn ati oye",
                        "Ki wọn le maa se iṣe wọn",
                        "Fun ogo Re",
                        "Ki gbogbo wa le wa Ni iṣokan.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ni agbara Baba",
                        "Ni agbara Ọmọ",
                        "Ni agbara Ẹmi Mimo",
                        "Ki gbogbo wa le wa ni isokan",
                        "Ki gbogbo wa le maa se ifẹ Re.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "28",
            Title = "ṢE WA L'OLODODO",
            Category = "ORIN AKOWOLE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Oba Mimo Oba iye (2ce)",
                "Ṣe wa l'olododo ni'le aiye o, Oba Ogo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ere si 'sẹ wa to'wa s'ona Re",
                        "Fun wa l'agbara n'ile aiye o, Oba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oba Mimo Oba Iye",
                        "Gba wa lowo ota ile aiye o, Oba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fi so Rẹ ẹo wa ka le jẹ ti Rẹ",
                        "Fun wa ni imo ni'le aiye o, Oba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun wa, Ṣa-mona wa",
                        "Wu wa de 'bi iye n'ile aiye o, Oba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbọ ti wa Oluwa, Ṣo ẹmi wa",
                        "Gba wa sinu agbo mimo Rẹ o, Oba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun wa, Gbo adura wa",
                        "Mu wa de 'bi ogo n'ile aiye o, Oba Ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "29",
            Title = "TẸWỌ GB'ẸBO WA",
            Category = "ORIN IFITORE",
            Author = "Ẹgbẹ Akọrin Ajase, Dahomi; Alufaa Michael Sanusi l'o tan kalẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Tẹwọ gb'ẹbo wa, Baba wa tẹwọ gb'ẹbo wa",
                        "Baba Olodumare Iwọ l'a wa rubọ si o",
                        "Tewọ gb'ẹbo wa. (2ce)",
                        "Laye, Baba wa te wọ gb'ẹbo wa",
                        "Laye, laye, Baba wa tẹwọ gb'ẹbo wa",
                        "Baba Olodumare Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba egbe wa Papa, oun l'awa rubọ fun o",
                        "Tẹwo gbebo wa.",
                        "Awọn arọpo Papa, awon l'awa rubọ fun o",
                        "Tewo gb'ẹbo wa.",
                        "Gbogbo Kristiani, awọn l'awa rubo fun o",
                        "Tẹwọ gb'ẹbo wa.",
                        "Laye, Baba wa tẹwọ gb'ẹbo wa",
                        "L'aye, l'aye, Baba wa tẹ'wọ gb'ẹbo wa",
                        "Baba Olodumare, Iwọ l'awa rubọ si O.",
                        "Tẹwọ gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awa pelu Maria, Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                        "Awa pelu Josefu, Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                        "Awa pelu Peteru, Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                        "Baba Olodumare, Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                        "L'aye, Baba wa tẹ'wọ gb'ẹbo wa",
                        "L'aye, laye, Baba wa tẹwọ gb'ẹbo wa;",
                        "Baba Olodumare, Iwọ l'awa rubọ si o",
                        "Tẹwọ gb'ẹbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "30",
            Title = "BABA OLODUMARE",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Baba Olodumare",
                "Arinu-rode olumo okan",
                "Wa gb'ore / gb'ebo wa oni o",
                "Oba ọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba a dupe, Oba ọrun",
                        "Eleti ofe, Oba ọrun",
                        "Apa nla t'o so aiye ro, Oba ọrun",
                        "Oro gbe 'kun eniyan fohun, Oba ọrun",
                        "Wa gb'ore/gbẹbo wa oni o, Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Omimi ti nmi 'le aiye, Oba ọrun",
                        "Ojiji awamaridi, Oba ọrun",
                        "Oba t'o r'ibi t'oju ẹda ko to, Oba ọrun",
                        "O b'ẹlẹsẹ wo bi ọmọ, Oba ọrun",
                        "Wa gb'ore/gbebo wa oni o, Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Alapa gbani-gbani, Oba ọrun",
                        "Abiyamo l'ojo ija, Oba ọrun",
                        "Oba ti ko gbagbe elese, Oba ọrun",
                        "Ọlọrun Ajalaiye, Oba ọrun",
                        "Wa gb'ore / gb'ẹbo wa oni o, Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oba Ajikẹ, Oba ọrun",
                        "Ọba Ajiyin, Oba ọrun",
                        "Onibu-ore, Oba ọrun",
                        "Wa gb'ẹbo Kristi oni o, Oba ọrun",
                        "Wa gb'ore / gb'ẹbo wa oni o, Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Alewileṣe, Oba ọrun",
                        "Oyigiyigi, Oba ọrun",
                        "Awimayehun, Oba ọrun",
                        "Obangiji, Oba ọrun",
                        "Wa gb'orẹ / gb'ẹbo wa oni o, Oba ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "31",
            Title = "OBA OLOORE",
            Category = "ORIN IFITORE",
            Author = "Joseph Adégbénlé",
            Chorus = new List<string>
            {
                "Awa mbe O Olodumare, Oba Oloore (2ce)",
                "Gb'orẹ wa o, gb'ẹbo wa o, Baba rere o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba Mimo O gb'ebo Abeli",
            "T'o f'eran rubo sỉ Ọ",
            "Gb'ẹbo wa o, Baba rere o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba Mimo. O gb'ebo Melkiṣedeki",
                        "T'o f'oti rubo si Ọ",
                        "Yi ju si wa. Baba rere o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba Mimo, O gb'ẹbo Abrahamu",
                        "T'o fẹ f'Ọmọ rubo si Ọ",
                        "Tẹ 'ti si wa, Gb'ẹbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba Mimo, Oba wa Jesu",
                        "T'o ku fun wa l'o rubo",
                        "To to si Ọ. Baba rere o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimo, Ẹbọ ti Misa",
                        "Ti mbẹ l'ori pẹpe",
                        "L'o to si Ọ, Baba rere o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Baba Mimo, Oba wa l'oke",
                        "Wa tẹ wọ ola si wa",
                        "Gb'ẹbo wa O. Baba rere o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "32",
            Title = "NG O PE JESU DỌRUN RERE",
            Category = "ORIN IFITORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Jesu, Jesu, Jesu mi o",
                "Jesu, Jesu, Olugbala",
                "Ng o o pe O titi ni d'ọrun rere.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo ke pe O o, Oba Mimo,",
                        "Wa gba mi la, Oba Ogo,",
                        "Dakun ṣe mi l'ogo l'ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ko seni meji ti mo tun ni,",
                        "T'o tun ju Kristi Olugbala,",
                        "Ti yio ran mi lowo o l'ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Eru ko ba mi mo d'olola,",
                        "Mo ti ni Jesu Oba Ogo,",
                        "Tì yio se mi l'ogo l'ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oyigiyigi Oba Olola,",
                        "To mi sona Oluwa o,",
                        "Lati dele mi l'ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "L'ojo 'kẹhin ti dajo,",
                        "Ma fi mi silẹ Baba mi,",
                        "Ng o pe O titi ni d'ọrun rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "33",
            Title = "BABA WA GB'EBO",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Baba wa gbebo awa Ọmọ odo Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ o, wa gbebo wa ye wo,",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olodumare, Iwo la wa rubo si",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olugbala l'Eran ẹbọ Mimo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Kristi l'Ori pepẹ mimo,",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ara at'Eje Olurapada aiye.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ara at'Ejẹ Ọmọ Ọlọrun,",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Enikeji ti Metalokan mimo,",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "To ku fun wa lori igi iye,",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Iyato ko si ninu t'agbelebu,",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "O sọ wa d'ọmọ nipa irapada,",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ o, wa gb'ẹbo wa yẹ wo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "34",
            Title = "F'ETI SI MI OLUWA",
            Category = "ORIN IFITORE",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "F'etisi mi Oluwa, ko si da mi lohun (2ce)",
                        "Ẹmi jẹ talaka at'alaini",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Pa okan mo ni mimo,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "N'tori oju rere rẹ si mi,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Ọlọrun gba mi o. Mo gbẹkẹle o.",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Ṣaanu fun mi Oluwa.",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "'Jojumo gbẹkẹle Ọ.",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "F'ami rere han mi o.",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "K'awon ota mi ko leti,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "K'oju ko le ti won,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Iranlọwọ Oluwa tu mi ninu,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Ogo ni fun Baba",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Ati fun Ọmọ,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                        "Lae ati laelae,",
                        "F'etisi mi Oluwa, ko si da mi lohun;",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "35",
            Title = "ARA Ẹ DIDE, Ẹ BA MI JO",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Ara ẹ dide, ẹ ba mi jo,",
                "Eniyan mi, ẹ ba mi yo",
                "Oluwa mi l'o gbe mi ga.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ninu ewu gbogbo, o pa mi mọ",
                        "Ninu ewu gbogbo, o mu mi ye",
                        "Kilo tun yẹ mi bi ko se opẹ",
                        "Opẹ ni t'Ẹmi lọjọ gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O wa f'ire gbogbo da mi l'ola",
                        "O tun f'ohun rere t'o tun ga ju.",
                        "T'o m'aiye ye mi t'o m'ọrun yẹ mi",
                        "B'ori ayo mi l'ojo gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O tun f'Ọmọ rere da mi l'ola",
                        "O mu mi joba sinu ayo",
                        "Mo dupẹ, mo dupẹ Baba o se",
                        "Ẹ ba mi yo mo dupẹ jojo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O fe gbogbo wa d'oju iku",
                        "O mu gbogbo wa de 'le ayo",
                        "Kilo tun yẹ wa bi ko se ope",
                        "Ope, iyin ni f'Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "B'o ba ti yẹ ni l'o yẹ k'a wi",
                        "Oruko rere l'o pe wa ju",
                        "Enit'o ni ola l'o nợ'ohun ola",
                        "A o maa yo ni l'ojo gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Oluwa rere t'o s'aiye pe",
                        "Oruko Baba l'a o maa yin",
                        "B'aiye gb'ogun de Jesu ni mo ni",
                        "Opẹ ni t'Ẹmi l'ojo gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Tẹwo gba ore ti mo mu wa",
                        "Ng o se ohun t'o un ga ju",
                        "L'aiye ti mo wa ni t'Ẹmi ara",
                        "Opẹ ni t'Ẹmi l'ojo gbogbo",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "36",
            Title = "TANI YIO MU MI DE EEDOM",
            Category = "ORIN IFITORE",
            Author = "J.B. Ojo",
            Chorus = new List<string>
            {
                "Tani yio mu mi de Eedomu",
                "Nibẹ ni ng o bọ bata mi si,",
                "Eni ti yio sin Olugbala",
                "Ni lati ni isẹra.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati ni isera",
                        "Bi, ohun elo orin mimọ",
                        "Ran mi lọwọ Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati fẹ Ọlọrun",
                        "Okuta ti Ọmọlẹ ko sílẹ",
                        "Li o di pataki igun ile.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Ọlọrun",
                        "Ni lati s'ootọ si i.",
                        "Otitọ nipilẹsẹ ọrọ Rẹ",
                        "Ẹmi nreti Igbala R.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati ni Ifẹni.",
                        "Ki l'ere ẹjẹ ẹni mimọ",
                        "Bi a ko ba sin In bi o ti yẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati ru ẹbọ ọpẹ si i",
                        "Ohun ayọ nhẹ ninu agọ",
                        "Awọn olododo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati ni isẹra",
                        "Jẹ ki okan mi o wa laaye",
                        "Kini ki nfi fun Ọ... jare.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹni ti yio sin Olugbala",
                        "Ni lati ni isẹra",
                        "M'ohun to dara f'Ọlọrun re",
                        "Yin Ọlọrun rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "37",
            Title = "BABA MIMỌ T'O DA WA S'AIYE",
            Category = "ORIN IFITORE",
            Author = "Oloye S. O. Ajala",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba mimọ t'o da wa s'aiye",
                        "Jọwọ o gb'ẹbo wa o",
                        "Baba ti n se 'tọju wa",
                        "Baba Edumare tẹ 'wọ gb'ẹbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba ti an sin ni 'le aiye",
                        "Jọwọ o gb'ẹbo wa o",
                        "Baba ti maa saanu fun wa",
                        "Baba Edumare tẹ 'wọ gb'ẹbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba t'o f'Olugbala fun wa l'aiye",
                        "Jọwọ o gb'ẹbo wa o.",
                        "Ti a fi ri 'gbala l'aiye wa",
                        "Baba Edumare te 'wo gb'ẹbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba t'o t'ẹwọ gb'ẹbo Abeli",
                        "Jọwọ o gb'ẹbo wa o.",
                        "A mu akara wa ru l'ẹbọ si Ọ.",
                        "Baba Edumare t'ẹwọ gb'ẹbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba to gb'ẹbo Melkisẹdẹki",
                        "Jọwọ o gb'ẹbo wa o.",
                        "A mu ọti yi wa ru lẹbọ si Ọ",
                        "Baba Edumare tẹ 'wọ gb'ẹbo wa o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "38",
            Title = "JỌWỌ WA GB'ẸBO WA",
            Category = "ORIN IFITORE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Jọwọ wa gb'ẹbo wa )",
                "Jọwọ wa gb'ẹbo wa) 2ce",
                "A ke pe Ọ o, Olodumare,",
                "Jọwọ wa gb'ẹbo wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọba mimọ, Ọba toto, Ọba Ologo;",
                        "Edumare a rúbọ si Ọ",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba mimọ, Baba Ọlọla,",
                        "Baba wa ọrun Baba l'oke a rúbọ si Ọ.",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹbọ mimọ, Ẹbọ Ọlọlá.",
                        "Ẹbọ Ologo Ẹbọ iye l'aru si 0;",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹbọ mimọ, Ẹbọ oniyebiye, Ẹbọ Oluwa wa;",
                        "Ara Jesu l'aru l'ẹbọ si Ọ,",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Fun Ọlanla ti Iwo Ọlọrun Baba,",
                        "L'awa n rúbọ si Ọ,",
                        "Fun ọpẹ, iyin t'oyẹ fun Ọ,",
                        "jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Fun ohun gbogbo ti an reti.",
                        "L'awa n rúbọ wa.",
                        "Fun idariji ti gbogbo ẹsẹ wa.",
                        "jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "K'ale sin Ọ titi d'oju iku,",
                        "Awa rúbọ si Ọ,",
                        "K'ale la d'ode ọrun,",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ẹbọ mimọ, Ẹbọ t'oyẹ Ọ",
                        "Iwọ Ọlọrun Baba,",
                        "Oyigiyigi Ọba Alewileṣe",
                        "Jọwọ wa gb'ẹbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "39",
            Title = "MO WO KA TITI GBOGBO AGBAIYE",
            Category = "ORIN IFITORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Mo wo ka titi gbogbo agbaiye o",
                "Ẹmi ko ri 'ru meji Ọlọrun Ọba.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun l'ajiki Ọlọrun l'ajiyin",
                        "Ọgbagba ti ngbara adugbo",
                        "L'Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun Ọba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "On l'Ọba aiku, On l'ọba iye",
                        "Onile-ka-ya-ka-yo l'Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun Ọba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "On l'Ọba ana, On l'Ọba oni, On l'ọba ọla",
                        "A-ko-mati-ka-lehin l'Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "On l'Ọba anu, On l'ọba Olupese",
                        "A-fun-ni masi-regun l'Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun Ọba.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "On l'Ọba Olubukun, On l'Ọba Olupese",
                        "A-fun-ni-ma-ma-gbẹjẹ l'Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "On lo da oọrun, oṣupa, irawọ",
                        "A-wa-ma-ri-di niṣẹ Ọlọrun wa o",
                        "Ẹmi ko ri 'ru meji Ọlọrun wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ajalaiye, Oyigiyigi Atobiju",
                        "Ọlọwọ-gbọgbọrọ-ti-nyọmọ Rẹ l'ọfin",
                        "Ẹmi ko ri 'ru meji Ọlọrun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "40",
            Title = "OLUPESE L'ỌLỌRUN",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Baba Mimọ mo m'ẹbun mi tọ wa",
                "Olupese l'Ọlọrun",
                "Ire ti mo ni o, Edumare,",
                "L'ọwọ Rẹ lo ma ti wa",
                "Opẹ lo yẹ fun Ọ Baba Mimọ",
                "Olupese l'Ọlọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi mo ba ma dupẹ ore t'Oluwa ṣe",
                        "Ẹgbẹrun ahan o, ko to f'ore han",
                        "Ṣugbọn Baba o, o yẹ ki ndupẹ",
                        "Nibi t'ahan mi mọ, nibi t'ọgbọn mi mọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Owo tí a ni lọwọ Rẹ lo ti wa",
                        "Ọmọ ti a bi o, Baba l'o mu ye",
                        "Otitọ lo yẹ ki a juba Rẹ",
                        "Onile ayọ, Olodumare.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi ẹ ba ma dupẹ, ẹ b'oju w'aiye",
                        "Ẹ w'ayika yin, ẹ w'oju ọrun wo",
                        "Baba l'o fihan, ninu iṣẹ to ṣe",
                        "P'oun l'o da wa o, p'Oun l'o fẹ wa ju.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ibi t'aiye ti yi wa Baba l'o le sọ",
                        "Asẹhinwa aiye o, Baba l'o le mọ",
                        "Eyi daju o, pe nẹe t'a d'aiye",
                        "L'a b'aiye mun 'lẹ l'a b'olu jiyan.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Aiye gb'ogun de, Baba l'o ṣẹgun",
                        "Eṣu gb'ogun de o, Baba l'o gbe fo",
                        "Ọta t'o ri wa, t'o ndana oro",
                        "Baba l'o fi han, Baba l'o l'ayọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Nitori araiye, Baba f'Ọmọ rubọ",
                        "Nitori ẹlẹsẹ Baba f'Ọmọ ji",
                        "Ileri to ṣe nitori mi",
                        "Ifẹ lo fihan, ifẹ lo ga ju.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "41",
            Title = "IYIN AT'ỌPẸ L'A WA FUN Ọ",
            Category = "ORIN IFITORE",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
                "Baba wa gbọpé wa (Eemeji)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'iwa ati 'ṣe tọrẹ f'Oluwa Ọba ti ns'ẹru d'ọmọ,",
                        "Egbe: F'iwa ati 'se tọrẹ f'Oluwa Ọba ti ns'ẹru d'ọmọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ilu ati 'jo lafi wa jọsin Baba dakun gbọ tiwa",
                        "Egbe: Baba dabọ gbọ tiwa ...",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "F'iyin at'ola fun Baba l'oke Ẹni to sọ wa d'ọmọ",
                        "Egbe: F'iyin at'ola ...",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "42",
            Title = "TANI MO NI BIKOṢE JESU",
            Category = "ORIN IFITORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Tani mo ni o, t'ọkan mi fi le",
                "Olugbala Atobiju ni",
                "Baba s'ẹkun mi d'ayọ",
                "Ko doju ti mi o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olugbala mi Ọba mimọ",
                        "Ṣe mi loore o",
                        "Wa pon mi le o, Baba rere",
                        "Ng o sin Ọ titi ni, Baba mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo tỉ m'ọdọ Rẹ, mo ti r'ọla",
                        "Mo lori ire o",
                        "Ọla to yẹ mi ko fi fun mi",
                        "Ng o sin Ọ titi ni, Baba mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo ti tete mo ti l'ọmọ",
                        "Ọba Awimayẹhun",
                        "To gbe mi leke amọniṣeni",
                        "Ng o sin Ọ titi ni, Baba mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo rinrin gbẹrẹ mo dolola",
                        "Mo ti l'Oluwa ju",
                        "O tẹ mi lọrun gbẹdẹmukẹ",
                        "Ng o sin Ọ titi ni, Baba mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gba ẹbẹ mi Ọba Ọlọla",
                        "Baba ye ṣọ mi o",
                        "Wa da mi si o Baba rere",
                        "Ng o sin Ọ titi ni, Baba mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "43",
            Title = "AWA MỌRẸ WA DE",
            Category = "ORIN IFITORE",
            Author = "Oloye S. O. Ajala",
            Chorus = new List<string>
            {
                "Awa m'ọrẹ wa de",
                "Olodumare jọwọ tẹwọ gb'ọrẹ awa o",
                "Awa m'ọrẹ wa de o (2ce)",
                "Olodumare jọwọ tewo gb'ọrẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba wa Ọrun awa de",
                        "Lati fiyin atọpẹ fun Ọ",
                        "Fun gbogbo oore at'ẹbun Re",
                        "Ti a ti ri gba l'aiye wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ni'se gbogbo ti a da'wọle",
                        "Lọna gbogbo ti awa ti tọ",
                        "Iwọ l'oludari rere",
                        "Li ọjọ aiye wa gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ti ṣẹ si Ọ Baba, ye",
                        "A ti ṣẹ si O lona pupọ.",
                        "Jọwọ maa kọ wa sile Baba,",
                        "Ki a le wọ 'nu Ogo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awa n fi 'relẹ bẹ Ọ",
                        "Ma ṣai tẹwọ gb'ọrẹ awa o.",
                        "Ọrẹ ẹlẹsẹ to piwada",
                        "Jọwọ wa foriji wa o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ogo fun Ọ, Baba Mimo",
                        "Iyin ni f'ọmọ to jinde",
                        "Ọpẹ fun Ẹmi Mimọ o",
                        "Titi aiye ainipẹkun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "44",
            Title = "ẸYIN ARA Ẹ YỌ",
            Category = "ORIN IFITORE",
            Author = "Joseph Adégbénlé",
            Chorus = new List<string>
            {
                "Ẹyin ara ẹ yo,",
                "Ẹ yọ ninu Oluwa.",
                "Olu-fun-ni ni iye,",
                "Ẹyin ara ẹ yọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ibukun Oluwa ni t'Ẹmi",
                        "Ọmọ Jesu ni mi,",
                        "O wẹ mi mọ, O fi'po t'o ga fun mi",
                        "Ẹyin ara ẹ yọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Igbagbọ l'orisun ayọ mi",
                        "Mo ti jẹ'pẹ Olu,",
                        "O pe mi tan, o f'ipo t'o yẹ fun mi",
                        "Ẹyin ara ẹ yọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọna ifẹ Oluwa ni t'Ẹmi",
                        "Mo yin Jesu (ti) mo fẹ.",
                        "O f'ifẹ gbe, O tilẹ ku t'ori mi,",
                        "Ẹ dide ẹ ba mi yọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iyin lo yẹ f'Ọba Ogo",
                        "Ọba loke o ṣe.",
                        "Bi ala l'o ṣe f'isegun fun mi",
                        "Ẹ dide ẹ ba mi yọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Igbimọ ti mbẹ lọrun, ẹ dide",
                        "K'a jọ gb'ohun ọpẹ.",
                        "F'ẹbun t'o gbe kalẹ nitori mi",
                        "Ẹ dide ẹ bami yọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọpọ ẹda aiye, ẹ dide",
                        "K'a jọ gb'ohun ọpẹ",
                        "Fun 'bukun t'Ọba ọrun ti fun mi",
                        "Ẹ dide ẹ ba mi yọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "45",
            Title = "BABA MO M'ẸBUN MI TỌ Ọ WA O",
            Category = "ORIN IFITORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Baba mo m'ẹbun mi tọ Ọ wa o",
                "Olupese je nri tẸmi ṣe",
                "Onile k'aya k'ayo",
                "Wagbọ tẸmi Baba mimọ",
                "Ṣe mi loore ainipekun Baba.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iwọ lo da mi",
                        "Iwọ ni mo gba",
                        "L'Eleda mi daju Saka",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ to fẹ mi",
                        "Iwọ ni mo mọ̀",
                        "L'oloore Olubukun",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ lo ntọ mi",
                        "Iwọ ni n go sin",
                        "Awimayehun Ọba Mimọ",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwọ lo nkọ mi",
                        "Iwọ ni Ng o tọ",
                        "Aṣekan maku Ọba pipe",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ lo nṣọ mi",
                        "Iwọ ni ng o du",
                        "Iwọ lọ barin kiya tan",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọna Rẹ lo dara",
                        "On lo ga ju",
                        "Mo sa di Ọ o Ọba ọlọlá",
                        "Ṣe mi l'oore o Baba ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "46",
            Title = "JỌWỌ GBỌ T'ẸMI",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jọwọ ghọ t'Ẹmi nijọ gbogbo",
                        "Jọwọ gbọ t'Ẹmi Baba Mimọ",
                        "jọwọ gbọ t'Ẹmi n'ijo gbogbo",
                        "Jọwọ gbọ t'Ẹmi Edumare",
                        "Mo kigbe si Ọ Ọlọrun mi",
                        "Baba dakun da mi lohun",
                        "Alewileṣe Baba rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ṣe 'tọju mi n'ijọ gbogbo",
                        "Ṣe 'tọju mi Baba Mimọ",
                        "Ṣe 'tọju mi n'ijo gbogbo",
                        "Ṣe 'tọju mi Edumare.",
                        "Aiye ti gb'ogun 'tori pe mo sin Ọ",
                        "Oniṣe ibi ti nw'ọna, ki n le y'ẹhin pada.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ifẹ l'o ju, ẹ sunmọ Baba",
                        "Akoja ofin n'ifẹ mimọ",
                        "Ifẹ l'oju ẹ sunmọ Baba",
                        "Jọwọ fẹnikeji",
                        "Ẹni ba ti fẹ Baba, ire a wọ 'le fun u",
                        "Ẹni ba ti f'ẹnikeji, Baba a bukun fun u.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gba yi gbọ o, k'o ṣiwọ ibi",
                        "Baba lo m'atisun ẹda",
                        "Gba 'yi gbọ o, k'o ṣiwọ ibi",
                        "Baba l'o m'atisun.",
                        "Ire ti o ba ṣe d'opin, Baba afi fun Ọ",
                        "Iwa buburu t'o gbe wọ, Baba a ṣ'ẹsan re.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "47",
            Title = "JỌWỌ MA ṢAI WA GB'ẸBO WA",
            Category = "ORIN IFITORE",
            Author = "H. A. Ọrẹdipẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọba Edumare Baba Mímọ",
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Jọwọ ma ṣai wa gb'ẹbo wa (2ce)",
                        "Ọba Edumare Baba Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Ọba Edumare a dakẹ dajo",
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Ọba Edumare Alewileṣe",
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Ọba Edumare Ariwarehin",
                        "jọwọ ma ṣai wa gb'ẹbo wa",
                        "Ọba Edumare Arinurode",
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Ọba Edumare Ọba t'o tobi",
                        "Jọwọ ma ṣai wa gb'ẹbo wa",
                        "Jọwọ ma ṣai wa gb'ẹbo wa (2ce)",
                        "Ọba Edumare, Baba Mimọ",
                        "Jọwọ ma ṣai wa gb'ẹbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "48",
            Title = "GB'EBO WA OLODUMARE",
            Category = "ORIN IFITORE",
            Author = "S. O. Ogundipẹ",
            Chorus = new List<string>
            {
                "Gb'ẹbo wa Olodumare gb'ẹbo wa,",
                "Baba iye, gb'ẹbo wa,",
                "Olodumare, gb'ẹbo wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gba akara, ti a mu wa",
                        "Gẹgẹ bi ọrẹ awa ọmọ Rẹ,",
                        "Yi pada s'ara Jesu fun wa",
                        "Gb'ẹbo wa, Olodumare gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gba ọti waini ti a mu wa",
                        "Gẹgẹ bi ọrẹ awa ọmọ Re,",
                        "Yi pada s'ẹjẹ Jesu fun wa",
                        "Gb'ẹbo wa, Olodumare gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oyigiyigi Baba Mimọ",
                        "Wa gb'ẹbo awa Ọmọ Rẹ",
                        "Oniṣe pipe Baba rere",
                        "Gb'ẹbo wa, Olodumare gb'ẹbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "49",
            Title = "ELETI GBAROYE",
            Category = "ORIN IFITORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Eleti Gbaroye jọwọ gbọ ti wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jọwọ gbọ ti wa o, Jọwọ gbọ ti wa",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba mimo oninurere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olodumare Alewi-leṣe.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa gbo ti wa l'ojo ewu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ninu riri je ninu riri mu.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ninu ogun at'ọtẹ tutu.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ninu ebi at'iyan to pẹ",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọrọ rẹ ni iye to pọ",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ṣi wa l'eti ka le gbọ o.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Iṣẹ rere ati 'wa to pe",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Jọwọ ifun wa Baba Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Ọrun rere ilu Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Mu wa de bẹ wa yin Ọ o.",
                    }
                },
                new Verse
                {
                    Number = "14",
                    Lines = new List<string>
                    {
                        "Ọba ọrun, Ọba toto.",
                    }
                },
                new Verse
                {
                    Number = "15",
                    Lines = new List<string>
                    {
                        "Jọwọ gbọ ti wa o, jọwọ gbọ ti wa",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "50",
            Title = "ẸMI YIO GBE Ọ GA OLUWA",
            Category = "ORIN IFITORE",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
                "Ẹmi yio gbe Ọ ga Oluwa",
                "Nitori ti iwọ ti gba mi la",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iwọ gba mi s'abẹ abo rẹ Oluwa,",
                        "Iwọ ko si jẹ ki ọta mi yọ mi o",
                        "Ẹmi ti ki 'gbe pe Ọ Oluwa",
                        "Iwọ si ti mu mi lara da.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ ti mu ẹmi mi,",
                        "Kuro l'ọrun apadi,",
                        "Iwọ si ti gba mi la,",
                        "Kuro l'ọwọ awọn ti ngbe inu iho.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ kọrin iyin si Oluwa.",
                        "Gbogbo ẹyin eniyan mimọ Rẹ",
                        "Ẹ kọrin iyin si Oluwa",
                        "Ologo julọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹmi yio kigbe pe Oluwa,",
                        "Ẹmi yio si bẹ Ọlọrun mi,",
                        "Ko si ere ninu ese,",
                        "Ẹmi ki yio huwa aimo O.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oluwa lo so ibanujẹ mi dayo,",
                        "O si fi ayo kun okan mi",
                        "Ọlọrun mi,",
                        "L'Ẹmi yio ma yin titi lae.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "51",
            Title = "OLUṢONI-DI-MIMO",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Wa, Olodumare Olusoni di mimo",
                "Wa 'bukun f'awon ebun",
                "Ti a pese silẹ fun ogo oruko rẹ",
                "Wa, Olodumare Olusoni di mimo",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jeki ebo wa oni",
                        "Le ba inu rere Rẹ",
                        "Pade Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jẹki ifitore oni",
                        "Le goke wa sodo rẹ",
                        "A be O Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jẹki ẹbọ ti a mu wa",
                        "Le da bi t'Abeli",
                        "Niwaju Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jẹki ẹbo wa oni",
                        "Le je atewogba",
                        "jọwọ Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jẹki a layo",
                        "Lati le roju re titi lae",
                        "jọwọ Ọlọrun mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Oluwa",
                        "Lo ru 'ra re l'ebo",
                        "Awọn Oba aiye yi-o",
                        "Foribalẹ fun un.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "52",
            Title = "JỌWỌ WA O, WA TEWO GBEBO WA",
            Category = "ORIN IFITORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Awa ma tun de o Ọlọrun Olodumare (2ce)",
                "Lati rubo si O",
                "Wa gb'ẹbo wa, wa gb'ẹbo wa",
                "Oba ọrun a de lati rubo si Ọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu a de lati rubo si Ọ (2ce)",
                        "jọwọ wa o, wa t'ẹwo gbẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu o fe ki a je Ọmọ Re (2ce)",
                        "jọwọ wa o, wa tẹwo gbẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu t'aru l'ebo lori pẹpẹ (2ce)",
                        "jọwọ wa o, wa tẹwo gbẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Ọba Mimọ dari ji ni (2ce)",
                        "jọwọ wa o, wa t'ẹwo gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Ọba Mimo, to wa si ona Re (2ce)",
                        "jọwọ wa o, wa t'ẹwo gb'ebo wa.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "53",
    Title = "BABA MIMỌ",
    Category = "ORIN IFITORE",
    Author = "Alufaa T. M. Ilesanmi",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "Baba Mimo saanu wa...Ṣaanu wa",
                "Awa o ma l'Ọlọrun meji...Ṣaanu wa",
                "Iwo nikan l'alaabo wa...Ṣaanu wa",
                "Gbogbo ese ti a se si O...Ṣaanu wa",
                "Baba Mimo f'ori ji wa o...Ṣaanu wa",
                "L'owo ota ile gba wa o...Ṣaanu wa",
                "L'owo ota ode gba wa o...Ṣaanu wa",
                "Oba Mimo Arinurode...Ṣaanu wa",
                "Orogojigo Olu-Ọrun...Ṣaanu wa",
                "Alala funfun Oke-ọrun...Ṣaanu wa",
                "Oba Mimo Aṣekanmaku...Ṣaanu wa",
                "Asoromayẹ Oba iye...Ṣaanu wa",
                "Baba fun alaini Baba...Ṣaanu wa",
                "Olutoju alaimokan...Ṣaanu wa",
                "Oyigiyigi Oba Iye....Ṣaanu wa",
            }
        },
    }
},
        new Hymn
        {
            Number = "54",
            Title = "ỌLỌRUN FESE JI",
            Category = "ORIN IFITORE",
            Author = "J. A. Adesina",
            Chorus = new List<string>
            {
                "Ọlọrun f'eṣe ji",
                "Awa ẹlẹse ma mbẹbẹ",
                "So wa d'atunbi ninu Jesu,",
                "Ọmọ Re nikansoso Oluwa wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba Mimo awa de",
                        "Gegebi ase Re",
                        "Pe a ni lati d'atunbi",
                        "K'a to wo 'joba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun wa awa de",
                        "Ninu ẹse l'a bi wa",
                        "We wa mo t'ara t'okan",
                        "K'a jẹ tirẹ titi aiye.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọrun ran wa lọwọ",
                        "Ran Ẹmi-Mimo Re",
                        "K'o so wa d'atunbi",
                        "K'a le ba O gbe l'ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba Mimo awa dupẹ",
                        "Je ki ororo ori wa",
                        "Je imukuro ese",
                        "K'a d'atunbi rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "55",
            Title = "RAN IMOLE RE JADE (PS. 43)",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Ran imole re jade, ran otito rẹ jade",
                "Awọn ni yio s'amona mi lo s'ori oke rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ṣe idajo mi, Ọlọrun mi",
                        "Ya oran mi s'oto kuro l'orile-ede alaimokan.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba rere O, Iwo ni Ọlọrun mi",
                        "Iwo ni agbara mi, jọwọ ba mi segun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa eese ti o fi ṣa mi ti",
                        "jọwọ gbọ ohun awọn agutan agbo rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Okan mi ma banuje, Oluwa n'ireti rẹ",
                        "Olubanikẹdun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "56",
            Title = "GB'OPẸ WA EDUMARE",
            Category = "ORIN IFITORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gb'opẹ wa Edumare, gb'ope wa a mbẹbe gb'ope wa. (2ce)",
                        "A wa lati rubo si Ọ Baba Mimo jọwọ o, gb'ope wa",
                        "F'ibukun Re s'ori wa o, Baba wa gb'ope wa",
                        "Olodumare dakun a mbẹbe wa sure fun wa",
                        "jọwọ o, a kigbe pe O Ọlọrun Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gb'ope wa Edumare gb'ope wa a n juba, gb'ope wa. (2ce)",
                        "A wa lati f'ope fun O, Baba Mimo jọwọ o, gb'opẹ wa",
                        "jọwọ wa gbebo ti a nru o, Jehova mi si wa.",
                        "Olodumare dakun a mbẹbe wa gb'ope wa",
                        "jọwọ o, a kigbe pe O Ọlọrun Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gb'ope wa Edumare gb'ope wa Oyigiyigi, gb'ope wa. (2ce)",
                        "A wa lati fiyin fun O Baba Mimo jọwọ o, gb'opẹ wa",
                        "F'ibukun rẹ kari wa o, jare wa gb'opẹ wa",
                        "Olodumare dakun a mbẹbẹ wa sure fun wa",
                        "jọwọ o, a kigbe pe O Ọlọrun Baba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gb'ope wa Edumare gb'ope wa Obangiji, gb'ope wa. (2ce)",
                        "A de lati rubo si O Baba Mimo jọwọ o, gb'opẹ wa",
                        "jọwọ wa gbebọ ti an ru o, Jehova sure fun wa",
                        "Olodumare dakun a mbẹbe wa gbo pe wa",
                        "jọwọ o, a kigbe pe O Ọlọrun Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "57",
            Title = "BABA OLOORE GB'ORE WA",
            Category = "ORIN IFITORE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba Oloore gb'orẹ wa o",
                        "Baba Oloore gb'ẹbun wa 2ce",
                        "Gb'ore wa Baba Mimo",
                        "Wa gbo adura wa",
                        "Wa fi bukun fun wa",
                        "Wa f'ayo ka wa lori",
                        "Oyigiyigi Baba wa",
                        "Dakun jọwọ gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba Oloore gb'orẹ wa",
                        "Baba Oloore gb'ẹbun wa 2ce",
                        "Ohun ti a ni ni a mu wa",
                        "Eyi ni Kristi ọmọ Re",
                        "Ti o wa lori pepe",
                        "Baba gba wa nipa Ọmọ Re",
                        "Edumare Oba ogo",
                        "Dakun Jọwọ gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba Oloore gb'orẹ wa",
                        "Baba Oloore gb'ẹbun wa 2ce",
                        "Oyigiyigi Iwo l'a gbojule",
                        "Gba wa kuro ninu ewu",
                        "Gbo ẹbe wa Baba",
                        "Awa wolẹ niwaju Re",
                        "Wa gba wa tifetife",
                        "Awihun-maye Baba ọrun",
                        "Dakun jọwọ gbọ tì wa",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "58",
            Title = "OLUWA KO FE IKU ELESE",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa ko fe 'ku elese",
                        "Bi ko se ironu piwada",
                        "Oluwa ko fe 'ku elese",
                        "E ronu, e p'iwa da",
                        "Oluwa ko fe 'ku elese",
                        "Bee ni Ẹmi Mimo",
                        "Bẹẹ ni, Bẹẹ ni, Bee ni",
                        "Baba l'ọrun rere",
                        "Oluwa ko fe ku elese.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa l'Oludajo elese",
                        "L'ai wo agbejoro eniyan",
                        "Oluwa l'Oludajo elese",
                        "Oba t'o m'okan ese",
                        "Oluwa l'Oludajo elese",
                        "So 'wa re, ore l'aiye",
                        "Ṣo 'wa rẹ, so wa re so wa re;",
                        "Ye 'ra f'ofin ese",
                        "Oluwa l'Oludajo elese.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ara e f'otito sin Jesu",
                        "Mase gun wa sipo ese",
                        "Ara e f'otito sin Jesu",
                        "Oba t'o le f'ese ji",
                        "Ara e f'otito sin Jesu",
                        "Kiyesi otito pe",
                        "Kiyesi, kiyesi, kiyesi",
                        "Oba t'o le gba ni",
                        "Ara ẹ f'otito sin Jesu.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa saanu elese",
                        "Ma-se kiyesi 'wa ese",
                        "Oluwa saanu elese",
                        "Oba t'o we ese nu",
                        "Oluwa sanu elese",
                        "Gbo t'Ẹmi Baba Mimo",
                        "Ghọ t'Ẹmi, gbọ t'Ẹmi, gbo t'Ẹmi",
                        "Baba ba mi ye 'bi",
                        "Oluwa saanu elese.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "59",
            Title = "EGUN OGAN (L'AKOKO IKORE)",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Egun ogan ko le s'eso ajara f'eni",
                "Toṣusu ko le s'eso t'opoto o",
                "Olu ọrun jọwọ wa fere s'ori iṣe wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dara wa f'Ọlọrun re",
                        "Afunrugbin jade lati funrugbin rè",
                        "Die bọ s'eba ona, eiye si sa je.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dara wa f'Ọlọrun re",
                        "Afunrungbin jade lati funrugbin re",
                        "Diẹ bọ sinu egun, egun si fun un pa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dara wa f'Ọlọrun re",
                        "Afunrugbin jade lati funrugbin rẹ",
                        "Diẹ hu lori apata, o ku lai r'omi mu",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dara wa f'Ọlọrun re",
                        "Afunrugbin jade lati funrugbin re",
                        "Diẹ hu soke, pelu eso rere lori ile rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dra wa f'Ọlọrun re",
                        "Afunrugbin jade lati funrugbin re",
                        "Eni ni eti ko feti si oro mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "M'ohun t'o dara wa f'Ọlọrun rẹ",
                        "Afunrugbin jade lati funrugbin rẹ",
                        "Eyin la fi fun lati m'oro ijinlẹ",
                        "Owe li eyi, irugbin l'oro Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "60",
            Title = "TEWỌ GB'EBỌ WA BABA RERE",
            Category = "ORIN IFITORE",
            Author = "J. Feyiṣitan",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Tẹwo gb'ẹbo wa Baba rere (2ce)",
                        "Iwọ l'a rubo si Baba rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tẹwo b'ẹbo wa Baba rere (2ce)",
                        "Gegẹ bi ti Abeli o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Tẹwo gb'ẹbo wa Baba rere (2ce)",
                        "Ṣiju aanu wo wa Baba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Tewo gb'ẹbo wa Baba rere (2ce)",
                        "S'akara yi di ara Ọmọ Re",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Tewọ gb'ebo wa Baba rere (2ce)",
                        "S'oti yi dẹjẹ ọmọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Tẹwo gb'ẹbo wa Baba rere (2ce)",
                        "Ọmọ Rẹ l'a fi rubo si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Tẹwo gb'ẹbo wa Baba rere (2ce)",
                        "A gboju wa soke si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Tewo gb'ẹbo wa Baba rere (2ce)",
                        "Majemu wa l'a wa mu se.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "61",
            Title = "OPẸ L'O YẸ O OLODUMARE",
            Category = "ORIN IFITORE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Ope l'o ye O Olodumare; a dupẹ Baba rere.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa dupe, Awimayehun, Onibu-ore; Olubukun. Orogojigo Oba Mimo a de, a dupe; a t'ope da. Asekan-maku Oba t'o da wa si, a dupẹ; at'opẹ da Alewilese, Olumo-okan, Arinurode t'o da wa si; jọwọ wa gb'opẹ Ọmọ-odo Re, enit'o m'orẹ wa. Gbogbo Ijo l'a pe jo po l'a wa dupẹ f'Oba Mimo. B'Ọmọde ba dupẹ oore ana ire tuntun yio wo'le. B'agbalagba l'o dupe oore ana ire tuntun yoo wo'le Oba Ogo, Atobiju, Oba toto, a dupẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Aiye gb'ogun de Olodumare, a dupẹ o b'aiye wi",
                        "Awa dupẹ Olodumare, o da wa si, a t'ope da.",
                        "Gbogbo ebun rere ti a gba, Oba Mimo l'a dupẹ fun Oyigiyigi, ekun aseke, a dupẹ, a t'ope da.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "(A le fi awon oro opẹ miran kun un).",
                        "Fun apere:- Ninu ewu oko o mu wa ye, Oba Mimo a wa dupe.",
                        "Ope l'o ye o Olusegun ota, Oba t'o mba wa gbe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "62",
            Title = "OBA OLUWA MO MU ORE MI WA",
            Category = "ORIN IFITORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oba Oluwa mo mu ore mi wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Mo de, mo de o; Olugbala mo de; mo de",
                        "Tẹ'wo gba orẹ mi, Oba Ogo o,",
                        "Olugbala mo mu orẹ mi wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jeki ore mi je ate'wogba fun O.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jeki ore mi so eso rere fun mi,",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ma si se ko mi silẹ ninu ese mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Oba Ogo, wa te'wo gb'ore mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Mase je ki awon ota segun mi,",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ki O si wa pelu mi ni igba gbogbo,",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Oba Oluwa mo mu ore mi wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "63",
            Title = "TIRE NI A O SE TITI AIYE",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Tire ni o, Tire ni Baba (2ce)",
                "Tire ni a o se titi aiye",
                "Wese mi nu, Oluwa jare.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Tirẹ ni laelae, lawa n ṣe",
                        "Olugbala at'ore elese",
                        "Labe iso rere Re",
                        "Gbe wa ni'ja Oluwa jare.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tire ni titi l'awa n se",
                        "Olugbala at'ore elese",
                        "Wa gbe ja wa l'ojo gbogbo",
                        "Da wa nide Oluwa jare.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Tire ni laelae, Oluwa mi",
                        "Olugbala at'ore elese",
                        "We okan mi nu ninu ibinu re",
                        "T'eti s'ebe aw'Ọmọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Tire ni titi, d'opin aiye",
                        "Olugbala, ti mbẹ 'lese wo",
                        "Wa fun wa lakara iye Re",
                        "To wa sona ibugbe rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Tire ni titi d'opin aiye",
                        "Olugbala at'ore elese",
                        "Gbe wa leke, iṣoro wa",
                        "M'okan wa duro labẹ abo Re.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Tire ni laelae, Ọlọrun ife",
                        "Oluwosan at'ore elese",
                        "L'abẹ abo iyẹ apa Re",
                        "L'Ẹmi yio ma kigbe pe O.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Tirẹ ni laelae, Ọlọrun mi",
                        "Oluwosan at'ore elese",
                        "Iwo to ji Lasaru dide",
                        "Yo mi kuro ninu iwa ẹgbin.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Tirẹ ni laelae Orisun ife",
                        "Iwo ni 'mọlẹ ti mo'kunkun",
                        "Gba okan mi la ninu ewu oru",
                        "M'akara iye re bọ ọkan mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "64",
            Title = "BABA A MBẸ Ọ F'OJU RERE WO WA",
            Category = "ORIN IFITORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba a mbẹ Ọ o, wa f'ojure wo wa wa o (2ce)",
                        "Ye, a mbẹ O o Baba (2ce)",
                        "Pese fun wa o Baba Mimo,",
                        "K'ale maa ṣe ifẹ rẹ",
                        "Oba ipese dakun wa o,",
                        "A kigbe s'oke si Oo",
                        "Olu Ọrun, wa jọwọ o.",
                        "Ye a mbe Ọ o. Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba a wolẹ fun Ọ, wa so wa d'eni ogo (2ce)",
                        "Ye' a mbe Ọ o Baba (2ce)",
                        "Ran wa lowo o Baba Mimo,",
                        "K'a le feran re bi o ti yẹ",
                        "Oba irele dakun wa o",
                        "A kigbe s'oke si Oo,",
                        "Olu ọrun wa, jọwọ O.",
                        "Ye a mbẹ O o. Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba a mbe Oo, to wa si ona Re (2ce)",
                        "Ye, a mbẹ o Baba (2ce)",
                        "jọwọ ko wa o Baba Mimo",
                        "K'a le maa rin ni ona Re.",
                        "Olupese da wa si o",
                        "A kigbe s'oke si Ọo,",
                        "Olu ọrun wa, jọwọ O.",
                        "Ye a mbe Oo, Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "65",
            Title = "ỌLỌRUN JỌWỌ O, A NRUBỌ SI Ọ",
            Category = "ORIN IFITORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ o, a n rubo si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Baba rere, Olufijin eṣe, dariji awa omọ rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tokantokan l'a fin rubo si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olodumare, jare t'ẹwo gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ma ṣe fi ẹsẹ wa bi wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Kristi iwo l'a n rubo si.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Je ki ebo wa si O je atewogba.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ebo alailabawon l'a n ru si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Dakun ye o, Baba, wa gb'ẹbo wa.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ o, a n rubo si Ọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "66",
            Title = "ỌLỌRUN JARE WA GBEBO WA",
            Category = "ORIN IFITORE",
            Author = "J. Feyisitan",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ebo wa...gb'ẹbó wa o.",
                        "Iwo lo gbebo ti Abeli...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ẹbowa ...gb'ẹbó wa o.",
                        "Iwo lo gbebo ti Melkisedẹki...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ebo wa...gb'ẹbó wa o.",
                        "Iwo lo pese iru ebo bayi...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ẹbo wa ...gb'ẹbó wa o.",
                        "Ọmọ Re ayanfe la fi rubo si...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ebo wa...gb'ẹbó wa o.",
                        "Iwo lo s'akara d'ara Ọmọ Re...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ebo wa...gb'ẹbó wa o.",
                        "Iwọ lo sọ oti waini d'eje Ọmọ Re...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ẹbo wa...gb'ẹbó wa o.",
                        "A bẹ Ọ fun gbogbo araiye...gb'ẹbó wa o.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọlọrun jare wa gb'ebo wa...gb'ẹbó wa o.",
                        "A bẹ Ọ fun gbogbo awon oloogbe ...gb'ẹbó wa o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "67",
            Title = "WA GBỌ TIWA",
            Category = "ORIN IFITORE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Wa gbọ ti wa nа",
                "A bẹ Ọ Baba o",
                "Wa, Alewilese",
                "Wa o, wa jare wa gbo (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ayanfẹ rẹ l'awa jẹ Oba Jesu",
                        "A wa lati to O wa Ọmọ Ọlọrun",
                        "Jesu Kristi Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọre mimo kan ko si bi Oba Jesu",
                        "Fi Ifẹ nla re gba wa, ye Oba Ologo",
                        "Jesu Kristi Oba Mimo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Alewilese 1'ifẹ wa Oba Jesu",
                        "Yara dakun ran wa lọwọ mọ Ọlọrun",
                        "Jesu Kristi Oba Mimo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "L'abẹ abo rẹ l'awa laiye Olurapada",
                        "Ninu Ola re la le gba nile aiye o",
                        "Jesu Kristi Oba aanu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A dupẹ lowo rẹ Baba, Oba Jesu",
                        "Pelu irelẹ l'awa wa (lati) yin Baba l'ogo",
                        "Jesu Kristi Oba Ife.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "68",
            Title = "ẸMI O LỌ SIBI PEPE",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Ẹmi O lo sibi pepe lati rubo s'Ọlọrun",
                "Nibe lati nf'ebo da majemu f'Ọlọrun",
                "Oluwa nbọ lati wẹ ẹse mi nu",
                "Oun l'amona mi.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "E gbo eyin eniyan t'e nrubo s'Ọlọrun",
                        "Ọlọrun mbọ, pẹlu imolẹ Rẹ,",
                        "E mura silẹ, Jesu imolẹ mbo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "E gbo eyin eniyan t'e nwole Ọlọrun",
                        "Ọlọrun yoo fi ewe hisopu le omi wọn yin",
                        "E mura silẹ Oba Igbala ti de.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "E gbo eyin eniyan t'e nrubo s'Ọlọrun",
                        "Ọlọrun mbọ pẹl'ayo igbala Re",
                        "E mura silẹ lati gb'ẹmi Ominira.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "E gbo eyin eniyan t'e nwole Ọlọrun",
                        "Ebo Misa nirobinujẹ okan",
                        "E mura silẹ ki e maa se rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "E gbo eyin eniyan t'ẹ nrubo s'Ọlọrun",
                        "Ọmọ Ọlọrun gba mi lowo ẹbi eṣe",
                        "E mura silẹ, Jesu igbala ti de.",
                        "Ọmọ Ọlọrun yi elẹṣe l'okan pada. Yi i l'okan pada",
                        "K'a jo rubo lori i pẹpẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "69",
            Title = "WE WA MỌ",
            Category = "ORIN IFITORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "We wa mo o, Baba",
                "Ranti ileri Rẹ o",
                "Gbore ti a ru si Ọ",
                "Lori pẹpẹ mimo Re.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gborẹ tí a ru si Ọ",
                        "Lori pẹpẹ mimo Re",
                        "F'omi ti o mo gara wẹ wa o",
                        "We wa kuro ninu ese wa o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gborẹ ti a ru si Ọ",
                        "Lori pẹpẹ mimo Re",
                        "Ọlọrun ri pe o dara",
                        "O mu ki ile o hu oko.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gb'ore ti a ru si O",
                        "At'eyi t'Alufaa ru si O,",
                        "Gb'ore gbogbo wa o,",
                        "Nitori ẹbọ a jọ ru ni.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbore ti a ru si Ọ",
                        "Lori pẹpẹ mimo Rẹ",
                        "Mase 'binu s'awọn eniyan Re",
                        "Re 'binu re sile o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gb'orẹ ti a ru si Ọ",
                        "Lori pẹpẹ mimo Re",
                        "Dari ese wa ji wa Baba",
                        "K'a le f'ogo fun oruko Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "70",
            Title = "BABA MIMỌ, OLUBUKUN NI IWỌ",
            Category = "ORIN IFITORE",
            Author = "Ẹgbẹ Akọrin Ijẹbu-Ode",
            Chorus = new List<string>
            {
                "Baba Mimọ, Olubukun ni Iwọ,",
                "Gb'ọrẹ at'inu wa wa",
                "Ọdọ Rẹ l'o ti wa",
                "Iwọ l'a o maa yin titi aiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Akara ni 'yi, ti a fi tọrẹ fun Ọ",
                        "Ni ọwọ Rẹ, ni o ti wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Akara naa, jẹ k'o d'ohun jijẹ",
                        "Fun igbala awa ọmọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọti ni 'yi, ti a fi tore fun O",
                        "Ni ọwọ Rẹ ni o ti wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba tirẹ ni nwọn,",
                        "A f'akara yi tọrẹ fun Ọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba tirẹ ni nwọn,",
                        "A fọti yi tọre ̣fun Ọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọti naa, jẹ k'o d'ohun mimu",
                        "Fun igbala ati iye wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "71",
            Title = "OO RE JESU SI MI PỌ",
            Category = "KOMUNIONI",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oore Jesu simi o pọ, o pọ jọjọ (2ce)",
                        "Kini Ẹmi yio fi san fun un o",
                        "Oore Jesu si mi o pọ, o pọ jọjọ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ki ni Ẹmi yio ṣe f'Oluwa (2ce)",
                        "T'o ku fun mi l'ori igi iye",
                        "Ara at'ejẹ Rẹ ninu Kalisi",
                        "Ti mo fẹ gba, ni yio ra mi pada",
                        "Oore nla-nla wo ni eyi o",
                        "Ki ni Ng o fi san pada fun un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ifẹ Jesu simi o pọ, o pọ jọjọ (2ce)",
                        "Ki ni Ẹmi yio fi san fun un o",
                        "Ifẹ Jesu simi o pọ, o pọ jọjọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Otito Jesu simi o pọ, o pọ jọjọ (2ce)",
                        "Ki ni Ẹmi yio fi san fun un o",
                        "Otitọ simi o pọ, o pọ jọjọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Aanu Jesu simi o pọ fun ẹṣẹ mi (2ce)",
                        "Ọba adarijini ni Oluwa o,",
                        "Aanu Jesu simi o pọ fun ẹṣẹ mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "72",
            Title = "ỌBA MIMỌ",
            Category = "KOMUNIONI",
            Author = "P. A. Fragoso",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọba Mimọ, Ọba Alafia, Imọle Ailopin",
                        "Ti sọkale s'ori Pepe Mimọ wa,",
                        "Ọba t'o wa s'aiye lati ra wa pada",
                        "Nipa di d'eniyan lati wa ba wa gbe.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Kabiyesi Ọba, E wọle fun Jesu",
                        "Ninu Sakramenti Mimo ti igbala wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Orin Mimọ ni k'a fi yin In l'ogo, a wolẹ",
                        "A ki Ọ, Jesu to wa s'ori Pepe Mimọ wa",
                        "Ọkan mi ti mura lati pade Rẹ,",
                        "Jọwọ wa s'ọdọ mi, Olugbala Rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọba toto, Ọlọrun Ọbangiji, Igbẹkẹle",
                        "Ẹlẹsẹ, okan mi nfa lati sun mọ O ̣ni tootọ,",
                        "Ọmọ Rẹ Jesu ti f'Ara Re fun wa,",
                        "Ninu Sakramenti ti Igbala wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin Ara, e wa sun mo mi wo,",
                        "Mo npe yin s'ounjẹ",
                        "Ounjẹ iye, orisun iwa rere;",
                        "Awa ti gba Ọ gbọ, Ọmọ Ọga Ogo,",
                        "Ife nla ailopin, Olugbala wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimọ, Ọmọ alaise, pelu 'dapọ-ṣọkan",
                        "Mẹta-lọkan ni Ng o ma yin l'ogo,",
                        "Ipin tẸmi dara, mo l'ohun ti ko ṣe gbe sọnu",
                        "Mo ṣi'ju wo Oluwa, Olugbala mi ni.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "73",
            Title = "OLUWA PE WA SIBI ASE",
            Category = "KOMUNIONI",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ifẹ Oluwa pe wa si ibi ase",
                "Onjẹ ẹmi to t'ọrun wa,",
                "Ng o jẹ tẸmi ki nle ye",
                "Ye lọ titi d'ọrun rere.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹnyin eniyan ẹ ta kiji",
                        "Ẹ mura lati gb'Ara Oluwa",
                        "Ko sẹni to dabi Oluwa",
                        "Ẹ wa gba Jesu Ọba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ifẹ ni Jesu fi npe wa",
                        "Sibi Ogo t'ọrun rere",
                        "K'a yara mura lododo",
                        "Lati gba Jesu sinu wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ko s'ohun na to tun dabi",
                        "Onjẹ iye t'ọkan wa",
                        "To mu wa duro gbọingbọin",
                        "Ti Jesu Kristi Ọba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onjẹ ẹmi at'ọrun wa",
                        "Ọdọ Agutan Ọmọ Ọlọrun",
                        "A wolẹ fun Ọ Oluwa wa",
                        "Awimayehun Ọba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Wa wo wa san Ọba Mimọ",
                        "Bi a ba gba Ọ s'ọkan wa",
                        "Lọwọ esu ọta wa",
                        "Da wa nide l'ọjọ gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ṣ'oore fun wa Ọba Ọlọla",
                        "Bi a ti gba Ọ s'ọkan wa",
                        "To wa s'ọna dele wa",
                        "Fun wa l'ayọ l'ọrun rere.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "74",
    Title = "IFE L'ỌLỌRUN",
    Category = "KOMUNIONI",
    Author = "Alufaa T. M. Ilesanmi",
    Chorus = new List<string>
    {
        "Ifẹ l'Ọlọrun ẹ jẹ ka fifẹ gbe",
        "K'a ṣiṣẹ rere k'a wa ba le ghade ogo",
        "Ifẹ si Baba, ife si Ọmọ",
        "Ifẹ si Ẹmi Mimọ, ifẹ si ẹnikeji",
        "Ife l'Ọlọrun.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹni mimọ ni Baba",
                "K'a fi'fẹ sin Baba",
                "Iwa mimọ l'o ye wa",
                "K'a f'iwa jọ Baba",
                "K'a wa ba le gb'ade ogo.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹni ba nṣe rere",
                "K'o mura si rere iṣe",
                "Ẹni ba nhuwa ẹsẹ",
                "K'o lo yiwa pada",
                "K'a wa ba le gb'ade ogo.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ire ti iṣe ti wa",
                "Baba l'o fi fun wa",
                "Ifẹ lo ye wa o",
                "Ifẹ Olodumare",
                "K'a wa ba le gb'ade ogo.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ẹni ba fẹ t'Oluwa",
                "K'o gba'ra Oluwa",
                "Ẹni ba fe t'Olugbala",
                "K'o mu ninu ẹjẹ Rẹ",
                "K'a wa ba le gb'ade ogo.",
            }
        },
    }
},
        new Hymn
        {
            Number = "75",
            Title = "IFE OLUWA NI KA SE",
            Category = "KOMUNIONI",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ife Oluwa ni k'a ṣe nigba gbogbo (2ce)",
                        "Ifẹ Oluwa ko ni lodi rara",
                        "Botiwu-kori l'oju wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ifẹ Oluwa ni wọn nṣe l'ọrun (2ce)",
                        "Awọn Angeli l'o npe ranṣẹ",
                        "Ti wọn si njẹ ẹ bi o ti yẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Enyin ara ẹ ba wa jẹ (2ce)",
                        "Ifẹ Oluwa o dun j'oyin lọ",
                        "Botiwu-kori ninu wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ife Oluwa fun wa, ko ṣe f'ẹnu sọ (2ce)",
                        "Oun na lo mu U f'ẹṃi Rẹ̣ lelẹ",
                        "Fun awa otoṣi ẹlẹbi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ife Oluwa, ope l'oye fun O (2ce)",
                        "Eyi l'awa nfi te O l'ọrun",
                        "B'a ba ti mura lati se ife Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iwọ naa lo ti to fun wa fun ere wa (2ce)",
                        "Awa ki yio padanu rara",
                        "Bi a ba ti rọju ṣe ifẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Awa otoṣi kil'a le ṣe fun 'ra wa (2ce)",
                        "Lati tẹ ifẹ Rẹ l'ọrun",
                        "Jowọ fun wa l'agbara lati se ifẹ Rẹ̣.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Amin. Ase.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "76",
            Title = "ORISUN IYE L'OLUWA",
            Category = "KOMUNIONI",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Orisun iye l'Oluwa",
                "Ibukun ayọ ni mo gba",
                "Oluwa lo fun mi l'akara lat'ọrun wa",
                "O ti f'ounjẹ iye f'ọkan mi.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa ti bukun fun mi",
                        "Onigbagbọ ẹ ba mi yọ",
                        "O ku fun mi, o w'ẹsẹ mi nu",
                        "Mo yi pada mo d'ẹni nla.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a fiyin f'Oluwa",
                        "Onigbagbo ẹ jo ẹ yọ",
                        "Oluwa ti ṣ'ilẹkun ayọ",
                        "Ẹ yi pada, ẹ d'ẹni mimọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa fun 'pe k'a pẹjọ",
                        "Onigbagbọ ẹ jẹ ipe",
                        "Ẹ je k'a mu ninu ejẹ Rẹ",
                        "Ṣinu okan k'a gb'Ara mimo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọjọ nhọ ko duro o",
                        "Ẹ maṣe lọra lati ye",
                        "Oni l'o yẹ k'a pero ayọ",
                        "K'a to'pa Rẹ̣, k'a d'ẹni mimọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Araiye ẹ yọ m'Oluwa",
                        "Ẹ juba f'Ọba to ga ju",
                        "Onibu ọla - l'Ọba l'oke",
                        "Awimayehun l'Ọba Mimọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "77",
            Title = "JESU OLUGBALA MO FẸ GBA'RA RE",
            Category = "KOMUNIONI",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala mo fe gba'ra Rẹ",
                        "Jesu Olugbala mo fe gba'ra Rẹ",
                        "Olugbala wa mu mi ye",
                        "Lati gb'ara Re.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ara at'ejẹ Olugbala t'o kun fun iye ati ogo (2ce)",
                        "Wa bọ ọkan mi pelu ẹjẹ Rẹ iyebiye",
                        "Mẹtalọkan jọwọ wa o sinu ọkan mi",
                        "Ki O si mu mi ye lati ṣe 'fẹ Rẹ",
                        "Olugbala mo ke pe Ọ, wa sinu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala wa sinu okan mi",
                        "Jesu Olugbala wa sinu okan mi",
                        "Olugbala wa mu mi ye",
                        "Lati le se ti Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala mo nkigbe pe Ọ",
                        "Jesu Olugbala mo nkigbe pe Ọ",
                        "Olugbala mo pe Ọo",
                        "Wa gbo igbe mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala to mi si ọna Re",
                        "Jesu Olugbala to mi si ọna Re",
                        "Olugbala wa sun mọ mi",
                        "Ki O s'amona mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala mo - fe tele O",
                        "Jesu Olugbala mo - fe tele Ọ",
                        "Gbogbo awọn iwa Rẹ",
                        "Ni Ng o ma tẹle.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "78",
            Title = "JESU F'ARA RẸ FUN WA",
            Category = "KOMUNIONI",
            Author = "H. A. Ọrẹdipẹ",
            Chorus = new List<string>
            {
                "Oore nla kan ni yi ara (4ce)",
                "Jesu f'ara Re fun wa l'aiye",
                "Oore nla kan ni yi ara",
                "E jẹ k'a rỌmọ Jesu",
                "Oore nla kan ni yi ara.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ara Jesu l'ounje iye",
                        "Eni t'o ba jẹ ko ni ku titi",
                        "Ẹ jẹ k'a tete m'ara wa ye",
                        "K'a le ba wọn je ninu rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Oluwa awa mbẹbẹ",
                        "Maṣe ṣa wa ti n'ile aiye",
                        "Ti a ba si wa ninu ewu",
                        "Ma ṣai ko wa yo ninu rẹ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ ti a kan towo t'ẹsẹ",
                        "Jesu Oluwa awa sadi Ọ",
                        "Nigbakugba ti a ba ke si Ọ",
                        "Da wa l'ohun ki O bukun wa o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a taji loju ọrun",
                        "K'a si f'ohun kan kesi Baba",
                        "K'o ba le gba wa la lọwọ",
                        "Iberu eṣu at'ori kunkun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "K'a ma jẹ k'aiye tan wa jẹ",
                        "Nitori nkan t'o ni lati tan",
                        "Ọla at'ọla ko le gbeni ro",
                        "Nigba t'a o lọ j'ipe Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "79",
            Title = "MU MI YẸ, JESU KRISTI",
            Category = "KOMUNIONI",
            Author = "Mrs. F. A. Ọnasanya",
            Chorus = new List<string>
            {
                "Mu mi yẹ, Jesu Kristi; mu mi yẹ",
                "Lati gba'ra Rẹ",
                "Mu mi ye, Olugbala mu mi yẹ",
                "Lati gba'ra Rẹ",
                "At'ẹjẹ Rẹ iyebiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Ọlọrun mi,",
                        "Wa bọ ọkan mi",
                        "Ki nle yẹ titi aiye",
                        "Ki nle yẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Ọba Ogo",
                        "Wa s'inu ọkan mi",
                        "Ki nle m'ọna titi aiye",
                        "Ki nle m'ọna o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọdọ Agutan Ọlọrun",
                        "Wa s'amọna mi",
                        "Ki nle yọ titi aiye",
                        "Ki nle yọ o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọmọ Ọlọrun ọga ogo",
                        "Wa gbọ igbe mi",
                        "Ki njere ni'le aiye",
                        "Ki njere Ọrun Rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "80",
            Title = "IWO NI MO GB'OKAN MI",
            Category = "KOMUNIONI",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Iwọ ni mo gbokan mi s'oke si Oluwa",
                "Mo gbẹkẹle O, maṣe da mi lara (2ce)",
                "Oluwa je ki nmonra Re, ko mi nipa ona rẹ",
                "Iwọ ni ireti mi, ni gbogbo aiye",
                "Iwọ ni mo gbokan mi s'oke si Oluwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Irẹpọ Oluwa mbẹ f'awọn t'o bọwọ fun U,",
                        "Awọn lo fi Majemu Oluwa han ni gbogbo aiye",
                        "Awọn l'o ṣiṣe Rẹ l'ona pipe Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Imọlẹ Oluwa mbẹ f'awon t'o f'iyin fun U,",
                        "Baba l'o ye k'a sin, k'a foribale, k'a si bọwọ fun U,",
                        "Oun l'o ye ka f'ogo to ju fun ara mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Akoko Oluwa l'o y'ẹ, ka ṣiṣe Ibukun",
                        "Awọn ti nreti ogo asan ti tan kan gbogbo aiye",
                        "Baba l'o ye, ki awa gbẹkẹlẹ, ara mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "81",
            Title = "WA S'INU OKAN MI",
            Category = "KOMUNIONI",
            Author = "Patrick Adeboye",
            Chorus = new List<string>
            {
                "Wa sinu okan mi Oluwa o			) 2ce",
                "Wa sinu okan mi				) 2ce",
                "Mo ti mura silẹ lati gba O sinu,",
                "Wa sinu okan mi",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O ti ṣe'leri wipe ẹnit'o ba je ara Re",
                        "Yio wa titi aiye ainipẹkun",
                        "Mo si gbagbo daju pe otito li oro Re Oluwa",
                        "Mo mbebe Oba Mimo, wa gbe 'nu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O ti ṣe'leri wipe enit'o ba mu ejẹ Rẹ",
                        "Yio wa titi aiye ainipẹkun,",
                        "Mo si gbagbo daju otito li orọ Re Oluwa",
                        "Mo mbẹbẹ Oba Mimo, wa gbe 'nu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O ti se'leri wipe enit'o ba gba orọ Rẹ,",
                        "Yio wa titi aiye ainipẹkun,",
                        "Mo si gbagbo daju otito li oro Re Oluwa",
                        "Mo mbẹbe Ọba Mimo, wa gbe 'nu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O ti ṣe'leri wipe enit'o ba ṣe ifẹ Rẹ,",
                        "Yio wa titi aiye ainipẹkun,",
                        "Mo si gbagbo daju pe otito li oro Re Oluwa,",
                        "Mo mbebẹ Oba Mimo, wa gbe 'nu okan mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "82",
            Title = "ORE ẸLẸSE",
            Category = "KOMUNIONI",
            Author = "Oloye L. A. Owolabı",
            Chorus = new List<string>
            {
                "Ọre ẹlẹsẹ Ọba Mimọ",
                "Ọdọ Agutan Ọlọrun",
                "Oyigiyigi Olodumare",
                "Wa gbọ tiwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Ọmọ",
                        "Alade Alewi lese Omọ Ọlọrun",
                        "Wa gba wa la",
                        "Olodumare ninu ewu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọba oke Ọba Olọla,",
                        "Awimayehun Ọlọrun wa,",
                        "Kọ wa lona t'a wa yio rin",
                        "D'ọrun rẹrẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olodumare Ọba to pe,",
                        "Jesu Kristi Oba Ogo",
                        "Tọ wa s'ona k'a yin Oo,",
                        "Bo ba ti ye.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oyigiyigi Ọba Mimọ",
                        "Onibu-Ọrẹ Alewi-leṣe,",
                        "Wa gba wa la lọwọ idanwo",
                        "L'ọjọ gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọba Ọrun Ọba toto",
                        "Olusẹgun Ajasẹgun",
                        "Da wa lohun a mbẹ o",
                        "Wa gbọ tiwa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ogo f'Ọlọrun Baba Mimọ",
                        "Iyin fỌmọ Rẹ Oluwa wa",
                        "Ẹmi Mimọ Olodumare wa gbọ ti wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "83",
            Title = "WA GBO OLU ỌRUN",
            Category = "KOMUNIONI",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Wa gbo Olu-ọrun se rere fun wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Wa da wa l'ola Ọba Mimo",
                        "K'a f'iwa mimo yẹ Ọ si o",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "K'a se t'Oluwa n'ile aiye",
                        "K'a gb'ade iye l'ode ọrun",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "K'a ma se ribi ni'le aiye",
                        "K'ogun at'ote yara d'opin",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "K'iku ojiji ko ma pa wa",
                        "Tolojo ba de ko ba wa nire",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "K'ile san wa, k'aiye san wa",
                        "Ajakalẹ arun k'o ma ṣe wa o",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "K'a ri jẹ, ri mu ni'le aiye",
                        "K'iwa irele ko je tiwa",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "K'a ṣiṣe l'owo nile aiye",
                        "K'a s'owo jere de 'bi ogo",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "K'a ko 'le mo 'le nile aiye",
                        "K'a t'ona igbala d'ode ọrun",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "K'aboyun ile bimo were",
                        "So awon agan di olọmọ",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Bi a ba ji k'o ba wa ji",
                        "Wa daabo bo wa loju oọrun",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Oba Mimo wa ba wa gbe",
                        "Wa s'amona wa nijo gbogbo",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "B'aiye gb'ogun de ko ba wọn wi",
                        "K'eṣu edena ma se segun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "84",
            Title = "NG O GB'ARA OLUWA",
            Category = "KOMUNIONI",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ng o gb'Ara Oluwa",
                "Ng o mu eje Rẹ",
                "Ng o gb'Ara Oluwa o",
                "K'ogo le je tẸmi.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ara Mimo Rẹ bọ mi Olu-oru",
                        "Ara Mimo Rẹ lo n'iye ainipẹkun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Eje Mimo Rẹ je k'o so mi d'otun",
                        "Ṣe mi lỌmọ o k'ogo le je tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹmi l'Oluwa, mo l'ohun t'o tobi",
                        "Iyi Oluwa mbẹ o lara mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "B'aiye ba gb'ogun de, ba mi ba wọn wi",
                        "Mo sa di O o, dakun gba mi o Baba.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ota t'o gh'ogun nṣe lasan ni",
                        "Aabo Oluwa mbẹ o lodo mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jọwọ Oluwa wa fun mi l'agbara",
                        "Ran mi lowo o, dakun o, gbo tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Baba dakun o, wa da mi l'ola Re",
                        "Ọla Mimo Rẹ lo ga ju lokan mi.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Baba Mimo o,wa se mi l'ogo",
                        "Ogo t'o ga ju je k'o le je tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Iyin opẹ o l'o yẹ Olu-ọrun",
                        "Awimayehun dakun gb'opẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Pe mi lọjọ kan sile Re t'o l'ogo",
                        "Ile Mimo Re ma fi du mi o Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "85",
            Title = "JESU L'OLUWA MI",
            Category = "KOMUNIONI",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu 'wo l'Oluwa mi",
                        "Jesu Ọmọ Ọlọrun",
                        "Jọwọ gbọ ẹbẹ wa o,",
                        "Jesu Jesu gbo adura wa.",
                        "Jesu Iwo ni a fe,",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu a rọ mọ o",
                        "Ma je k'aiye se wa o,",
                        "Jesu Jesu gbo adura wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu Ọmọ Maria",
                        "Baba gbogbo araiye",
                        "Iwọ l'Olugbala, gba wa la",
                        "Jesu gbọ adura wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu t'o ku f'araiye",
                        "Nitori ti ese wa;",
                        "K'a ba le jogun t'ọrun rere",
                        "Jesu gbo adura wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu fe ki gbogbo wa",
                        "Le jogun ọrun rere",
                        "E je k'a ṣiṣe fun 'gbala wa",
                        "Jesu gbo adura wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu mo fe 'gb'Ara rẹ",
                        "Jesu mo fẹ mẹjẹ rẹ",
                        "K'oore ofẹ rẹ po l'okan mi",
                        "Jesu gbo adura wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ọrun rere n'ile wa",
                        "N'ibẹ l'a o ri Baba",
                        "Pelu Ọmọ At'Ẹmi Mimo",
                        "Jesu gbo adura wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "86",
            Title = "WA WE OKAN RẸ",
            Category = "KOMUNIONI",
            Author = "J. Feyiṣitan",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Wa wẹ ọkan rẹ (2ce)",
                        "Jesu mbo f'awọn ẹlẹsẹ",
                        "Wa wẹ ọkan rẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ara mi, wa wẹ ọkan rẹ mọ",
                        "Duro f'Ọlọrun, wa wẹ ọkan re mo",
                        "Fiye-meji sokan soso",
                        "Wa f'ara re f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mura k'o ṣe kan (2ce)",
                        "Ma se 'ye-meji ninu Ọlọrun",
                        "Mura k'o se kan.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa wẹ ọkan rẹ (2ce)",
                        "Yi 'wa pada, d'ọrẹ Jesu",
                        "Wa wẹ ọkan rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa dara pọ mọ (2ce)",
                        "Aye Jesu Oloyin pupo",
                        "Wa darapọ mọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oluwa ni igbala re (2ce)",
                        "Oniṣegun kan ko gbeni leke",
                        "Oluwa ni igbala rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Aiye yi yio d'opin (2ce)",
                        "Aiye Jesu ko ni-pẹkun",
                        "Aiye yi yio d'opin.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "T'o ba se ti igbala ni (2ce)",
                        "Ona eyi wa ninu Jesu",
                        "Ọrẹ mi f'ara han fun un.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ma se beru o (2ce)",
                        "Fi'nu re han f'Oluwa Jesu",
                        "Ma se beru o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "87",
            Title = "KINI MO NI?",
            Category = "KOMUNIONI",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Kini mo ni t'okan mi fi le,",
                "Olugbala Jesu Kristi ni (2ce)",
                "Iberu ko si, bi o ba wa l'okan mi",
                "Ko si s'ewu mo, aiye ko ri mi gbeṣe.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bukun fun wa Baba, t'okan t'okan l'a sin O",
                        "Maṣe j'oju ko ti wa o, ki o saanu wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bukun fun wa Baba, mase f'ese wa bi wa",
                        "Ki l'o fe f'oore ofe Re?",
                        "Bi o s'okan a o fun O.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bukun fun wa Baba, maṣe j'ota ko yo wa",
                        "Eṣu yio ha bori wa? Yara saanu wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bukun fun wa Baba, ki o f'okan wa se'le",
                        "Ki o si m'okan wa ye, se 'bujoko Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "88",
            Title = "ABO RẸ ELEDUMARE",
            Category = "KOMUNIONI",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Aabo Rẹ (2ce)",
                "Aabio Rẹ Eledumare",
                "Ọba Mimọ",
                "Baba ma ṣai fun wa ni aabo Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi a ba ji, bi a ba sun",
                        "Baba ma ṣai fun wa ni aabo Re.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ninu ile, l'oju ona",
                        "Baba .... etc.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi a rin l'osan, bi a rin l'oganjo",
                        "Baba etc.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bi a rin n'ile, bi a fo l'oke",
                        "Baba .... etc.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "L'ori ilẹ, l'ori omi",
                        "Baba .... etc.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ninu ise, ninu faaji",
                        "Baba etc.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Bi a nṣodun, bi a ngb'aawẹ",
                        "Baba.... etc.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ninu iponju, ninu wahala",
                        "Baba.... etc.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Laarin egbe, laarin ogba",
                        "Baba .... etc.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ni 'jo aiye, lehin iku o",
                        "Baba .... etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "89",
            Title = "OLUWA M'OKAN MI YE",
            Category = "KOMUNIONI",
            Author = "Joseph Adégbénlé",
            Chorus = new List<string>
            {
                "Oluwa mi			)",
                "Ọmọ Olodumare		) Oluwa mokan mi ye o",
                "Eni Mimo Ọlọrun	)   \"",
                "Oluwa Jesu Kristi  ) \"",
                "Olugbala araiye	) \"",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa mi, ranti Ọmọ-odo Rẹ",
                        "Mana Mimo l'o fi b'Ọmọ ayanfẹ Rẹ",
                        "F'ounjẹ iye bo wa yo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa mi, t'ẹti s'Ọmọ odo Rẹ",
                        "K'a le gbaiye jogun awọn ibukun Rẹ",
                        "Oluwa ibukun ni Ọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa mi, wa ko gbogbo eniyan jo",
                        "Ma ṣai fun wa l'omi iye ainipẹkun",
                        "Oluwa ibukun ni Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa mi, fun mi l'ara at'ejẹ Rẹ",
                        "Wa ṣe 'toju mi, fun mi n'imo ifẹ rẹ",
                        "Orisun imo ifẹ ni Ọ",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ara ẹ dide, k'a ba ẹni owo lo",
                        "Jesu lo rubo fun wa k'a gba'bukun ọrun",
                        "Oluwa iye lo ni wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Oluwa mi, ṣi 'ju wọmọ odọ Rẹ",
                        "Tin se 'ranti iku ati ajinde",
                        "Oluwa iye ba wa gbe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "90",
            Title = "E WA BA OLUWA JEUN",
            Category = "KOMUNIONI",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ wa j'ounje Iye l'ori pẹpẹ",
                        "Ẹ wa jounje Iye lori pẹpẹ",
                        "Ẹyin onigbagbo t'o mura silẹ fun un",
                        "Ẹ wa j'ounje iye l'ori pepẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Eni ti mba Oluwa jẹ",
                        "Ti o si mba Oluwa mu",
                        "Ko le padanu Olugbala",
                        "Ẹ wa lati jẹ ase Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa mu oti iye l'ori pẹpẹ",
                        "Ẹ wa mu oti iye l'ori pẹpẹ",
                        "Ẹyin onigbagbo to mura silẹ",
                        "Ẹ wa mu oti iye l'ori pẹpẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a gba ara Kristi l'ori-pẹpẹ",
                        "Ẹ jẹ k'a gba ara Kristi l'ori pẹpẹ",
                        "Eyin onigbagbo t'o mura sile fun un",
                        "Ẹ jẹ k'a gba ara Kristi l'ori pẹpẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a mu ẹjẹ Rẹ l'ori pẹpẹ",
                        "Ẹ jẹ k'a mu ẹjẹ Rẹ l'ori pẹpẹ",
                        "Ẹyin onigbagbo t'o mura silẹ fun un",
                        "Ẹ jẹ k'a mu ẹjẹ Rẹ l'ori pẹpẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "O ya lati je ase mimo Ọlọrun",
                        "O ya lati jẹ ase mimo Ọlọrun",
                        "Ẹyin onigbagbo t'o mura silẹ fun un",
                        "O ya lati je ase mimo Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "91",
            Title = "ẸMI Y'O GBA JESU KRISTI",
            Category = "KOMUNIONI",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹmi yio gba Jesu Kristi sinu okan mi (2ce)",
                        "Ẹmi yio gba Jesu Kristi sinu okan mi",
                        "Ẹmi yio gba Jesu Kristi sinu okan mi",
                        "Ẹmi yio gba Jesu Kristi sinu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "Lile:",
                    Lines = new List<string>
                    {
                        "Ounjẹ iye t'o ju yi lọ ko ma si",
                        "Ara at'eje Oba to fe mi ma ni 'yi",
                        "Orisun iye ainipẹkun ma ni yi",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oba Mimo Oluwa mi (2ce)",
                        "Awon to j'akara at'eja ninu iju",
                        "Gbogbo nwọn lo ti ku tan",
                        "Ẹmi yio gb'Ara Re laiṣiyemeji",
                        "Orisun iye l'o jẹ ninu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọba Mimọ Oluwa mi",
                        "Omi iye l'o f'Ọmọbirin Samaria",
                        "T'o gba ohun ti O wi gbọ",
                        "On l'o se tire laiṣiyemeji",
                        "Mo rẹni fiwa jo nipa ṣiṣe tire.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oba Mimo Oluwa mi (2ce)",
                        "Wa ba mi gbe, fona han mi ki nni ayo",
                        "F'ohun rere da mi lola",
                        "Ẹmi yio gb'Ara Re laiṣiyemeji",
                        "Ng o mu Eje Re si inu okan mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọba Mimo Oluwa (2ce)",
                        "Ife pipe iwa mimo ni Ng o ma a hu,",
                        "Nibi gbogbo ti mo ba de",
                        "Ifẹ l'o ga ju lọ nibugbe ikehin",
                        "Orisun iye ni fun wa l'ode ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "92",
            Title = "OPE ARA E YO",
            Category = "KOMUNIONI",
            Author = "Popoola",
            Chorus = new List<string>
            {
                "Ara Oluwa ma re o, ara ẹ gbọ;",
                "Ẹjẹ Oluwa ma re o, ara ẹ gbọ.",
                "Ẹ jẹ k'a f'ori bale fun U",
                "T'ebi t'ara.",
                "Ọpẹ l'o y'Olodumare.",
                "Ọpẹ, Ọpẹ Ọpẹ, ara ẹ yọ",
                "E ̣yin Baba l'oke",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹmi se tan o, mo fe gb'Ara Oluwa",
                        "Ẹmi ṣe tan o, mo fẹ mu Ẹjẹ Rẹ",
                        "Ẹmi ṣe tan lati j'Ara Oluwa",
                        "Jesu Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ara ẹ dide, e lo s'ori pepe",
                        "Ara ẹ dide, e lo pade Ayo",
                        "E lo je ounje Ẹmi at'ọrun wa",
                        "Olugbala Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Igba yi ni ara mi le",
                        "Igba yi ni okan mi bale",
                        "Igba yi ni mo d'ajagun Jesu Ọlọrun",
                        "Oyigiyigi Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Oluwa, wa gbe inu mi",
                        "Jesu Oluwa, jẹ ngbe inu Re",
                        "Ṣeṣe l'Ọmọde yo m'eiye",
                        "Jesu mo yọ mọ O.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "E ba mi jo, mo d'eni ola",
                        "E ba mi jo, mo d'eni ola",
                        "Ẹmi jẹ ounje iye, mo s'orire",
                        "Kristi Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ara e dupẹ, a ti j'Ara Oluwa",
                        "Ara e dupe, a ti m'Eje Re",
                        "Awa ti d'ara kan nisisiyi",
                        "Ninu Jesu, Oba toto",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "93",
            Title = "NG O LO GВА ТЕМІ",
            Category = "KOMUNIONI",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Ng o lo gba tẸmi) 4ce",
                "Ara Jesu t'o wa lori pepe",
                "Ng o lo gba tẸmi",
                "Sare o, eje Jesu npe o o,",
                "Lo gba tire.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Kilo di mi lona ) 4ce",
                        "Ara Jesu ye lati gba, ng o lo gba tẹmi",
                        "Sare o, Ẹmi Oluwa npe o o, lo gba tire.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Wa we okan mi) 4ce",
                        "Ara Jesu ti ko l'abawon, wa we okan mi",
                        "L'aiye o, eleṣe kan ko le ye laisi 're Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo we wo we okan mi) 2ce",
                        "Nigba ti mo gb'ara Jesu, mo nreti iye Re",
                        "L'aiye o, eleṣe kan ko le ye laisi 're Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba wa ọrun) 2ce",
                        "Ọmọ re Jesu l'a ti kan mo'gi tori ese wa",
                        "L'aiye o, elese kan ko le ye laisi 're Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "O ti m'okan mi le) 4ce",
                        "Ara Jesu ti m'okan mi le, o so mi d'ajagun",
                        "L'aiye o, elese kan ko le ye laisi 're Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "94",
            Title = "ODUN CORPUS CHRISTI\nMO FORI BALE F'OBA OGO",
            Category = "KOMUNIONI",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo f'oribale f'Oba ogo (2ce)",
                        "Eni Ola ye la nf'ola fun",
                        "Mo f'oribale f'Oba ogo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oba aiye e f'iyin f'Oba ọrun (2ce)",
                        "Eni Ola ye la nf'ola fun",
                        "Oba aiye e l'iyin f'Oba ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Orisun iye l'Oba ogo (2ce)",
                        "E je k'a mu ninu iye Re",
                        "Orisun iye l'Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onile ayo l'Oba ọrun (2ce)",
                        "Oluwa fun mi l'ayo pipe",
                        "Onile ayo l'Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "E je ki a gbekel'Oba ogo (2ce)",
                        "Ọlọrun nikan l'o m'ila eda",
                        "E je ki a gbekel'Oba ogo.’",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Baba Olodumare l'Ọlọrun mi (2ce)",
                        "Ẹmi o jẹ tẹ ri mi ba f'oriṣa mọ",
                        "Baba Olodumare l'Ọlọrun mi",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Awimayehun l'Oba ọrun (2ce)",
                        "Ileri t'o ṣe fun wa ko le ye",
                        "Awimayehun l'Oba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Orisun imo l'Oba ogo (2ce)",
                        "Arinurode Olumo-okan",
                        "Orisun imo l'Oba ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "95",
            Title = "ORIN IWODE CORPUS CHRISTI",
            Category = "KOMUNIONI",
            Author = "H. A. Ọrẹdipẹ",
            Chorus = new List<string>
            {
                "Olugbala Oba wa",
                "L'o yẹ ki a gbojule",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "L'o ye ki a gbojule o",
                        "l'o ye ki a fehinti",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oun L'Ọlọrun alagbara",
                        "Oun l'angeli ti igbimo pipe",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "E wolẹ f'Oba awon Oba",
                        "Ọmọ Maria Wundia.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Eni keji Mẹtalokan",
                        "Oyigiyigi Oba nla.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Eni ana, eni oni",
                        "Ọlọrun to ma wa titi",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "O ra wa pada lọwọ ibi",
                        "O sọ wa dỌmọ arole",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Araiye e yo e yin Baba",
                        "Oun ni Ọlọrun agbojule",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "E k'eṣu sile e sin Baba",
                        "Tori k'a ma ba segbe titi",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Onisuru alagbara",
                        "Ọlọrun tutu Oba Mimo.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Olurapada ara aiye",
                        "Oba imole l'a f'ori fun",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Oluso rere",
                        "Oniyanu l'awa gbojule",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Jesu Kristi ọrun ododo",
                        "Alaperẹ iwa Mimọ",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Oba Ogo",
                        "Oniteriba Oba aanu",
                        "14. L'o ye ki a gbojule",
                        "L'o ye ki a fehinti.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "96",
            Title = "T'OLUWA L'ẸMI YO SE",
            Category = "KOMUNIONI",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "T'Oluwa l'Ẹmi yoo se (2ce)",
                        "Oun l'Oba t'o da mi,",
                        "Oun l'Oba Olurapada",
                        "Oun l'Oba Onibuore,",
                        "T'Oluwa l'Ẹmi yo se.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ara e yo e juba, (2ce)",
                        "Iba Oba to da wa,",
                        "Iba Oba Olurapada,",
                        "Iba Oba amaiye yeni,",
                        "Ara e yo e juba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ade-ayo Ọlọrun. (2ce)",
                        "Oun ni tonise rere,",
                        "Oun ni t'onirele okan,",
                        "Oun l'a jogun fun wa,",
                        "Ade-ayo Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Atobiju l'Oluwa (2ce)",
                        "Ogo Oba t'o fe wa,",
                        "Ogo Oba Asoromaye,",
                        "Ogo Oba Arinurode.",
                        "Atobiju l'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oruko Ogo Jesu, (2ce)",
                        "Oun l'a fi toju mi",
                        "Oun l'a fi wese mi nu,",
                        "Oun l'a fi taiye ṣe,",
                        "Oruko ogo Jesu.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ile ayo Oluwa (2ce)",
                        "Ibe l'a ti npejo,",
                        "Ibe l'a ti m'ona ayo",
                        "Ibẹ l'a ti kogbon rere",
                        "Ile ayo Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "97",
            Title = "MO DE O, OLUWA",
            Category = "KOMUNIONI",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati gba'ra Re sinu okan mi",
                        "Mo de o, Oluwa lati gba'ra Rẹ sinu okan mi",
                        "Jọwọ Oluwa jare wa ba mi gbe.",
                        "Jesu, Jesu; Iwo l'Oba aiku",
                        "Jesu, Jesu; Iwo l'Oba igbala",
                        "Fun mi n'Igbagbo,",
                        "Ireti ati ifẹni, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ara Re at Eje Re to kun fun igbala",
                        "Ara Re At'Ejẹ Re to kun fun iwosan",
                        "Je ko wo mi san, Jesu wa o; Ọba rere, wa ba mi gbe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati dapọ mọ Ọ ninu ẹbọ",
                        "Mo de o, Oluwa lati dapọ mọ Ọ ninu ẹbọ",
                        "Jọwọ Oluwa jare wa ba mi gbe.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati wolẹ fun Ọ lori pepe (2ce)",
                        "Jọwọ Oluwa jare wa ba mi gbe.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati f'iyin fun Ọ bi o ti yẹ",
                        "Mo de o, Oluwa lati f'iyin fun Ọ bi o ti yẹ",
                        "Jọwọ Oluwa jare wa ba mi gbe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati sẹ'fẹ Rẹ bi o ti paṣe (2ce)",
                        "Jọwọ Oluwa jare wa ba mi'gbe.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Mo de o, Oluwa lati yin Ọ l'ogo fun oore Rẹ",
                        "Mo de o, Oluwa lati yin Ọ l'ogo fun oore Rẹ",
                        "Jọwọ Oluwa jare wa ba mi gbe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "98",
            Title = "ORIN KOMUNIONI",
            Category = "KOMUNIONI",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Jesu, Jesu; Iwo l'orisun ife",
                "Jesu, Jesu; Iwo l'orisun iye",
                "Fun mi l'akara",
                "Ti yoo mu 'gbala wa ba mi Jesu o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; Igbagbo ti ni yi to?",
                        "Jesu, Jesu; Ireti ti ni yi to?",
                        "Fun mi ni 'reti",
                        "Lati le roju Rẹ, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; ọti Rẹ ti dun to?",
                        "Jesu, Jesu; ẹjẹ Rẹ ti dun to?",
                        "Fun mi ni ifẹ",
                        "Lati le sun mọ ọdọ Rẹ, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; Inu mi ti dun to?",
                        "Jesu, Jesu; ayọ mi ti pọ to",
                        "Fun mi ni imọ lati le mọ Ọ",
                        "Bi o ti yẹ, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; Ifẹ Re ti pọ to",
                        "Jesu, Jesu; ogo Rẹ ti pọ to",
                        "Fun mi ni ifẹ",
                        "Lati le fẹni keji mi. Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; ẹbun Rẹ ti pọ to?",
                        "Jesu, Jesu; iyanu Rẹ ti pọ to?",
                        "Fun mi ni ẹbun, lati le gba Ọ",
                        "Bi o ti yẹ, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; ayọ mi yoo tỉ pọ to?",
                        "Jesu, Jesu; ayọ mi yoo ti po to?",
                        "Mu mi yẹ, Jesu",
                        "Ki nle mọ bi ala Rẹ, Jesu o.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Jesu, Jesu; Iwọ ni mo gbẹkẹle",
                        "Jesu, Jesu; Iwọ ni mo f'ẹhinti",
                        "Onigbagbọ f'ẹhinti Jesu",
                        "O duro gbọnin-gbọnin.",
                    }
                },
                
            }
        },
        new Hymn
        {
            Number = "99",
            Title = "AMIN, AMIN, BẸẸNI KO RI",
            Category = "KOMUNIONI",
            Author = "J G. B. Agbara",
            Chorus = new List<string>
            {
                "Amin, Amin; bẹẹni k'ori",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa dabobo awọn ti/Iwo fi Sakaramenti Rẹ bọ",
                        "Kuro ninu ibi ota ti/igbala wọn, Amin.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa jẹ ki awa ti O fi ounjẹ ọrun bọ,",
                        "Le maa daniyan ohun rere nikan,",
                        "Ki a si le ri ohun ti a n-daniyan gba. Amin.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu, jẹ ki Ara at'Ẹjẹ Re ̣oniyebiye",
                        "Le maa fun wa ni itẹlọrun. Amin.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọlọrun Olodumare, jẹ ki Sakaramenti yi",
                        "Fun wa ni itara at'ọrun wa",
                        "Ki a le kọ lati kọ ohun aiye silẹ,",
                        "Ki ọkan wa si fa si ti ọrun. Amin.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọrun Olodumare, jẹ ki ase mimọ Rẹ ti a jẹ,",
                        "Fun wa ni iye titun, ki o mu ẹsẹ wa duro",
                        "Ki o si mu wa yẹ lati ma ri anu Rẹ gba. Amin.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọlọrun Olodumare, jẹ ki Sakaramenti mimọ yi,",
                        "Tun ọkan ati ara wa ṣe, ki a le mọ agbara;",
                        "Ohun ti a mb'ọla fun ninu ẹbọ yi. Amin.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Baba Olodumare jẹ ki Ara Rẹ ti a gba",
                        "Wẹ wa mọ, ki o si da wa pọ mọ Ọ titi lae.Amin.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Baba Olodumare fun awọn ọmọ egbe yi",
                        "Ni ifọkansin at'ọrun wa.",
                        "Mu ẹ̣sẹ wọn duro ki wọn le dapọ mọ Ọ titi lae. Amin.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Jesu jẹ ki ilosiwaju ati irẹpọ le ma wa ninu ẹgbẹ yi,",
                        "Ki wọn si le ma wu Maria Wundia titi lae. Amin.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Oluwa jẹ ki ẹbọ oni le je atewogba l'ọdọ Rẹ,",
                        "Ki bọ na ti an ru le dabi ti Abẹli. Amin.",
                    }
                },
                
            }
        },
        new Hymn
        {
            Number = "100",
            Title = "MIMỌ MIMỌ",
            Category = "KOMUNIONI",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Mimọ Mimọ Mimọ (2ce)",
                "Baba Mimọ aterẹ kaiye",
                "Oyigiyigi Ọlọrun wa",
                "A ko le gbagbe Rẹ titi aiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Kristi ayanfẹ Ọmọ Rẹ",
                        "Iwo ti pe E, O si ti ran si wa",
                        "Lati la oju wa si imọlẹ Rẹ",
                        "Lati kede ominira fun ẹru",
                        "Lati f'ljọba rẹ fun talaka.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba alanu julọ atọpẹ da",
                        "Nitori Jesu Kristi ọmọ Rẹ",
                        "Iwọ ti fi fun wa, O si ba wa gbe;",
                        "O ti fi Ara at 'Ẹmi Rẹ fun wa",
                        "Lai fi nkan pamọ ti n ṣ̣e tirẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ki a to r'erin o d'igbo",
                        "Ki a to r'ẹfọn o d'ọdan",
                        "Ki a to ri Jesu, o d'ibi ase nla",
                        "Ibi ase nla jẹ onjẹ iye",
                        "Jesu l'o ni k'a ṣeyi n'iranti oun.",
                        "(A ko le gbagberẹ titi aye)",
                    }
                },
                
            }
        },
        new Hymn
        {
            Number = "101",
            Title = "MO GBA ORISUN AIYE AINI-PEKUN",
            Category = "KOMUNIONI",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Mo gba Jesu s'ọkan mi",
                "Mo gba orisun aiye ainipekun",
                "Mo gba Olugbala mo gb'ọba ifẹ",
                "Jesu Ọba aanu",
                "Jesu Ọba Olubukun",
                "Jesu Ọba iranlọwọ",
                "Jesu Alabo gbogbo Eda",
                "Mo jere igbagbọ mo r'iye gba",
                "Mo gba Oluwa Jesu s'ọkan (mi)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo gba Jesu s'okan mi",
                        "Mo m'Ejẹ Jesu s'okan mi",
                        "Mo ti wẹ mọ, mo ri iye gba",
                        "Okan mi ti mo toni toni",
                        "Abawọn ẹse ti da ṣaka",
                        "Orule mi di t'Ẹmi Mimo",
                        "Mo jere igbagbo mo ri iye gba",
                        "Mo gba Jesu s'okan mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo gba Jesu s'okan mi",
                        "Mo ri imularada Mo ri iwenumo okan",
                        "Mo ti ba Oluwa gbe po",
                        "Mo d'eniyan Pataki",
                        "Mo jere igbagbo mo ri iye gba",
                        "Mo gba Oluwa Jesu s'okan (mi)",
                    }
                },
                
            }
        },
        new Hymn
        {
            Number = "102",
            Title = "ARA JESU NI NG O JẸ",
            Category = "KOMUNIONI",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ara Jesu ni ng o jẹ",
                "Ẹjẹ Rẹ ni ng o mu",
                "Iye ainipẹkun ni mo nwa",
                "Fọwọ Rẹ wọ mi o Jesu",
                "Ọba Ogo ba mi sẹ o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ara Jesu ti mo fẹ jẹ		)",
                        "On nikan lo fun mi n'iye		) 2ce",
                        "Iye, Iye, iye, ainipẹkun ma ni o",
                        "Oluwa Jesu fun mi n'iye",
                        "F'Ara Rẹ bọ mi yo o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ejẹ Jesu ti mo fẹ mu",
                        "On nikan lo fun mi l'ayọ	(2ce)",
                        "Ayọ, ayọ, ayọ, ainipẹkun ma ni o",
                        "Oluwa Jesu fun mi layọ",
                        "F'Ejẹ Rẹ tun mi da o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oore Jesu ti mo ri gba o		) 2ce",
                        "On nikan lo fun mi n'iyi		) 2ce",
                        "Iyi, iyi, iyi, ainipẹkun ma ni o",
                        "Oluwa Jesu fun mi n'iyi",
                        "F'oore Rẹ ba mi gbe o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa Jesu te. mi l'ọrun",
                        "Iwo nikan ni nfun ni l'ọrọ",
                        "Oro, oro, aidibajẹ ma ni o",
                        "Oluwa Jesu tẹ mi l'ọrun",
                        "Ara Re lo nfun mi lọrọ",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ng o sin Jesu yi ni d'opin",
                        "On nikan lo to mi i gba",
                        "Mo bẹ, mo bẹ; mo bẹ; gbadura mi jare o",
                        "Oluwa Jesu gbe mi leke",
                        "Ọba Ogo ba mi se o.",
                    }
                },
                
            }
        },
        new Hymn
        {
            Number = "103",
            Title = "MU WA DE IBI OGO",
            Category = "KOMUNIONI",
            Author = "R. V. Agbara",
            Chorus = new List<string>
            {
                "K'o mu wa de ibi ogo	) 2ce",
                "Ara Jesu t'a ti gba",
                "K'o mu wa de ibi ogo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "K'a ma r'iku aiyeraiye",
                        "K'a ma ṣe kose sinu eṣe",
                        "Mu wa k'a le maa huwa Re.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ma ṣe f'ebi Ẹmi pa wa",
                        "K'okan wa ma se sun ninu eṣe",
                        "Mu wa k'a le maa huwa Re.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa m'oore ofẹ Re ba wa gbe",
                        "K'esu ma fa wa s'inu ese",
                        "Mu wa k'a le maa huwa Re.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "A be O Oluwa dakun gbọ",
                        "K'a le d'odo Rẹ nigbehin",
                        "K'a wa naa le gba ere wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ma t'ilẹkun iye mo wa lae",
                        "Li ọjọ yẹn to ni 'beru",
                        "Mu wa k'a le simi pẹlu Rẹ.",
                    }
                },
               
            }
        },
        new Hymn
        {
            Number = "104",
            Title = "E DIDE, E MURA LATI JE OUNJE IYE",
            Category = "KOMUNIONI",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo yo, mo b'Oluwa duro (2ce)",
                        "Ẹmi s'ori ire ni temi o, mo gb'Ara Oluwa.",
                        "Mo gb'ohun Oolore to npe mi ki nwa jeun, mo yo,",
                        "Mo ti ṣe tan, Ayo nla kun 'nu mi;",
                        "Nitori pe mo ye lati gb'Ara re o, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Eyin Ijo wa, E dide ẹ sunmo Baba lati jẹ ounje iye tooto,",
                        "Ẹda t'o ba ti gb'Ara Oluwa",
                        "ko ma ni rare.",
                    }
                },
                new Verse
                {
                    Number = "Lile:",
                    Lines = new List<string>
                    {
                        "Mo se tan o Oluwa",

                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Mo yọ.... mo ṣe tan o",
                               }
                },
                new Verse
                {
                 Number = "Lile:",
                    Lines = new List<string>
                    {
                        "Lati j'Ara re mo yo etc.",

                        "Lati m'Eje rẹ .... mo yọ etc.",

                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo yo, mo b'Oluwa jeun; mo yọ, mo s'ori ire",
                        "Ẹda to ba ti gbara Oluwa ko ma ni rare,",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo be O Baba Mimo, lat'oni lọ Oluwa,",
                        "ohun ti yoo di mi l'ona lati gb'Ara Re se,",
                        "Ba mi mu kuro l'ona",
                        "K'aiye mi le toro titi aiye o, Oba Oloore.",
                    }
                },
                new Verse
                {
                 Number = "Lile:",
                    Lines = new List<string>
                    {


                        "Ohun t'o dun bi ounje Oluwa, mi o mariri o (2ce)",
                    }
                },
                 new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ohun to dun bi ounje Oluwa, mi o ma ri i ri o",
                        "Mo faramo Oluwa ni temi o araiye.",
                        "Mo faramo Jesu mi o Oloore (2ce)",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ajọpin ninu Oluwa oun l'o dara, ara.",
                        "Ohun l'o f'iyi pọju. Mu wa yẹ Baba Oolore",
                        "Lati gb'Ara Rẹ.",
                        "A! ẹ gb'Ara Oluwa, ẹyin Ijọ wa. Al ẹ gb'Ara Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "105",
            Title = "OLUGBALA MO DE LATI GBA'RA RẸ",
            Category = "KOMUNIONI",
            Author = "",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olugbala mo de lati gba'ra Rẹ",
                        "Iwọ lo fun mi ni iwosan, Ọdọ Agutan Ọlọrun.",
                        "Ara at Ẹjẹ rẹ mimọ, Oun lo bọ ọkan mi",
                        "Ara at'Ejẹ rẹ mimọ, lo fun mi ni iwosan",
                        "Olugbala wa sinu ọkan mi, mo fẹ gba'ra Rẹ",
                        "Oun lo fun mi ni iwosan, Mẹtalọkan jọwọ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Ọba otito, wa ba mi gbe jọwọ Ọ",
                        "Iwọ lo fun mi ni igbala Olorisun ayọ ni o jẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olugbala mo de, mo fẹ tele Ọ",
                        "Jare wa to mi s'ona iye, mo fe tẹle Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Oba otito, mo fe gba'ra Rẹ",
                        "Iwo lo fun mi ni ayo, Oba onibu ore.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Olugbala mo de lati ṣe'fẹ Re",
                        "Iwo lo fun mi ni iwosan, oore nla wo'le mi o",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala mo dupẹ, Oba Mimo mo ke pe O o.",
                        "Jare wa fun mi ni iye pelu eje Re tooto.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "106",
            Title = "ONJẸ IYE OLOGO",
            Category = "KOMUNIONI",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Eyi l'onje iye Ara at'ejẹ Oluwa (2ce)",
                        "To mbọ ọkan mi, to nfun mi ni iwosan pipe",
                        "Onje iye ni.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Akara mimọ ara at'eje Oluwa (2ce)",
                        "Onje iye ologo ara at'eje Olugbala",
                        "Oun l'ombọ ọkan mi t'o nfun mi ni iwosan",
                        "Iru onjẹ yi o to l'ogo julọ",
                        "Ng o mura lati lọ gba tẸmi",
                        "Onje iye ni.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Eyi ni ara at'ejẹ Jesu Oluwa (2ce)",
                        "T'ombok okan mi t'o nfun mi ni iye ologo",
                        "Onje iye ni.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Eyi n ara Olugbala onjẹ iye ni (2ce)",
                        "Wa bo okan mi, Odo Agutan Ọlọrun",
                        "Mo fe gb'Ara Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jọwọ Oluwa Olugbala, wa sinu okan mi (2ce)",
                        "Jẹ ki ayo Re ki o kun inu okan mi",
                        "Mo mbẹbẹ o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Metalokan Olugbala, to mi si ona Re (2ce)",
                        "Wa sinu okan mi ki O to si ọna Re",
                        "Mo fe gb'ara Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "107",
            Title = "A N JADE LO BABA MIMO",
            Category = "ORIN AKOJADE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ibukun Oluwa ki O maa sin wa lo. A n jade lo,",
                        "Olugbala samona wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "A n jade lo Baba Mimo (2ce)",
                        "Olodumare so wa o Olu Ọrun ye",
                        "A mbẹbẹ s'amọna wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jọwọ so wa ninu ewu ati lọwọ awọn ọta",
                        "Ọbangiji a mbẹbẹ, sọ wa ni ọna wa gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Dan wa lowo Baba Mimo ka le maa fiyin fun Ọ",
                        "Olugbala teti si wa, s'amona wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bi ota tile n yo, awa ko ni beru rara",
                        "Nitori a gbekele O, Olugbala wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Obangiji Oba Mimo, A o maa yo ninu Rẹ",
                        "Jẹ Oluranlọwọ wa, ati imọle wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A o maa yo ninu Re, a o maa yo ninu Rẹ",
                        "Olugbala wa gbo tiwa. Samona wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "108",
            Title = "WA FISO RE SO WA BABA",
            Category = "ORIN AKOJADE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Wa l'iso Re so wa Baba (2ce)",
                "Wa da bobo wa Olodumare",
                "Wa ran wa lowo Baba wa Mimo",
                "Wa f'iso Rẹ sọ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba wa Mimo ope ye Ọ",
                        "Olodumare arinu rode",
                        "Gba wa kuro ninu iku ojiji",
                        "Wa fiso Rẹ sọ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba wa Mimo l'a gbojule",
                        "Olodumare a duro sinṣin",
                        "Da'na ifẹ Re s'okan wa o",
                        "Wa fiso Rẹ sọ wa",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba wa Mimo, Iwọ l'o ni wa",
                        "Olodumare wa gbo tiwa",
                        "Baba wa ṣetoju wa nigba-kugba",
                        "Wa f'iso Rẹ sọ wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "109",
            Title = "AWA DUPẸ",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrn Bodija",
            Chorus = new List<string>
            {
                "Awa dupẹ Awimayehun",
                "Onibu Orẹ Olubukun",
                "Awa dupẹ Olodumare",
                "Oyigiyigi Oba Mimo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A dupẹ oore ana o, Onibu ola a tope da;",
                        "A dupẹ oore ana o,Asoromaye gb'opẹ wa;",
                        "Opẹ l'o ye Ọ, Awimayehun;",
                        "Aṣekanmaku Ọba tọtọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A dupẹ O f'ola fun wa",
                        "O tun da wa si, a tun dupe",
                        "Olori ohun ini wa T'Asoromayẹ Oluwa ni;",
                        "Ope l'o ye Ọ, Awimayehun;",
                        "Aṣekanmaku Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A dupe O f'ayo fun wa",
                        "Aiye gb'ogun de, O b'aiye wi",
                        "A dupẹ O f'ayo fun wa",
                        "O lana ayo O to wa si i;",
                        "Ope l'o ye O, Awimayehun;",
                        "Awimayehun, Oba toto.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Araiye ẹ f'ayo sun moo",
                        "Atobajaiye Amaiyegun",
                        "araiye ẹ f'ayo sun moo",
                        "Olurapada aiye wa;",
                        "Ope l'o ye Ọ., Awimayehun",
                        "Awimayehun, Oba toto.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "110",
            Title = "IGBAGBO DARA O",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrın Osogbo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Igbagbo dara o! E jẹ k'a gb'Ọlọrun gbọ o!",
                        "Eni da wa titi d'ojo oni o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ireti mbẹ o! Bi a ba sin Metalokan",
                        "Ọjọ a darab'o ba dojo ikẹhin.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Anfani mbe o! Bi a ba sise ife ni",
                        "Eni fe 'Lọrun ko ni ṣalai ni o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ifẹ dara ju! Je k'a ṣiṣe ife o",
                        "Eni ba ni iko s'ohun ti ko ni o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "111",
            Title = "B'A TI NRE'LE",
            Category = "ORIN AKOJADE",
            Author = "Oloye S. O. Ajala",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "B'a ti nre'le o, l'awa mbẹ O o.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Baba o, jọwọ bukun wa o; Baba o; jọwọ bukun wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awa tun be O o, f'ori jin wa o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jọwọ jẹ k'ore Ofe Re da s'ori wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "B'a ti nre'le o, l'awa nṣope o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awa tun sope o, fun ifẹ re si wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "B'a ti nre'le o, k'a tun pade o.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "K'awa tun pade o pel'ayo sẹ o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "112",
            Title = "ẸMI YIO MA YỌ NINU RẸ",
            Category = "ORIN AKOJADE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Ẹmi yio maa yọ ninu Rẹ (2ce)",
                "Ni ojo aiye mi",
                "Mo gbẹkẹ le Ọ",
                "N o yin Ọ l'ogo",
                "Mo kigbe si O",
                "Ba mi gbe Oluwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olugbala mo ba o duro 					)",
                        "Ẹmi yio maa yo ninu Rẹ ni ojo aiye mi		) 2ce",
                        "Olugbala mo jo, mo yo / Ẹmi yio ma yọ nínu Re",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹmi yio maa yọ ninu Rẹ (2ce)",
                        "Ni ojo aiye mi",
                        "Mo gbẹkẹ le Ọ",
                        "N o yin Ọ l'ogo",
                        "Mo kigbe si O",
                        "Ba mi gbe Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olugbala mo mo wipe",
                        "Iwo yio kun okan mi fun ayo bi O ti ṣe'leri",
                        "Olugbala mo kun f'ayo,",
                        "Ẹmi yio maa yo ninu Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olugbala mo ṣe'leri",
                        "Ẹmi yio maa rin ni ọna Rẹ ni igba gbogbo",
                        "Olugbala awimayehun,",
                        "Ẹmi yio maa yọ ninu Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "113",
            Title = "ṢE WA L'OLODODO",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrin Ondo",
            Chorus = new List<string>
            {
                "Ọba Mimọ, Ọba iye (2ce)",
                "Ṣe wa l'olodọdọ nile aiye O, Ọba ogo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ere si'se wa, to wa s'ona Rẹ",
                        "Fun wa lagbara N'ile aiye o, Ọba ogo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oba Mimo, Oba iye; (2ce)",
                        "Gba wa lowo ota ile aiye o, Ọba ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fiso rẹ so wa, ka le je ti Rẹ;",
                        "Fun wa n'imo nile Rẹ o, Ọba ogo,",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun wa, s'amona wa",
                        "Mu wa de bi iye, n'ile Rẹ o; Ọba ogo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbọ ti wa Oluwa, so Ẹmi wa",
                        "Gba wa sinu agbo mimo Re o. Ọba ogo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun wa, gbo adura wa",
                        "Mu wa de ibi ogo n'ile Rẹ o, ọba ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "114",
            Title = "ENU WA YIO SI MA SỌ IYIN RE",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrin Ondo",
            Chorus = new List<string>
            {
                "Enu wa yio si ma a so iyin Rẹ titi lae.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa Iwo yio ṣi wa l'ete.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa wa ran wa lọwọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa Yara lati ran wa lọwọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Je ki oju ki o ti awọn ọta wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Je ki a le je ti Re titi aiye.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Je ki a mo anfani wiwa Re.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Gba wa lowo ikẹkun awọn ode.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Je ki a le wu Maria Wundia.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Fi ibukun Re s'ori iṣe wa.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Gbo adura wa Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Wa gb'ẹbo oni Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Je k'a ma f'ope fun O nigba gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "115",
            Title = "OJU MI TI R'IGBALA",
            Category = "ORIN AKOJADE",
            Author = "Ẹgḅẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Oju mi ti r'igbala",
                "Ibu ayo ni t'Ẹmi.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oju mi ti r'igbala,",
                        "Ibu ayo ni t'Ẹmi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nigba yi Oluwa,",
                        "O jọwọ ọmọ-ọdọ rẹ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ni alaafia, gẹgẹbi",
                        "orọ rẹ",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oju mi ti r'igbala,",
                        "Ti o ti sẹ'leri.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Imole t'o mole,",
                        "Si gbogbo keferi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ogo Israeli,",
                        "Ayo eniyan rẹ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Mo yọ mọ Oluwa,",
                        "Ibu ayọ ni t'Ẹmi.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Igbala mi ti de,",
                        "E ba mi yo sẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ibukun ti mo gba,",
                        "Ko tile nipekun.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Bi mo ba ti le ku,",
                        "Ile ayo n'ile mi.",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Bi aiye ba pare,",
                        "Ayo ko nipẹkun.",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Gbogbo eda aiye,",
                        "E jo, e yo sese",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Gbogbo eda ọrun,",
                        "E ba mi f'ife jo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "116",
            Title = "IGBAGBỌ YE WA",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrin Ondo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Igbagbo ye wa o		)",
                        "A dupẹ o, a tun dupe		) 2ce",
                        "Baba fun wa ni igbagbo si i",
                        "Igbagbo ye wa o A dupe o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ireti yẹ wa o			)",
                        "A dupẹ o, a tun dupe		) 2ce",
                        "Baba fun wa ni",
                        "Ireti si i Ireti ye wa o,",
                        "A dupẹ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ifẹ ye wa o			)",
                        "A dupẹ o, a tun dupe		) 2ce",
                        "Baba fun wa, ni ife si i",
                        "Ife ye wa o, A dupẹ o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "117",
            Title = "SIN WA DE'LE ỌlỌRUN",
            Category = "ORIN AKOJADE",
            Author = "Ẹgbẹ Akọrin Oke Padi",
            Chorus = new List<string>
            {
                "Sin wa dele, Ọlọrun sin wa dele o",
                "Sin wa dele, Ọlọrun Edumare",
                "Dakun Baba rere sin wa lo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ajodun odun yi ti pari.",
                        "Ope ye O o Ọlọrun wa",
                        "Sin wa dele, Ọlọrun o",
                        "Ma a sin wa lo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "F'ibukun Re so-ri-wa.",
                        "A nke pe O Ọlọrun wa",
                        "Ma a sin wa lọ.",
                        "Ran wa lowo Ọlọrun o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọpọ ibukun Re la ntọrọ,",
                        "Baba mimọ jọwọ da wa lohun,",
                        "Jọwọ wa, wa gbọ Ọ-lọrun o.",
                        "Ma a sin wa lọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwoyi amodun ka pejo,",
                        "Baba mimo o a mbẹbẹ",
                        "Baba tẹti ko gbo wa o,",
                        "Ma a sin wa lo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwoyi amodun ka pejo",
                        "K'awọn ota maṣe ri wa gbe se",
                        "Baba wa gbo ka maṣe f'ewon",
                        "Logba, jọwọ o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iwoyi amodun ka wa sopẹ.",
                        "Fun wa ni igbega lona ara",
                        "jọwọ wa gbo Ọlọrun ara",
                        "jọwọ wa gbo Ọlọrun o,",
                        "Mase gbagbe wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Iwoyi amodun ka pejo;",
                        "Da wa lohun loriṣiriṣi ona",
                        "Baba wa gho Ọlọrun o,",
                        "Ma a sin wa lo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "118",
            Title = "Ẹ KỌRIN IYIN SI ỌlỌRUN",
            Category = "ORIN AKOJADE",
            Author = "Egbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "E korin iyin si Ọlọrun",
                "Eyin Olododo",
                "E dupe lowo Olodumre",
                "Oba onibu-ore.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Idupe la fi fun O Baba",
                        "F'ebun t'a gba ninu Misa oni",
                        "Wa ba gbogbo wa gbe d'opin",
                        "Pelu ayo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Idupe l'a fi fun O Baba",
                        "Fun 'ye t'a gba ninu Misa oni",
                        "T'o fun gbogbo wa l'agbara",
                        "Pelu ola.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Idupe l'a fi fun O Baba",
                        "Fun 'mọ ayo ninu Misa oni",
                        "T'o ko gbogbo wa l'ogbọn Re",
                        "Baba a yo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Idupe l'a fi fun O Baba",
                        "F'onje iye ninu Misa oni",
                        "T'o mu gbogbo wa sun mọ ọ",
                        "T'ife t'ayo.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "119",
    Title = "KI L'O MBA YIN LERU",
    Category = "ORIN AKOJADE",
    Author = "J. B. Ojo",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ki l'o mba yin leru",
                "Iberu ko si ninu okan mi",
                "Mo ni Jesu lehin.",
                "Iberu ko si ninu okan mi.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "(a) Baba ni'le, Baba l'oko",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba iponju mi",
                "Iwo ni a gb'oju le",
                "Aabo nigba iponju mi",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ki l'o mba yin leru",
                "Ifoya ko si ninu okan mi",
                "Mo ni Baba lehin",
                "Ifoya ko si ninu okan mi.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "(a) Olugbala l'Oluwa",
                "Aabo nigba iponju mi.",
                "(b) Iwo ni afẹhinti",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Tani Olupese",
                "Jesu nikan l'Olupese",
                "Aabo nigba iponju mi.",
                "Ko ma s'elomiran",
                "Jesu nikan l'Olupese",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "(a) Iwo l'Oba Olupese",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba iponju mi.",
                "(b) Wa pese fun wa",
                "Aabo nigba iponju mi.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Nibo nile ayo",
                "Bikose odo Baba nikan",
                "Jare mu mi de 'be",
                "Olugbala l'Ọlọrun mi",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "(a) Iwọ l'oba tỉ ngba ni",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba iponju",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Ogbigba ti ngbara adugbo",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba iponju mi",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Oluwa wa Jesu",
                "Iwo loba ti o ga julo",
                "Pelu ohun ayo o",
                "Mo kigbe pe Ọo Baba",
            }
        },
    }
},
        new Hymn
        {
            Number = "120",
            Title = "OPE, OLODUMARE OPE",
            Category = "ORIN AKOJADE",
            Author = "Joseph Adégbénlé",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Opẹ, Olodumare, ope (2ce)",
                        "A dupẹ o, Baba",
                        "A gb'ara Oluwa",
                        "At'ejẹ Oluwa",
                        "Ninu Misa wa oni",
                        "A gba 'bukun Olodumare",
                        "A t'ope da,",
                        "Ope, Olodumare, ope.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ope, Olodumare, ope",
                        "A dupẹ o, Baba",
                        "A ranti Oluwa",
                        "Ati ijiya Oluwa",
                        "Ninu Misa wa oni",
                        "Eyi l'o fun wa l'ayo rẹ",
                        "A topẹ da, Opẹ, Olodumare, ope.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ope, Olodumare; ope",
                        "A dupe o, Baba",
                        "O f'ohun rere fun wa",
                        "O f'iwa rere fun wa Nipa Misa wa oni",
                        "A gba 'bukun Jesu Kristi",
                        "A t'ope da,",
                        "Ope, Olodumare; ope.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "(L'asiko odun Ibi Jesu)",
                        "Ope, Olodumare, ope",
                        "A dupẹ o, Baba",
                        "O f'Ọmọ rere fun wa",
                        "O f'Ona rere fun wa",
                        "Ninu odun ayo yi",
                        "A figbagbo w'oju Re wo",
                        "A t'ope da,",
                        "Ope, Olodumare; ope.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "121",
    Title = "Ẹ KỌRIN IYIN Ẹ YIN BABA",
    Category = "ORIN AKOJADE",
    Author = "Ẹgbẹ Akọrin Bodija",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "Idahun:",
            Lines = new List<string>
            {
                "Ẹnyin orilẹ ede gbogbo",
                "Ẹ kọrin iyin ẹ yin Baba",
            }
        },
        new Verse
        {
            Number = "Ẹsẹ Orin:",
            Lines = new List<string>
            {
                "Ọba t'o ga ju t'o da wa si )",
                "Onile ayo l'a fiyin fun. ) 2ce",
                "Oun nikan ma l'Ọba ẹda )",
                "Ẹ ho iho ayọ pipe )2ce",
            }
        },
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "O da wa o mu wa wa laaye",
                "O f'owo fỌmọ da wa lola\n",
                "Ọba t'o wẹ ẹse wa nu",
                "Ọba t'o mu wa l'ara da.\n",
                "Ọba t'o fi ejẹ ra wa pada",
                "Oun l'o fẹ wa d'oju iku\n",
                "Ohun rere t'o yi wa ka",
                "L'o fi kẹ gbogbo awa ẹda\n",
                "O yẹ k'a dupẹ o-ore ana",
                "K'Ọba mimo le ni aiye ye wa\n",
                "Ogo fun Baba ati Ọmọ",
                "Ogo fun Ẹmi Olutunu\n",
                "Bi o ti wa ni ibẹrẹ",
                "Ẹ yin Baba titi aiye-raiye.",
            }
        },
    }
},
        new Hymn
        {
            Number = "122",
            Title = "JESU MBỌ WA S'AIYE",
            Category = "ORIN WIWA OLUWA",
            Author = "Patrick Adeboye",
            Chorus = new List<string>
            {
                "Jesu mbo k'a mura silẹ.",
                "Jesu mbọ wa s'aiye",
                "Ẹnyin araiye e mura silẹ o",
                "Jesu mbọ wa s'aiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ ronu-piwa-da gbogbo ijọ",
                        "Lati pade Oluwa",
                        "Ẹ sẹ'fẹ Ọlọrun gbogbo agbaiye",
                        "Lati le r'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ ṣiṣe igbala gbogbo ijọ",
                        "Lati pade Oluwa",
                        "Ẹ ṣeyi ẹ dakun, gbogbo agbaiye",
                        "Lati le r'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ ronu igbala Oba ogo",
                        "Lati ihin lọ s'Ọrun",
                        "Ẹ̣sẹ'fẹ Ọlọrun gbogbo agbaiye",
                        "Lati le r'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ lo jẹwọ ẹsẹ gbogbo",
                        "Lati pade Oluwa",
                        "Ẹ s'ẹyi, e dakun gbogbo agbaiye",
                        "Lati le r'Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "123",
            Title = "MAA BỌ ỌMO ỌlỌRUN",
            Category = "ORIN WIWA OLUWA",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Maa bọ Ọmọ Ọlọrun (2ce)",
                "Iwo l'Olugbala,",
                "Olugbala ara aiye",
                "Maa bọ mọ Ọlọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa nreti,",
                        "Gbogbo aiye lo nreti,",
                        "Reti Olugbala,",
                        "Olugbala,Iwọ Ọmọ Ọlọrun;",
                        "Jọwọ mu 'gbala wa si aiye.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awa nke pe O,",
                        "Gbogbo aiye lo nkepe O,",
                        "Pe Olugbala,",
                        "Olugbala, Iwọ Ọmọ Ọlọrun;",
                        "Jọwọ mu 'gbala wa si aiye.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awa ti se O,",
                        "Gbogbo aiye lo ti se Ọ,",
                        "Ṣẹ Ọ Olugbala",
                        "Olugbala, Iwọ Ọmọ Ọlọrun;",
                        "Jọwọ mu 'gbala wa si aiye.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Lorukọ Ọlọrun Baba,",
                        "Iwọ Ọlọrun Ọmọ,",
                        "Pelu Ẹmi Mimọ,",
                        "Olugbala, Iwo Ọmọ Ọlọrun;",
                        "Jọwọ mu 'gbala wa si aiye.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "124",
            Title = "OLUWA MBỌ",
            Category = "ORIN WIWA OLUWA",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Oluwa mbo, (2ce)",
                "Ẹ jẹ k'a mu okan wa yo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Ọmọ Ọlọrun",
                        "Eniti Baba ti bi ṣiwaju",
                        "Ibẹrẹ aiye gbogbo mbọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọdọ Agutan Ọlọrun",
                        "Eni t'o ko ẹsẹ aiye lọ mhọ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọmọ Ọlọrun Eniti",
                        "Labẹ aworan akara ati ọti waini: ti di onjẹ ẹmi wa mbọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Ẹran Ẹbọ",
                        "Eni t'o mu igbala wa fun wa mbọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "125",
            Title = "ỌJỌ ỌSẸ KETA NI WIWA OLUWA",
            Category = "ORIN WIWA OLUWA",
            Author = "Oloye J. F. Odunjon",
            Chorus = new List<string>
            {
                "E maa yo ninu Oluwa ni igba gbogbo",
                "Mo tun wipe e maa yọ (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ki iwa pelẹ nyin di mimọ fun gbogbo eniyan",
                        "Wiwa Oluwa ku si dẹdẹ, ẹ maa yọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "E ma ṣe ṣe aniyan nipa ohunkohun",
                        "Sugbon nipa adura ati ẹbẹ, pelu idupẹ",
                        "Ẹ maa fi ibeere nyin han fun Oluwa",
                        "Ni ohun gbogbo, mo tun wipe ẹ maa yo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa Iwo ti bukun fun Ile Re",
                        "Iwo ti gba Jakobu kuro ni oko eru.",
                        "Mo tun wipe e maa yo",
                        "(Ogo ni fun Baba etc.)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "126",
            Title = "ARA Ẹ YỌ",
            Category = "ORIN WIWA OLUWA",
            Author = "Jerome Oja",
            Chorus = new List<string>
            {
                "Ara ẹ yọ, ki ẹ ma yọ",
                "Ninu Oluwa Ọlọrun",
                "Nigba gbogbo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa mbẹ nitosi",
                        "Ẹ̣p'ara yin mọ de Oluwa",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ ma ṣe ṣ'aniyan ohunkohun,",
                        "E f'ibere yin han f'Ọlọrun",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Yi wa l’ọkan pada Oluwa,",
                        "Kuro ni ona ibinu Rẹ,",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fun wa n'iye Re Ọlọrun,",
                        "Ki gbogbo aiye f'iyin fun Ọ",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "F'anu Rẹ han wa Oluwa,",
                        "Ki o si fun wa ni'gbala Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Otito ododo anu Rẹ,",
                        "Alafia Rẹ ko jẹ tiwa,",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "F'ohun 're ji wa Oluwa",
                        "Fun wa ni ọpọ ikore rere,",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Fi ododo Rẹ siwaju wa,",
                        "Ki o le jẹ amọna fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "127",
            Title = "KERESIMESI ARAIYE Ẹ YỌ, A BI JESU",
            Category = "ORIN WIWA OLUWA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Araiye ẹ yo, araiye ẹ yọ (2ce)",
                        "A bi Jesu fun wa, ẹ jọ ẹ yọ",
                    }
                },
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "\t\t\tLile: 		 Egbe:",
                        "Ọba Alade Ọba Ogo. (2ce)	Olugbala ti de (2ce)",
                        "Ọmọ Ọlọrun Ọga Ogo	Olugbala ti de",
                        "Olurapada wa		Olugbala ti de",
                        "Araiye ẹ ho ẹ yọ	Olugbala ti de",
                    }
                },
                new Verse
                {
                    Number = "Gbogbo:",
                    Lines = new List<string>
                    {
                        "Gbogbo agbaiye ẹ wolẹ f'Ọmọ titun o",
                        "A bi Jesu fun wa; ẹ jọ, ẹ yọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Kaabọ, Kaabọ (2ce)",
                        "Omọ Ọlọrun Ọga Ogo Kaabọ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Araiye ẹ yọ, e foribale (2ce)",
                        "F'Ọba Alade Ọba Ogo Jesu.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "128",
            Title = "E LU AGOGO",
            Category = "ORIN WIWA OLUWA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Ẹ lu agogo, ẹ lu agogo",
                "Ẹ lu agogo",
                "Keresimesi, ẹ lu agogo",
                "Ẹ lu agogo Olugbala de o,",
                "E lu agogo",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awọn Oluso-Agutan",
                        "Nwọn nạo ẹran wọn",
                        "Imọlẹ yi wọn ka",
                        "Nwọn ni ki lo de kẹ,",
                        "Aṣe Olugbala l'abi",
                        "Olugbala wa k'abọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Irawọ kan yọ loju ọrun",
                        "Si awọn Ọba mẹta",
                        "Awọn angẹli nkọrin loke o",
                        "P'Olugbala ti de",
                        "Olugbala wa k'abọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹni to jẹ Ọlọrun,",
                        "L'a bi s'ibuje 'ran.",
                        "Eyi l'ẹkọ Pataki",
                        "Fun 'rẹlẹ araiye",
                        "Olugbala wa k'abọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ ṣọpẹ fun Baba",
                        "Ẹ ṣọpẹ fun Ọmọ",
                        "Ẹ ṣọpẹ fun Ẹmi Mimọ",
                        "Fun 'gbala wa t'o de",
                        "Olugbala wa k'abọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "129",
            Title = "Ẹ HỌ Ọ, Ẹ HỌ IHO AYO",
            Category = "ORIN WIWA OLUWA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin orile ede, ọyin orilẹ ede; ẹ ho o )",
                        "Ẹ ho iho ayọ, a bi Olugbala fun wa.  )2ce",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "A-Ẹ ho o, ẹ ho iho ayọ; a bi Olugbala fun wa",
                        "B-Ẹ ho o,	         -do-",
                        "A-Ẹ maa yọ Olurapada ti de",
                        "B-Ẹ maa yọ a bi Olugbala fun wa.",
                        "A-Ẹ maa yọ Oludande ti de",
                        "B- Ẹ maa yọ a bi Olugbala fun wa.",
                        "A-Ẹ ho o, e ho iho ayọ.",
                    }
                },
                new Verse
                {
                    Number = "Gbogbo:",
                    Lines = new List<string>
                    {
                        "A bi Olugbala fun wa",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹyin orilẹ ede, ẹyin orilẹ ede; ẹ jo o",
                        "Kiẹ si maa yọ a bi Olugbala fun wa (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹyin Angẹli, eyin Angeli; a de o",
                        "lati ba nyin yọ t'abi Olugbala Ọba (2ce)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin orile ede, eyin orilẹ ede;",
                        "Ẹ ho o, ki ẹ si da muso; t'abi Olugbala fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "130",
            Title = "Ẹ WA BA WA JO",
            Category = "ORIN WIWA OLUWA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ wa ba wa jo",
                        "Ẹ wa ba wa yo",
                        "Ẹ wa k'a ṣopẹ o",
                        "A bi Jesu Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Imole aiyeraiye,",
                        "O yọ, O yọ si wa O",
                        "Ẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa wo 'se Ọlọrun",
                        "Ẹ wa wo oju ọrun",
                        "A bi Jesu Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A bi Oluwa l'oru",
                        "A b'Oluwa n'ibujẹ",
                        "Ẹ wolẹ f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo r'Ọmọ Ọlọrun",
                        "Mo tun w'oju Ọrun",
                        "Mo r'Angẹli Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo ṣ'igun mo ṣ'ẹgun",
                        "Mo tun d'ọdun oni o",
                        "Mo dupẹ o Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹ wa yin Baba l'ogo",
                        "Ẹ wa yin Jesu l’Ọba",
                        "A bi Ọmọ Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹ wa ba wa jo",
                        "Ẹ wa ba wa yọ",
                        "Ẹ wa k'a ṣ'ọpẹ o",
                        "A bi Jesu Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "131",
            Title = "Ẹ MAA WOLẸ FUN OLUGBALA",
            Category = "ORIN WIWA OLUWA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin ara ẹ yọ, ẹyin ara ẹ yọ",
                        "Ẹ maa wolẹ, Jesu Kristi ti a bi si ibujẹ ẹran",
                        "Ẹ maa wolẹ fun Un. (2ce)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹ maa wolẹ fun Olugbala (2ce)",
                        "Ọba Alade Ọba lye",
                        "Ọba otitọ Olurapada",
                        "Jesu Kristi ti a bi",
                        "Ẹ jẹ ka f'oore wa han",
                        "Olugbala wa ti de",
                        "Ẹ maa kọrin aleluya",
                        "Keresimesi ọdun ti de",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹyin ara ẹ yọ, ẹyin ara ẹ yọ; e maa kunlẹ",
                        "Olugbala ti a bi si ibujẹ eran, e maa kunlẹ fun Un. (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹyin ara ẹ yọ, eyin ara ẹ yọ, ẹ maa wolẹ",
                        "Olugbala ti a bi sibujẹ eran Oba irelẹ ni (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "132",
            Title = "Ẹ MA A BỌ KEWA JUBA RẸ",
            Category = "ORIN WIWA OLUWA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Ẹ ma a bọ, ẹ ma a bọ, ẹ maa bọ, kẹ wa juba Rẹ.",
                "Oni l'abi Ọmọ Ọlọrun ti a ti nreti o",
                "Igbala wa ti de loni o, Ọmọ Ọlọrun",
                "Ẹ ma bộ kẹ wa juba Re.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gbogbo eniyan ẹ ma a gbọ o (2ce)",
                        "Eyi n'ileri ti Baba se fun gbogbo aiye o",
                        "Igbala wa ti de l'oni o, Ọmọ Ọlọrun",
                        "Ẹ ma a bọ k'e wa juba Re.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gbogbo eniyan ẹ ma a gbo o (2ce)",
                        "Angeli Gabrieli l'o jise fun Maria",
                        "Osu mẹsan l'ẹhin eyi l'a bi Jesu Ọmọ Ọlọrun",
                        "Ẹ ma a bọ kẹ wa juba Rẹ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gbogbo eniyan e ma a gbo o. (2ce)",
                        "Irawọ kan yọ loju ọrun si awọn Ọba meta",
                        "Olugbala l'a bi fun wa o, Ọmọ Ọlọrun",
                        "Ẹ ma a bọ kẹ wa juba Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "133",
            Title = "KABỌ OLUGBALA",
            Category = "ORIN WIWA OLUWA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Kabo Olugbala de (2ce)",
                "Jesu Kristi Oba",
                "A ti bi n'ibujẹ-eran",
                "Olugbala de.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Kabọ Olugbala de",
                        "A ti bi Olugbala",
                        "Ẹ wo ti a f'oja we",
                        "Olugbala de.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Kabọ, Olugbala de",
                        "Jesu Kristi Ọba",
                        "A bi pelu irele,",
                        "O wa fun 'gbala wa",
                        "Olugbala de.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Kabọ, Olugbala de",
                        "A ti b'Ọmọ Ọlo.run",
                        "B'o ti wa bi eniyan",
                        "L'o tun wa bi Ọlọrun",
                        "Olugbala de.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Kabọ, Olugbala de",
                        "Awọn Oluso Agutan",
                        "Nibi wọn gbe nso'ran",
                        "Imọlẹ tan yi wọn ka",
                        "Olugbala de.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Kabọ, Olugbala de",
                        "Awọn Ọ-ba meta",
                        "Irawo kan yo si wọn",
                        "Wọn si to de 'buje-eran",
                        "Olugbala de.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Kabọ, Olugbala de",
                        "Ogo f'Ọlọrun Baba",
                        "Ogo f'Ọloṛun Ọmọ",
                        "Ogo fun Ẹmi Mimọ",
                        "L'awọn Angeli nkọ",
                        "L'ọke ọrun, Olugbala de.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "134",
            Title = "KERESIMESI DE",
            Category = "ORIN WIWA OLUWA",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Keresimesi de, Keresimesi de",
                "Ọdun alayọ, ọdun orire;",
                "Ẹ wa ka yin Jesu Ọga Ogo. (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Araiye ẹ wa o, e wa k'ọmọ titun",
                        "Messia Olugbala. Ọmọ bibi inu",
                        "Baba Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa ka yin Jesu, ẹ wa yin ọmọ titun",
                        "Olupese Atobiju, ẹ wa ka yin Jesu",
                        "Ọga Ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Maria ti l'ayọ, Maria ṣ'ori ire",
                        "O bi Jesu Kristi Oludande wa",
                        "Ẹ ku abọ Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Araiye ẹ ho ye! araiye ẹ kọrin",
                        "A ti bi Messia Oluwa ti de o",
                        "Saarin wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iba Jesu Kristi, iba Oloore wa",
                        "Iba Emmanueli, iba lo yẹ Jesu",
                        "Ọga Ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "135",
            Title = "ONI L'ABI JESU OLUWA",
            Category = "ORIN WIWA OLUWA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Oni l'abi Jesu Oluwa (2ce)",
                "Gbogbo eda e yo sese",
                "Ire nla l'o wo'le aiye o",
                "Oni l'abi Jesu Oluwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọdun de ire wo'le de",
                        "Ọdun de, ọdun ayọ",
                        "Ọba ọrun ti sọkalẹ wa",
                        "Ẹ jẹ k'a f'ayo gb'Ọba to de.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọdun de, ọdun olọwọ",
                        "Ọdun de ọdun olọmọ o",
                        "Ogun ọrun fun pe a si gbọ",
                        "Keresimesi ọdun de.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Adupẹ t'Oluwa t'o de",
                        "A dupẹ, ifẹ t'o fihan",
                        "A dupẹ, Baba f'ori ji wa",
                        "A dupẹ, ayo wa t'o kun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọdun de, ara ẹ dupẹ",
                        "Ọdun de, ẹ jọ ẹ yọ",
                        "Ire oni t'o s'oju Ẹmi",
                        "Ọdun de, ẹ yọ, e ̣dupẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A dupẹ, Oluṣọlape",
                        "A dupe, Olu fun-wa-layọ",
                        "Olu ba wa ṣẹgun ota",
                        "Olori ayọ l'Ọba to de.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "136",
            Title = "OLUGBALA TI DE O",
            Category = "ORIN WIWA OLUWA",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ẹ jo, ẹ jo, ẹ jo;",
                "Ẹ yo, ẹ yo, ẹ yo;",
                "Ibanuje ti d'ayọ ire wọle de",
                "Oluwa ti de o Mesiah o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olugbala ti de o, ẹ yo ara wa gbogbo",
                        "O mu're wa, o tun ma'yọ, o fifun wa o;",
                        "Oba mimo Ọmọ Baba o",
                        "Oluwa ti de Mesiah o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olugbala ti de o, aiye di titun",
                        "O mẹ́yẹ wa, o pẹsẹ re, o da'wa lare o",
                        "Oju ma ti t'eṣu, eni egbe o",
                        "Oluwa ti de Mesiah o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Araiye ẹ jo, ẹ yo, ẹ wa yin Baba",
                        "T'o fun wa l'Olugbala Awimayehun",
                        "Ẹ jo, ẹ jo, ẹ yin Baba o",
                        "T'o fun wa lỌmọ Re Mesiah o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Araiye ẹ jẹ ka yọ, ka f'ọpẹ fun Baba",
                        "T'o da wa l'eniyan, t'o tun ṣe'wa lỌmọ o, Ọpẹ, ọpẹ l'o yẹ Baba o.",
                        "To fun wa lọmọ Rẹ Mesiah o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "137",
            Title = "JESU TI DE",
            Category = "ORIN WIWA OLUWA",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Jesu ti de, Jesu ti de, Olugbala ti de, okunkun ese bila.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa ti de, O de fun igbala wa,",
                        "O de lati s'atunṣe, Okunkun ẹṣẹ bila.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọmọ Ọlọrun ti de, O de fun ilaja wa,",
                        "O de lati s'atunse, okunkun ẹṣẹ bila,",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oorun ododo ti de, O de fun imole wa,",
                        "O de lati s'atunse, okunkun ẹṣẹ bila.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwaosan ti de, O de fun ilera wa,",
                        "O de lati wo wa san, Okunkun ẹṣẹ bila.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oludande ti de, O de f'ominira wa,",
                        "O de lati ra wa pada, Okunkun ẹṣẹ bila",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Olufẹ rere ti de, O de fun ifẹ wa,",
                        "O de lati fifẹ han, Okunkun ẹṣẹ bila.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Oluṣọ rere ti de, O de fun alaafia wa,",
                        "O de lati ṣakoso, Okunkun ẹṣẹ bila.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọlọrun wa ti de, O de fun ibọwọ wa,",
                        "O de lati gbawa la, Okunkun ẹsẹ bila.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "138",
            Title = "IYA JESU KRISTI",
            Category = "ORIN WIWA OLUWA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Ẹ jo.....Ẹ ba wa jo",
                "Ẹ yọ.....Ẹ ba wa yọ",
                "Ẹ kọrin ogo s'Olugbala araiye",
                "Ogo ni f'Ọlọrun l'oke.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya Jesu Kristi, ẹ ku ori ire",
                        "Oluto Jesu Kristi, ẹ ku orire",
                        "Ẹ ku ewu irin ajo, Ọmọ Ọlọrun",
                        "Ogo ni f'Ọlọrun l'oke.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ayanfe Jesu Kristi, e ku ori-ire",
                        "Gbogbo ẹda Olodumare ẹ ku ori-ire",
                        "Ẹ ki Ọba igbala, ẹ bọla fun un",
                        "Ogo ni f'Ọlọrun l'oke.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ibukun Olodumare, l'Ọba fi fun wa",
                        "Ẹgbẹrun ọpe at'iyin l'a o fi san fun Un",
                        "Ọmọ Ọlọrun Edumare l'a bi fun wa",
                        "Ogo ni f'Ọlọrun l'oke.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọjọ mo gbọ 'pe ayọ ọdun oloyin",
                        "Mo si kigbe l'ohun ayẹ, mo ki Oluwa",
                        "A ti bi Olugbala Ọmọ Ọlọrun",
                        "Ogo ni f'Ọlọrun l'ọke.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "139",
            Title = "A BA Ọ YO",
            Category = "ORIN WIWA OLUWA",
            Author = "J. Feyisitan",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A ba o yo, o ku ewu (2ce)",
                        "Iya Maria o,",
                        "A ba ọ yọ, o ku ewu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A ba o yo, o ku ewu (2ce)",
                        "Baba Joseph o,",
                        "A ba ọ yọ, o ku ewu.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ba ọ yọ, o ku ewu (2ce)",
                        "Ewu ona jin jin o,",
                        "A ba ọ yọ, o ku ewu.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "A ba ọ yọ, o ku ewu (2ce)",
                        "Iya Maria o,",
                        "A ba ọ yọ, o ku ewu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A ba ọ yọ, o ku ewu (2ce)",
                        "Ewu otutu o,",
                        "A ba ọ yọ, o ku ewu.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "140",
            Title = "ARAIYE Ẹ MAA YỌ",
            Category = "ORIN WIWA OLUWA",
            Author = "",
            Chorus = new List<string>
            {
                "Araiye ẹ maa yo/Gbogbo agbaiye ẹ maa yọ",
                "A ti b'Olugbala fun wa",
                "Gbogbo araiye ẹ maa yọ o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ori're ni t'araiye, araiye ẹ ku ewu",
                        "Olugbala wa de o/ araiye ẹ ku ewu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ife ogo, ati'yin at'opẹ/lo ye k'a fi f'Ọlọrun Oba",
                        "Olugbala wa de o/araiye ẹ ku ewu.",
                        "Maria Mimo a ba Ọ yo, a s'ope/Josefu, o ku ewu o",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ewu ina ki pa'wodi/araiye ẹ ku ewu.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "141",
            Title = "ARAIYE Ẹ YỌ",
            Category = "ORIN WIWA OLUWA",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Araiye ẹ yo ẹ korin ogo,",
                        "Onigbagbo k'orin ogo f'Oba to ga ju,",
                        "Olugbala wa ti a ti nreti o de loni o,",
                        "Ẹ ho iho ayọ ẹ damuso Ọmọ Ọlọrun d'eniyan lati gba wa la.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ara e wa gbo a ti bi Jesu s'aiye,",
                        "Dide ẹ tẹti, a ti bi Jesu s'aiye.",
                        "A ti bi Jesu (4ce)",
                        "Ara ẹ wa gbo a ti bi Jesu s'aiye,",
                        "Dide, ẹ tẹti, a ti bi Jesu s'aiye.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn Angeli nkorin l'oke ọrun,",
                        "Ogun ọrun jumo ngberin ayo yi",
                        "Orin wọn dun, o dun ladunju,",
                        "Yungba yungba yungba yungba, l'eti ẹda o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ogo f'Ọlọrun l'ọke ọrun ati l'aiye",
                        "Alaafia f'awọn eniyan to ni ifẹ inu rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awọn oluṣo agutan ti nd'eran ni papa,",
                        "Wọn gb'orin ayọ yi,",
                        "Won ri ami 'yanu ogo Ọlọrun han si wọn,",
                        "Imọlẹ ọrun ndari wọn.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Amoye meta lati ona jijin rere ri ogo Ọlọrun,",
                        "Wọn dide wọn wa ta O",
                        "mọ Ọlọrun l'ore,",
                        "Wura, Turari ati Ojia."
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹ gbohun didun s'oke o (2ce)",
                        "S'Oluwa oloore",
                        "To f'Ọmọ Rẹ kansoso ji wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "142",
            Title = "OLUGBALA DE",
            Category = "ORIN WIWA OLUWA",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "O ti de, O ti de",
                "Olugbala ti de, O ti de,",
                "Oba aiyeraiye, O ti de,",
                "Imole aiye,",
                "Idile Josefu, e ku araya",
                "Idile Maria; 'ku afojuba",
                "Olugbala ti de; O ti de;",
                "Imolẹ aiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọmọ tỉ a bi o, Ọlọrun ni iṣe,",
                        "Olugbala ni Oba aiyeraiye,",
                        "Ẹ gbọ (4ce) awọn angẹli nkọrin ogo,",
                        "S'Ọlọrun Ọba ogo,",
                        "Ọlọrun lo sokalẹ bi eniyan.",
                        "T'o wa ba wa gbe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ara e mura k'a lo s'ibujeran,",
                        "Ni Bethlehemu o, ka lọ yẹ Oba si,",
                        "E wa, (4ce) e tara ṣaṣa k'a lo,",
                        "K'a wolẹ f'Oba ogo,",
                        "Oluwa lo tanmọlẹ lat'oke s'aiye oṣi yi i.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Lati odun jojo wa, lati nreti Rẹ,",
                        "Messiah o, Oba aiyeraiye,",
                        "E jo (4ce) ẹ yọ sẹsẹ",
                        "E damuso f'Oba iyanu",
                        "Baba wa l'oke to seleri ayo, mu ileri ṣẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "E ku abo o (2ce) Ọmọ Jesse",
                        "Ẹ ku abọ o (2ce) Ọmọ Dafidi",
                        "Ẹ ku abọ o (2ce) Ọba aiyeraiye,",
                        "Ẹ ku abọ o (2ce) Imolẹ aiye",
                        "Ọmọ Ọlọrun l'oke to wa gba wa la o",
                        "Ẹ ku abọ o",
                        "Ẹ maa wolẹ fun Un (2ce)",
                        "Ara, ẹ wolẹ f'Ọba, ẹ b'ọla fun Un",
                        "Ọba onirẹlẹ l'Ọlọrun fun wa,",
                        "Ẹ jẹ ka sọpẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "143",
            Title = "O TI DE OLUGBALA DE ",
            Category = "ORIN WIWA OLUWA",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "O ti de, Olugbala de",
                "A bi'mọ kan Ọmọ Ọlọrun.",
                "Maria o O ku ewu,",
                "Josefu o O ku ewu,",
                "A ba ẹ yo, Maria a ba ẹ yo,",
                "A ba ẹ yo, Josefu a ba ẹ yo,",
                "Aleluya f'Oba ogo,",
                "Olugbala wole de.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A dupẹ a t'ope da f'Olu ọrun",
                        "Ẹniti a ti nreti ti de o,",
                        "Fun gbogbo wa,",
                        "Jesu o sẹun kabọ ẹni rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A dupẹ a t'opẹ da, Maria o ku ewu",
                        "Ọlọrun l'o ṣiji bo ẹ o",
                        "O loyun Ọmọkunrin",
                        "Nipa Ẹmi mimọ",
                        "O bi Olugbala fun wa o",
                        "Ka-bọ Ọmọ Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ti gbo asotele Rẹ ri",
                        "L'enu awọn Woli Ọlọrun",
                        "Itanna iye yo'ju si ta o",
                        "O nta roro",
                        "Ka bọ Ọba rere",
                        "Olugbala aiye gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Imọlẹ kan yi ọrun ka,",
                        "Nigbati a bi Oluwa",
                        "Angeli Ọlọrun yo'ju l'ojiji",
                        "S'awọn Oluṣọ (Agutan) rere",
                        "O sọrọ fun wọn pe",
                        "A ti bi Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awọn oba Amoye mẹta kan, Won sare to Jesu wa",
                        "Irawọ kan yọju loju ọrun, won tele kiakia",
                        "Lati f'oribale f'Oluwa Olugbala araiye",
                        "Wọn ba Jesu ni Bethlehemu nibuje'ran.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A dupẹ a tọpẹ da, A ki ọ Maria o",
                        "O kun fun ore ofe",
                        "Ẹni ti ati nreti lọdọ rẹ",
                        "O de fun wa",
                        "Jesu Ọba Ogo",
                        "Kabọ Eni rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "144",
            Title = "GBOGBO AGBAIYE Ẹ WOLẸ",
            Category = "ORIN WIWA OLUWA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Gbogbo agbaiye e wole, e wolẹ,",
                "Ọmọ Ọlọrun Olugbala ti de, ẹ wolẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "E wolẹ f'Oba otito, Olurapada araiye Ọmọ Ọlọrun",
                        "Jesu ti a bi sibuje-eran.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "E wolẹ f'Ọmọ Ọlọrun, Gbogbo agbaiye, e je ka foribale fun Un",
                        "ọmọ Ọlọrun ọga ogo, kaabọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "E je ka foribalẹ fun Un, O ti w s'aiye lati ra wa pada",
                        "E wa juba f'Omọ Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọba otito a ki Ọ- kaabo, Oludande araiye Ọba ogo",
                        "Jesu a wa foribale fun Ọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbogbo agbaiye ẹ yo sese, e yo, E wa foribalẹ fỌmọ titun",
                        "Jesu ti a bi sibuje-eran.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọmọ Ọlọrun - Oga ogo, oludande araiye a ma ki o,",
                        "Jesu, Ọmọ Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "145",
            Title = "ỌDUN TUNTUN",
            Category = "ORIN WIWA OLUWA",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Adupẹ o Oluwa (2ce)",
                "F'opolopo oore Rẹ ti a ti ri gba,",
                "A dupẹ o Oluwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ni odun to koja,",
                        "Gbogbo wa bẹbẹ lodo Re (2ce)",
                        "Ki a le la odun tuntun ja.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Opolopo lo ti ku, lo ti lọ (2ce)",
                        "Ṣugbon o wu ola nla Rẹ",
                        "Lati da wa si.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Opolopo ni ewu ti a ti la koja laifarapa (2ce)",
                        "Nitori o wu agbara Rẹ",
                        "Lati ko wa yo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Odun titun ti de leẹkan si (2ce)",
                        "Gbogbo wa mbẹbe lodo Re,",
                        "Ki a le la odun titun ja.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Niwoyi amodun,",
                        "Ki a le tun wa dupẹ (2ce)",
                        "Pe o seun Oba ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "146",
            Title = "ORIN IWOLE (WEDNESDAY EERU)",
            Category = "ORIN IGBA AWE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {

            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Fiti si wa Oluwa nitori aanu Re ailopin.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Nipa Ọmọ Re, Ọlọrun gba wa la o.",
                        "Fi oju rere wo wa gegebi opo aanu Rẹ",
                        "Oluwa gba mi la nitori omi ibanujẹ bo mi mole",
                        "Ọlọrun ran mi lọwọ nitori iponju ba okan mi.",
                        "Ogo ni fun Baba, fun Omọ; fun Ẹmi-mimo",
                        "Bi o ti wa ni bere aiye, beeni nigbayi; lae ati laelae.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "147",
            Title = "DARIJI NI EDUMARE",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Dariji ni Edumare (2ce)",
                        "A ke pe Ọ o Olu-ọrun",
                        "Dariji ni Edumare.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun wa Edumare (2ce)",
                        "Mu wa larada Olu-ọrun",
                        "Ṣaanu fun wa Edumare.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa gio ti wa Olugbala (2ce)",
                        "A wa sadi O olu-ọrun",
                        "Wa gbọ ti wa Olugbala.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "F'ona han wa Oba oke (2ce)",
                        "Ṣ'amona wa lọjọ gbogbo",
                        "F'ona han wa Ọba oke.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "F'ibukun fun wa Edumare (2ce)",
                        "Ibukun re l'awa nfẹ",
                        "F'ibukun fun wa Edumare.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Fi sọ rẹ sọ wa Edumare (2ce)",
                        "B'aiye gbogun de, fa wa mo 'ra",
                        "Fi 'sọ rẹ sọ wa Edumare.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "148",
            Title = "OLUWA NI ASALA MI",
            Category = "ORIN IGBA AWE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Oluwa ni asala mi",
                "Ọlọrun ni agbara mi",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olu ẹda Ọmọ araiye",
                        "Olupese gbogbo ẹda.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹmi yio woju Olu",
                        "Ọlọrun ni Alaabo mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi otileje pe mo salai-ni",
                        "Ọrọ mi po niwaju Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awọn ota nṣe ruke-rudo",
                        "Ṣugbọn iṣẹ wọn ko de 'bikan niwaju Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ota ngan mi nile aiye",
                        "Ṣugbọn Olu ntu mi ninu jọjọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "149",
            Title = "GBA AGBELEBU RẸ",
            Category = "ORIN IGBA AWE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Gba 'gbelebu rẹ, ma roju (2ce)",
                "Iwuwo rẹ fo ọ laiya ni?",
                "Tirẹ ni Kristi, at'ọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu, mo gbe agbelebu mi",
                        "Otoṣi ni mi, b'ohun ini mi s'egbe",
                        "TẸmi ni Kristi at'ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Eniti o ru agbelebu",
                        "Ma se gbe silẹ titi iku",
                        "Tirẹ ni Kristi, at'ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Eda le ma wahala mi",
                        "Yio mu mi sun mọ ọ ni",
                        "TẸmi ni Kristi, at'ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ko aiye silẹ, sora re",
                        "Bi o ba fẹ sọmọ ẹhin mi",
                        "Si ma-a fi 'rẹlẹ tẹle mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Kini ero ọkan mi",
                        "Kini ero ọkan rẹ",
                        "A fi bi a ba b'Olugbala jinde",
                        "Ki a le gb'ade ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "150",
            Title = "JESU KU TORI MI",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Jesu ku tori mi",
                "O jiya nitori mi",
                "O f'ẹjẹ Rẹ ra mi pada",
                "O sẹ o, O sẹ o Baba ọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹjẹ Jesu lo mu mi ye",
                        "O da mi lọla",
                        "Ireti ọrun iba sọnu",
                        "Baba Mimọ seun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya Jesu to tobi ju",
                        "Lo gbe wa duro",
                        "Ẹsu dọdẹ rẹ a tanù",
                        "Baba Mimọ seun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iku Jesu lo mu wa la,",
                        "O niye lori,",
                        "Ade Ogo iba sonu",
                        "Baba Mimọ ṣeun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ese aiye po, o legbin ju",
                        "O nfa iku wa",
                        "Ọga Ogo ti ra aiye pada.",
                        "Baba Mimọ ṣeun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọdọ Jesu lo to ka wà",
                        "Ka gba're to pe",
                        "Awimayẹhun wa sọ wa ye",
                        "Baba Mimọ sẹun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "151",
            Title = "OLUWA MO BẸ Ọ",
            Category = "ORIN IGBA AWE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Oluwa mo be O (2ce)",
                "Wa poro ese ninu okan mi",
                "Tori elese ki yio lo laijiya",
                "Maṣe je ki npofo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa, maṣe gbagbe wa",
                        "Iwo ti joba lori aiye",
                        "Wa f'oro to dara si mi l'enu",
                        "K'oro mi le dara loju Oba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa, mase gbagbe wa",
                        "Iwo ti joba lori aiye",
                        "Wa f'aso to dara si mi l'ara",
                        "Kaso mi le dara l'oju Oba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa, mase gbagbe wa",
                        "Iwo ti joba lori aiye",
                        "Wa f'ounje to dara si mi lenu",
                        "Ki okan mi le yo l'oju Oba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa, mase gbagbe wa",
                        "Ẹmi yoo j'akara Ọlọrun mi",
                        "Ẹmi yoo mu waini ọrun pelu (oti rẹ pelu)",
                        "Ni'hin ng o gba idariji ẹṣẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "152",
            Title = "OSE KERIN NI IGBA AWE",
            Category = "ORIN IGBA AWE",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹmi o rele Oluwa, pelu ayo o",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nitori ile Oluwa ni",
                        "Ẹmi yio gbero rere si i.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nitori awon eniyan mi",
                        "Ki alaafia Rẹ jẹ tiwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo fi suru duro ṣinṣin",
                        "Gbo adura Ọmọ odo Re.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fun mi ni dera Oluwa",
                        "Fi otito Re han fun mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ogo ni fun Baba ati fun Ọmọ",
                        "Ogo ni fum Ẹmi-Mimo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Latete kọse nisisiyi",
                        "Titi aiye ailopin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "153",
            Title = "ỌSẸ TI MARIWO",
            Category = "ORIN IGBA AWE",
            Author = "J. A. Kuforiji",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Hosanna f'Ọmọ Dafidi,",
                        "Hasanna k'a f'iyin fun Un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Hosanna f'Ọba Israeli,",
                        "Hosanna k'a f'iyin fun un.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Hosanna f'ẹni ti nbọ,",
                        "Hosanna k'a f'iyin fun un.",
                    }
                },
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Alufaa fi omi mimo won mariwo, o si fi lurari bukun fun won. Lehinnaa o pin eka mariwo fun awon eniyan bi o si ti nse eyi, a o ko:",
                    }
                },
                new Verse
                {
                    Number = "Orin 1.",
                    Lines = new List<string>
                    {
                        "Awọn ọmọ Heberu ti o gbe ẹka igi olifi lowo",
                        "Pade Oluwa lona,",
                        "Won nkigbe wipe Hosanna fun O loke ọrun.",
                    }
                },
                new Verse
                {
                    Number = "Orin 2.",
                    Lines = new List<string>
                    {
                        "Awọn Ọmọ Heberu, tẹ aso wọn sona wọn si nkigbe pe",
                        "Hosanna fun Ọmọ Dafidi, ibukun ni fun eni t'ombo ni oruko Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "154",
            Title = "ỌDUN TI MARIWO",
            Category = "ORIN IGBA AWE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ọ-lọrun mi, Ọlọrun mi ṣi-ju wo ọmọ ọdọ Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O-luwa wa ran mi lọwọ",
                        "Ma si se jina simi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gba mi kuro lenu kiniun.",
                        "Fiyesi lati da-bobo mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gba mi lowo agbanrere",
                        "Wo iwa irele mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbogbo enyin to nberu Oluwa",
                        "Gbogbo nyin ẹ wa yin I logo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Nwọn yio ma soro O-luwa",
                        "Fun iran ti o nbo wa o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọrun yio si ma rohin ododo",
                        "Fun awọn eniyan Re.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "155",
            Title = "JESU KRISTI OLOLA",
            Category = "ORIN IGBA AWE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Ọlọla, ka kọrin iyin fun Un",
                        "F'Ọmọ Ọlọrun t'o bẹ wa wo, ka kọrin iyin fun Un",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Hosanna l'oke ọrun (4ce)",
                        "F'Ọmọ Dafidi t'o bẹ wa wo",
                        "K'a korin iyin fun Un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olugbala araiye, k'a kọrin iyin fun Un.",
                        "Olufẹ otitọ t'o bẹ wa wo.",
                        "K'a korin iyin fun Un.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọmọ Dafidi Alade, k'a kọrin iyin fun Un.",
                        "Ọmọ Ọlọrun ma mbo, ka kọrin iyin fun Un.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọmọ Maria Wundia, ka kọrin iyin fun Un.",
                        "Ọmọ Ọlọrun to bẹ wa wo, ka kọrin iyin fun Un.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "156",
            Title = "MO MU MARIWO",
            Category = "ORIN IGBA AWE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Mo mu mariwo dani,",
                "Mo f'ohun ayọ kọrin",
                "Ọmọ Maria o ṣe, Olugbala wa ni",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa jagun o molu",
                        "O tẹ 'gbara eṣu pa",
                        "Ọmọ Maria O ṣe, Olurapada wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa jagun o molu",
                        "O fi 'mọlẹ fun wa",
                        "Ọmọ Maria O se, Olurapada wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọmọ Dafidi ti de Olubukun Oba",
                        "Ọba Israeli ma de o",
                        "Olurapada wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awọn Heberu njo, lọ pade Jesu Ọba",
                        "'Won n kigbe Hosanna",
                        "Olurapada wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ ni ifokansin tootọ s'ọmọ Dafidi Ọba",
                        "Ẹfi 'gbagbo yin mule",
                        "Sọlẹ lori okun.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọmọ imolẹ ẹ gbọ",
                        "Jesu a ṣo 'le atọna re",
                        "Ọmọ Maria o ṣe. Oluwosan Ọba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "157",
            Title = "ORIN IWODE FUN ODUN MARIWO",
            Category = "ORIN IGBA AWE",
            Author = "Oloye J. F. Odunjo",
            Chorus = new List<string>
            {
                "K'a fi ọpẹ fun Un",
                "Iyin, ọla ati ogo;",
                "Fun Kristi t'o jọba wa.",
                "Oun ni gbogbo ẹda aye",
                "N kọrin Hosanna si.",
                "Ka fi opẹ fun Un.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iwọ ni oba Israeli",
                        "Ọmọ bibi inu Dafidi,",
                        "T'o t'ọrun wa si aiye",
                        "Olubukun Ọba ogo ni",
                        "K'a fi ọpẹ fun Un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ogun ọrun awọn angeli",
                        "Nkọrin yin I pẹlu itara",
                        "Ati awọn araiye pẹlu",
                        "Gbogbo wọn njẹ ajẹgba ọrin",
                        "K'a fi ọpẹ fun Un.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn eniyan Heberu",
                        "ṣuru bo o pẹlu imọ lọwọ;",
                        "Ki awa pẹlu kọrin yin I,",
                        "K'a si bẹ ẹ fun aini wa.",
                        "K'a fi ọpẹ fun Un.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "ṣiwaju ijiya Rẹ",
                        "Nwọn nf'iyin at'ope fun Un.",
                        "Ni kikọ orin iyin Rẹ,",
                        "K'a jumọ kọrin ayọ yin I",
                        "K'a fi ọpẹ fun Un.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọba ogo jọwọ ye dakun.",
                        "Gb'ẹbẹ pelu orin ẹyẹ wa.",
                        "K'a le maa wu O laelae",
                        "K'a si le de 'bi ogo rẹ.",
                        "K'a fi ọpẹ fun Un.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "158",
            Title = "JERUSALEM (ỌDUN MARIWO)",
            Category = "ORIN IGBA AWE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Jerusalẹmu Jerusalẹmu (2ce)",
                "Ile ayọ nile Oluwa",
                "Mba yọ bi nba le de bẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọpọlọpọ l'o wa pade Oluwa Jesu",
                        "Nigba ti o ngẹșin bọ",
                        "Jerusalemu nile ayo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọpọ eniyan l'o nyọ pe Oluwa Jesu",
                        "Ti jọba ni Jerusalẹmu",
                        "Jerusalẹmu nile ayọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bawo lo ti dun to",
                        "Nigbati Oluwa Jesu yọ si'lu Jerusalem",
                        "Jerusalẹmu nile ayọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọpọ eniyan l'o te 'so nigbati Oluwa mbọ",
                        "Ni Jerusalemu",
                        "Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbogbo eniyan l'onke Hosanna",
                        "Nigbati wọn ri Jesu",
                        "To wọ 'lu Jerusalemu ilu ayọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Gbogbo eniyan l'o nyọ",
                        "Nigba ti Oluwa Jesu",
                        "Wọ Jerusalemu pẹlu imọ lọwọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "159",
            Title = "ORIN OJO IMO OPE",
            Category = "ORIN IGBA AWE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Hosanna o, Ọba mimọ",
                "Hosanna fọmọ Dafidi",
                "Ẹ wo, b'o tỉ nlọ lọna Jerusalẹmu",
                "Hosanna Ọba Ogo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Hosanna o, Ọba mimọ",
                        "Hosanna f'Ọmọ Dafidi",
                        "Wo 'mọ ọpẹ ti mo mu dani",
                        "Lọ pade Jesu Ọba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Hosanna o, Ọba mimọ; Olugbala Ọba Ogo",
                        "Awọn Heburu nkọrin pe",
                        "Hosanna Oluwa jọba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Hosanna o, Ọba mimọ",
                        "Olugbala wọ Jerusalem",
                        "Pẹlu ayọ oun ijo, Hosanna: Oluwa jọba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Hosanna o, Ọba mimọ",
                        "E patewo, e f'ayo kọrin",
                        "Ko s'ọba miran lehin Rẹ",
                        "Jesu Olugbala, o ṣeun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "160",
            Title = "O PEGEDE",
            Category = "ORIN IGBA AWE",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "O pegede, ọmọ Dafidi l'o pegede o;",
                "O n gẹṣin bọ, Ọmọ Dafidi ma l'on g'ẹṣin bọ,",
                "Gbogbo ẹda e wolẹ fun Un. Ọba Olugbala l'o gẹṣin de.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Kẹtẹkẹte l'ẹṣin Rẹ o",
                        "Ma firele gẹṣin lọ,",
                        "Gbogbo araiye o, ẹ maa ke Hosanna",
                        "F'Ọba onirẹlẹ o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn ọmọ Heberu o,",
                        "T'ewe timọ lọwọ wọn,",
                        "Wọn kọrin Iyin pelu ohun didun",
                        "Wọn lọ pade Rẹ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọba Israeli o",
                        "Ọmọ Dafidi maa wolẹ",
                        "T'ọmọde t'agba lo gbe ẹka Olifi",
                        "Wọn ke Hosanna O.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọmọ alade alaafia ni",
                        "Ọmọ Maria maa wolẹ,",
                        "Gbogbo araiye o, ẹ gbohun didun soke",
                        "K'e kọrin iyin si I.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Olugbala 'bukun fun wa o,",
                        "Baba mimọ o, gbọ tiwa;",
                        "B'ọlọjọ ba de o jẹ ki a ri 'bukun gba",
                        "K'a simi laiya Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "161",
            Title = "AWON ỌMỌ HEBERU (Psalm 24)",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Awọn ọmọ Heberu,",
                "T'awọn teka igi olifi Li ọwọ wọn",
                "Jade lo pade Oluwa",
                "Wọn nkigbe wipe Hosanna loke ọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ti Oluwa nile ati gbogbo ohun to wa ninu rẹ",
                        "Gbogbo agbaiye ati awon ti o tẹdo sinu rẹ",
                        "Nitori ti o fi idi rẹ sọlẹ lori okun",
                        "O si gbe e kalẹ lori isan omi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "E gbe ori yin soke ẹnyin ẹnu ọna,",
                        "Ki a si gbe yin soke ẹnyin ilẹkun aiyeraiye",
                        "Tali Ọba Ogo yi?",
                        "Oluwa ti o le, ti O si lagbara",
                        "Oluwa o Alagbara (2ce) ninu ogun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ gbe ori yin soke, ẹnyin ẹnu ọna;",
                        "A ni ki ẹ gbe wọn soke, ẹnyin ilẹkun aiyeraiye",
                        "Ki Ọba Ogo ki O le wọ'nu ile wa",
                        "Tali ọba Ogo yi?",
                        "Oluwa o, awọn ọmọ - ogun",
                        "On ni Ọba Ogo (2ce).",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "162",
            Title = "THURSDAY NI OSE MIMO (Psalm 66)",
            Category = "ORIN IGBA AWE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ki Ọlọrun saanu fun wa",
                "Ki O si bukun fun wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O tọ ki awa k'o s'ogo",
                        "Ninu agbelebu Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nitori ọdọ Rẹ ni igbala,",
                        "Iye ati ajinde wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ ni igbala wa",
                        "Ati Oludande O.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Și oju Rẹ k'o mọlẹ si wa",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Fi anu Rẹ k'o mọlẹ si wa",
                        "Fi anu Rẹ han fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "163",
            Title = "NIBI TI IFẸNI ATI IFẸ BA WA",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nibi ti ifẹni ati ifẹ ba ti wa",
                        "Nibẹ ni ibugbe Ọlọrun wa",
                        "Ifẹ Kristi ti ko gbogbo wa pọ",
                        "Ẹ jẹ ki a ma yọ ninu Rẹ",
                        "Ki inu wa si ma dun, ẹ jẹ ki a bẹru",
                        "Ki a si feran Ọlọrun alaye",
                        "Ẹ jẹ ki a si fi otitọ ọkan feran ara wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nibi ti ifẹni ati ifẹ ba ti wa",
                        "Nibẹ ni ibugbe Ọlọrun wa",
                        "Nitorina ara, nigbati a ba pe jọ pọ",
                        "Ẹ jẹ ki a ṣọra",
                        "Ki a maṣe yapa ni ẹmi si ara wa",
                        "Ẹ jẹ ki ija bi ọta ati asọ ko de opin",
                        "Ki ẹ si jẹki Kristi Ọlọrun wa",
                        "Le ma gbe arin wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Nibi ti iſẹni ati ifẹ ba ti wa",
                        "Nibẹ ni ibugbe Ọlọrun wa",
                        "Ẹ jẹ ki awa pel'awọn eniyan Mimọ.",
                        "Ri oju Rẹ ni ogo",
                        "Iwọ Kristi Ọlọrun wa",
                        "Eyi yio jẹ ayọ na tootọ",
                        "Titi aiye ainipẹkun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "164",
            Title = "OJO KEFA TI OSE MIMO (ORIN IWOLE)",
            Category = "ORIN IGBA AWE",
            Author = "",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa mbẹ ọ Ọlọrun wa,",
                        "Awa wolẹ l'ese Rẹ,",
                        "Awa ọmọ Rẹ alaaye,",
                        "A daṣa lati s'ọrọ, O lọrun alaanu julọ,",
                        "F'oju aanu Rẹ wo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ Ọba Onibuọre,",
                        "'Ranlọwọ Rẹ la nreti,",
                        "A kepe Ọ l'ohun rara,",
                        "'Wọ ti ki i gan'gbe ẹlẹṣẹ;",
                        "Aw'ọmọ Efa kepe O,",
                        "F'eti s'ohun ẹbẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọba-ngiji Ọba ọrun",
                        "Jọwọ gbọ adura wa",
                        "A mbẹ O fun idariji,",
                        "A ki yoo d'ẹṣẹ mọ lae",
                        "Iwọ to dariji wa.",
                        "Ma ṣalai dariji wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Adura mi ko ye fun Ọ",
                        "'Tori mo d'ẹsẹ si Ọ;",
                        "Iwọ ko fe'ku elese",
                        "Bi ko se ironupiwada;",
                        "Iwọ Ọlọrun Alaanu",
                        "Aanu Re l'awa nreti.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ tỉ ngba awọn ọmọ Rẹ la",
                        "Maṣe alaigba wa la",
                        "Nijọ gbogbo nigba gbogbo",
                        "Titi d'ọjọ iku wa",
                        "Imọlẹ aiyeraiye",
                        "ṣamona wa d'ọdọ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "165",
            Title = "IBOLA FUN AGBELEBU",
            Category = "ORIN IGBA AWE",
            Author = "",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Alufaa:",
                    Lines = new List<string>
                    {
                        "Ẹ wo Agbelebu, lori eyi ti Kristi ti ra aye pada (3ce)",
                    }
                },
                new Verse
                {
                    Number = "Ijo:",
                    Lines = new List<string>
                    {
                        "Ẹ wa, ẹ jẹ k'a juba f'Oluwa (3ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "166",
            Title = "RANTI O",
            Category = "ORIN IGBA AWE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ranti o ranti o",
                "Ranti pe oba alailẹṣẹ,",
                "O ku fun wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iwọ osika Iwọ abanijẹ",
                        "Ranti pe Ọba alailẹṣẹ,",
                        "O ku fun wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ ọdalẹ Iwọ aṣeke",
                        "Ranti pe Ọba alailẹṣẹ,",
                        "O ku fun wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ enia Ọmọ Ọlọrun",
                        "Ranti pe Ọba alailẹsẹ,",
                        "O ku fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "167",
            Title = "Ẹ WỌ AGBELEBU (OMIRAN)",
            Category = "ORIN IGBA AWE",
            Author = "",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Alufaa:",
                    Lines = new List<string>
                    {
                        "Ẹ wo agbelebu",
                        "Lori eyiti Kristi",
                        "Ti ra araiye pada.",
                    }
                },
                new Verse
                {
                    Number = "Ijo:",
                    Lines = new List<string>
                    {
                        "E wa ẹ jẹ k'a juba fun Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "168",
            Title = "POPULE MEUS",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L.A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹnyin eniyan mi,",
                        "kini mo fi ṣẹ yin?",
                        "Kini mo fi ṣẹ yin?",
                        "Tabi kini ẹṣẹ mi si yin?",
                        "Ẹ da mi lohun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun Mimọ",
                        "Ọlọrun Alagbara",
                        "Ọlọrun Mimo ati aiyeraiye",
                        "Saanu fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "169",
            Title = "GBE AGBELEBU RE L'EJIKA",
            Category = "ORIN IGBA AWE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Ki o maṣe wẹhin wo",
                        "Ko si ibẹru ninu Oluwa",
                        "Mura s'ọrọ igbagbọ rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Yara maṣe gba ibọde",
                        "Ọro ̣igbala yi d'ọwọ rẹ",
                        "Mura s'ọrọ igbagbọ rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Wa 'le Oluwa bẹrẹ isin",
                        "Mu ọkan rẹ ro ninu Oluwa",
                        "Ki o le de'bugbe Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu re l'ejika",
                        "Ki o mașe huwa ẹṣẹ",
                        "Ko si igbala fun ẹlẹṣẹ",
                        "T'o ba d'ọjọ idajọ o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Wo! Aiye yi yẹ-pẹrẹ ni",
                        "Awa ko ma m'ọjọ Oluwa",
                        "Ile aiye ko l'oju o.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Sare o, yara pẹhin da",
                        "Iwa keferi l'ewu pupọ,",
                        "O nsọ wa d'ọta Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Gbe Agbelebu rẹ l'ejika",
                        "Aiye Oluwa ni gbẹhin",
                        "Alafia rẹ mbẹ l'ọrun",
                        "Mura s'ọrọ igbagbọ rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "170",
            Title = "JESU JIYA NITORI WA",
            Category = "ORIN IGBA AWE",
            Author = "",
            Chorus = new List<string>
            {
                "Jesu fẹ wa o a mọ/O jiya nitori wa",
                "O tẹriba titi doju iku o/Nitori ẹṣẹ wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Krist tẹriba/Nitori wa doju iku",
                        "Ani de iku lori agbelebu/Nitori ẹsẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Kristi a fẹ O/Nitori o ti gbe wa ro",
                        "Ifẹ mu Ọ duro lori agbelebu/Nitori ẹṣẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu Kristi a de o/Nitori a ti d'ẹsẹ ni",
                        "Jọwọ ma se binu/Dari ji wa ye o, wa fori j’ẹsẹ wa",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Kristi O ṣe o/Nitori ore nla Rẹ",
                        "Jọwọ mu wa dele, k'a layọ titi o; wa fori j’ẹsẹ wa",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "171",
            Title = "AANU RẸ L'A NTORỌ",
            Category = "ORIN IGBA AWE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Aanu rẹ l'a ntọrọ, Jesu Olugbala",
                        "Awa ẹlẹṣẹ ma mbẹ Ọ fun idariji ẹṣẹ",
                        "Ti a ti da si Ọ Oluwa Olugbala",
                        "Jọwọ f'iyedenu, fori ji ni.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala, Ọmọ bibi i Baba;",
                        "Ku lori igi oro nitori ẹṣẹ wa",
                        "A kanu gidigidi, Oluwa Olugbala",
                        "Jọwọ f'iyedenu, fori ji ni.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ronu wa jinlẹ nitori ẹṣẹ wa",
                        "A doju bolẹ a tun tẹriba",
                        "A wolẹ a gbọn riri nitori ẹṣẹ wa",
                        "Jọwọ f'iyedenu, fori ji ni.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bi O ba taro ẹṣẹ tani ninu wa",
                        "To le l'aiya lati duro niwaju Oluwa",
                        "A ko leni meji bikoṣe Iwọ Oluwa",
                        "Jọwọ f'iyedenu, fori ji ni.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "172",
            Title = "IFẸNUKO AGBELEBU",
            Category = "ORIN IGBA AWE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Ẹyin ọmọ araiye ẹ gbọ,",
                "Ẹyin eniyan mi ẹ mọ,",
                "Iru ẹṣ̣e wo ni mo ṣẹ yin",
                "Ẹ da mi lohun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo yo yin kuro l'oko ẹru",
                        "Ẹ wa kan Jesu m'ọri igi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun Mimọ Alagbara",
                        "Ọlọrun iye dari ji ni.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fun itọju yin ninu iju",
                        "Ẹ kan Jesu Olugbala mọ'gi",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo r'ọjo manna fun yin jẹ",
                        "Ẹ kan Jesu Olugbala mọ'gi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo mu yin de ilẹ itura",
                        "Ẹ tun kan Jesu mọ❜gi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọlọrun Mimọ Alagbara",
                        "Ọlọrun iye dari ji ni.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Kini ki nșe, ẹ wi fun mi",
                        "Ki mba le tun mura si.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Irugbin rere ni mo fi yin ṣe",
                        "Eso kikoro lẹ so fun mi jẹ.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ongbẹ ngbẹ mi, araiye ẹ gbọ",
                        "Ọti to kan ju lẹ fi fun mi mu.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Fun gbogbo oore to pọ jọjọ",
                        "Ẹ tun fi ọkọ gun mi lara.",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Ọlọrun mimọ Alagbara",
                        "Ọlọrun iye dari ji ni.",
                    }
                },
            }
        },
        
        new Hymn
        {
            Number = "173",
            Title = "MO TI GBA KRISTI L'OBA",
            Category = "ORIN IGBA AWE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Mo ti gba Kristi l'ọba",
                "Mo ti gba Jesu l'Olugbala",
                "Igbagbọ yẹ mi o",
                "Mo dele ayọ mo dupẹ (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Onigbagbọ o Iwa Mimọ ma re o",
                        "Baba wa Jesu Krist",
                        "L'a nilati tẹle.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Baba wa Adamu l'o ṣẹ",
                        "T'a le wa jade l'ọrun",
                        "Baba Mimọ l'oke",
                        "L'o ran Ọmọ lati gba wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹn' t'o jẹ Ọlọrun",
                        "Ẹni ti ko l'ẹṣẹ",
                        "Ọmọ bibi Ọlọrun",
                        "L'o mura lati gba wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Kristi w'aiye o",
                        "Ko tilẹ ri 'bi kan wọ si",
                        "Ibujeran agutan",
                        "Maria bi Jesu si.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Afẹ aiye e o",
                        "O jina si Jesu Kristi",
                        "Ọga aiye e o",
                        "K'o ma wọ Jesu l'ọkan.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "L'ọjọ ọjọun,",
                        "Eṣu tọ Jesu wa o",
                        "Idanwo mẹta l'o fun Un",
                        "Ṣugb'Olugbala l'o bori.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Kristi sọ fun wa",
                        "P'ofin meji l'o ju",
                        "K'a fẹ Ọlọrun",
                        "Atọmọ ni keji wa.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "O mu arọ l'ara da",
                        "O ji oku dide",
                        "O la'ju afọju",
                        "Eyii ni 'ṣẹ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ọmọ araiye le,",
                        "ṣe ni wọn kan Jesu mọ'gi",
                        "Wọn ni ko ṣ’ọba o",
                        "Bi ko ṣe Kesari.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "L'ẹhin ọjọ mẹta",
                        "Kristi jinde",
                        "O tun goke lọ s'ọrun",
                        "L'ati fun wa nibugbe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "174",
            Title = "EYIN ENIYAN MI",
            Category = "ORIN IGBA AWE",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                
                
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Enyin ẹniyan mi",
                "Ki-ni mo ṣe ti o lodi?",
                "Ẹṣẹ wo ni mo ṣẹ yin?",
                "Ẹ da mi l'ohun.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Oluwa awa mbẹ Ọ o",
                        "Olugbala a be Ọ o",
                        "Awimayẹhun a bẹ Ọ o",
                        "Ẹbẹ l'a bẹ,",
                        "Dari ji 'ni un un.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo mu yin jade kuro",
                        "Ninu oko ẹru Ijibiti (Egypt)",
                        "Mo mu yin la okun pupa ja",
                        "Ẹyin wa fi kumọ ati pasan san an fun mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo mu yin segun ọta",
                        "Mo d'oju Farao bolẹ ninu omi",
                        "Ẹyin wa d'oju mi bolẹ l'abẹ igi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo fun yin ni ilẹ ti nsan fun wara ati fun oyin",
                        "Mo fun yin l'omi mu lati inu apata wa",
                        "Ẹyin wa fun mi ni ọti kikan mu lori igi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo fi ade de ọba yin lori",
                        "Mo mu gbogbo ajakalẹ-arun wa s'opin",
                        "Ẹyin wa fi ade egun de mi lori.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo fi ọgbọn ati imọ da yin lọla",
                        "Mo mu yin ṣ'owo jere nijọ gbogbo",
                        "Ẹyin bẹtọ si mi l'oju, ẹ gunwa sinu ibi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Mo f'ọmọ rere da yin l'ọla",
                        "Mo tọ yin s'ọna lati ṣ'ohun gbogbo b'o ti yẹ",
                        "Ẹyin wa fi ọtẹ ati riba san an fun mi,",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Mo fi ominira de yin l'ade",
                        "Mo da yin lọla, l'apapọ ninu ijọba",
                        "Ẹyin wa fi iwa anikanjọpọn dohun gbogbo ru.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ẹyin ti mo fi ṣọ agbo agutan",
                        "Ẹ yi pada biri, ẹ di'koko sinu agbo",
                        "Ẹyin wa sọ owo di Ọlọrun yin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "175",
            Title = "AJINDE JESU",
            Category = "IGBA AJINDE",
            Author = "J. A. Kuforiji",
            Chorus = new List<string>
            {
                "Jesu Kristi ti jinde o,",
                "O ṣẹgun iku",
                "Onigbagbọ ẹ jo, ẹ yọ;",
                "Ẹru ko ba ni mọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Maria Magdalena ati",
                        "Iya Jakọbu, oun pẹlu Salome",
                        "Kọ sare de boji.",
                        "Wọn ri awọn Angeli meji",
                        "To wọ sọ funfun.",
                        "Wọn wipe O ti jinde",
                        "Gẹgẹ b'o ti wi.",
                        "Aleluya, Aleluya; Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Maria Magdalena",
                        "Ati awọn iyoku,",
                        "Pẹlu ayọ nla, sare pada si'le",
                        "Wọn wi fun ọmọ ẹhin",
                        "Jesu Kristi mọkanla",
                        "Pe awọn ti ri Oluwa.",
                        "Wọn wipe O ti jinde",
                        "Gẹgẹ b'o ti wi.",
                        "Aleluya, Aleluya; Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Nigba ti alẹ lẹ,",
                        "ti awọn ọmọ ẹhin",
                        "Pe jọpọ ni yara,",
                        "ti a si ti ti ilẹkun.",
                        "'Biti awọn ọmọ ẹhin pe jọpọ si,",
                        "'Gba naa ni Oluwa de.",
                        "O wipe alafia ni fun yin.",
                        "Wọn gbagbọ pẹ O jinde",
                        "Gẹgẹ b'o ti wi.",
                        "Aleluya, Aleluya; Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Olugbala",
                        "Gbogbo araiye.",
                        "Nipa ijiya Rẹ la fi",
                        "Idariji ẹṣẹ fun ọmọ araiye.",
                        "Olurapada ati Ọlọrun wa,",
                        "J'ọba titi aiye.",
                        "Awa ti gba Ọ gbọ,",
                        "Pe O ti jinde",
                        "Gẹgẹ bi O ti wi.",
                        "Aleluya, Aleluya; Aleluya.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "176",
    Title = "E MAA KORIN O, ALELUYA",
    Category = "IGBA AJINDE",
    Author = "E. A. Alao",
    Chorus = new List<string>
    {
        
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹnyin Onigbagbọ, Ẹnyin onigbagbọ",
                "Ẹ maa yọ, ẹ maa yọ Jesu ti jinde (2ce)",
                "Ẹ maa kọrin o, Aleluya.",
                "Ẹ maa kọrin o, Aleluya (2ce)",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "B: Ẹ maa kọrin o Aleluya (2ce)",
                "A: Olugbala ti jinde      B: Ẹ maa….",
                "A: O ti jinde bi O ti wi   B: Ẹ maa….",
                "A: Oluwa ti jinde         B: Ẹ maa….",
                "A: E je ki a maa yọ        B: Ẹ maa….",
                "A: E ho iho ayo.          B: Ẹ maa….",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹnyin onigbagbọ, Ẹnyin onigbagbọ",
                "Ẹ jo, ẹ yọ; ẹ jo; ẹ yọ; Olugbala ti jinde",
                "Ẹ maa kọrin o, Aleluya. (2ce)",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ẹnyin onigbagbọ, Ẹnyin onigbagbọ",
                "Ẹ ho, ẹ yọ; ẹ ho; ẹ yọ; Ọba Ọrun ti jinde",
                "Ẹ maa kọrin iyin, Aleluya. (2ce)",
            }
        },
    }
},
        new Hymn
{
    Number = "177",
    Title = "A! ALELUYA (Victimi Paschali)",
    Category = "IGBA AJINDE",
    Author = "J. B. Ojo",
    Chorus = new List<string>
    {
        "Aleluya (2ce)",
        "Mo gbọ, mo gbọ iro ipe",
        "Olugbala ja'gun ajaye",
        "Mo gbọ, mo gbọ iro ipe",
        "Olugbala ja'gun molu.",
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Oluwa Jesu ti n s'ọdọ agutan",
                "L'a ru l'ẹbọ",
                "Onigbagbọ, ẹ ru ti yin si.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ọdọ aguntan ti ra agutan pada",
                "Oluwa ti bawa laja, pẹlu Baba Rẹ.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Iku at'iye ti wọ ijakadi",
                "Olu-fun-ni niye l'o ṣegun.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "N gbọ Maria ki l'o ri?",
                "Mo ri Kristi, t'oun t'ogo Rẹ.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "N gbọ Maria ki l'o ri?",
                "Mo r'Angeli alaṣọ ala",
                "Ati aṣọ isinku Oluwa Jesu.",
            }
        },
        new Verse
        {
            Number = "6",
            Lines = new List<string>
            {
                "Kristi ireti ti jinde",
                "Yio ṣaju ọmọ-ehin rẹ de Galili.",
            }
        },
    }
},
new Hymn
{
    Number = "178",
    Title = "JESU OLUGBALA",
    Category = "IGBA AJINDE",
    Author = "Oloye L. A. Owolabi",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Jesu Olugbala O ti jinde",
                "Ẹni Mimọ Atobiju",
                "Ẹ wi k'aiye gbọ",
                "Ẹ tun ṣọpẹ f'aiye",
                "Awimayehun ti ṣẹgun o.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Jesu Ọba iye O ti jinde",
                "Ọdọ Agutan Ọlọrun ni o",
                "Aiye ẹ ho",
                "Ẹ tun ṣọpẹ",
                "Awimayehun ti ṣẹgun o",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Jesu Ọba Oke O ti jinde",
                "Jesu Kristi Oluwa iye",
                "Ẹ kọrin ọpe",
                "Ko si iku mọ",
                "Awimayehun ti ṣẹgun o",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Ọmọ Dafidi gb'ade ayọ   O ti jinde",
                "O ṣẹgun eṣu Aleluya",
                "Ẹ so f'araiye",
                "Ire wọ'lede",
                "Awimayehun ti ṣẹgun o   \"",
            }
        },
    }
},
        new Hymn
{
    Number = "179",
    Title = "OLUGBALA TI JINDE (ỌDUN AJINDE)",
    Category = "IGBA AJINDE",
    Author = "E. A. Alao",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Ẹnyin ara ẹ wolẹ fun Jesu Oba wa",
                "Aṣẹgun iku Ọba iye Olugbala ti jinde (2ce)",
            }
        },
       
        new Verse
        {
            Number = "Egbe:\n(A)",
            Lines = new List<string>
            {
                "Ẹ jo, ẹ yọ O ti jinde (2ce)",
                "Olugbala ti jinde",
                "Olugbala ti jinde",
                "Olugbala ti jinde.",
            }
        },
        new Verse
        {
            Number = "Egbe:\n(B)",
            Lines = new List<string>
            {
                "Aṣẹgun iku ti jinde (2ce)",
                "Araiye ẹ wolẹ",
                "Iku ko lagbara l'ori Rẹ",
                "Ẹ kọrin Aleluya.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Ẹnyin ara ẹ jo, ẹ yọ si Jesu Oluwa wa",
                "Ọba otitọ Aṣẹgun eṣu, Olugbala ti jinde (2ce)",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Ẹnyin ara ẹ kun f'ayọ pe Jesu Ọba rere",
                "Ọmọ Ọlọrun Ọba iye. Olugbala ti jinde (2ce)",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Onigbagbọ ẹ kọrin ayọ pe Jesu Ọlọrun wa",
                "Ọmọ Ọlọrun Olurapada, Ọba iye ti jinde (2ce)",
            }
        },
    }
},
        new Hymn
        {
            Number = "180",
            Title = "JESU F'AJINDE GBE WA 'RO",
            Category = "IGBA AJINDE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu ti gbayi Jesu ti gbẹyẹ )",
                        "Jesu ti gbayi o si gbẹyẹ ) 2ce",
                        "O f'ajinde gbe wa ro",
                        "Ireti wa ko bọ s'asan",
                        "Jesu ti gbayi o si gbẹyẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu ṣeun o, Jesu ti gb'ogo )",
                        "Jesu ṣeun o, O si gb'ogo ) 2ce",
                        "O f'ajinde mu wa ji",
                        "Ireti ọrun ti tẹ wa lọwọ",
                        "Jesu ṣeun o, O si gb'ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu ṣẹgun o, Jesu ti jọba",
                        "Jesu ṣẹgun o, O si jọba",
                        "O gbade iye o gba t'ọla",
                        "O ṣiṣẹ rẹ o pe ṣanṣan",
                        "Jesu ṣẹgun o, O si jọba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu jare o, o ti ṣẹgun",
                        "Jesu jare o, O si ṣẹgun",
                        "Jesu jare iku, o ti ji",
                        "O ṣẹgun eṣu oju ti 'ku",
                        "Jesu jare o, O si ṣẹgun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Araiye ẹ ho ye! Ẹ kọrin iyin si I",
                        "Araiye ẹ ho ye! Ẹ fi yin fun Un",
                        "Jesu wa ko ni ku mọ",
                        "O f'ajinde ran wa lọwọ",
                        "Araiye ẹ ho ye! Ẹ fi yin fun Un.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "181",
            Title = "JESU YE",
            Category = "IGBA AJINDE",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu ye, O ye titi aiye o",
                        "Isa oku ko nipa mọ o",
                        "Ẹru iku ko ba mi mo o",
                        "Nitoripe Jesu ye, O ye o",
                        "Jesu ye titi aiye, Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu ye, O ye titi aiye o",
                        "Tirẹ ni 'jọba da titi lọ",
                        "Ijoba l'aiye ati l'ọrun",
                        "Nitoripe Jesu ye, O ye o",
                        "Jesu ye titi aiye, Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu ye, O ye titi aiye o",
                        "Ka fiyin fun Baba l'ọrun",
                        "Ẹni to 'ku 'ku ẹsin fun wa",
                        "Nitoripe o fẹ wa ju, Jesu o",
                        "Jesu ye titi aiye, Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu ye, O ye titi aiye o",
                        "Ina ifẹ to tan fun wa",
                        "Ko ma s'ohun to le pa o",
                        "Nitoripe o fẹ wa ju, Jesu o",
                        "Jesu ye titi aiye, Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu ye, O ṣẹgun l'ori iku o",
                        "Ki a le j'ogun ọrun rere",
                        "'Gba ta ba kuro l'aiye yi",
                        "Ka le jinde pẹlu Rẹ l'ayọ o",
                        "Jesu ye fun gbogbo aiye, Aleluya.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "182",
            Title = "AJINDE",
            Category = "IGBA AJINDE",
            Author = "J. Feyiṣitan",
            Chorus = new List<string>
            {
                "Ẹ maa jo ẹ maa yọ Olugbala wa ti jinde",
                "Egbe: Ẹ maa jo ẹ maa yọ Olugbala wa ti jọba",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo ẹ maa yọ Olugbala wa ti jinde",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo ẹ maa yọ Olugbala wa ti jọba",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ; Olugbala wa jagun molu",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ Olugbala wa ti yege",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ; Olugbala wa ṣẹgun iku",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ; Olugbala ti bukun fun wa",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ; Olugbala wa gbe wa s'ola",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹ maa jo, ẹ maa yọ; lọjọ ayajọ ajinde",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Oluwa; mu ayọ wa pọ si ni ọjọ yi o",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Maria Mimọ a ba Ọ yọ lọjọ ayajọ ajinde.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "183",
            Title = "ONI L'ỌJỌ",
            Category = "IGBA AJINDE",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "Oni lọjọ (2) Oni lọjọ iṣẹgun",
                "Oni lọjọ (2) o, Oni lọjọ iṣẹgun",
                "Ti Baba yan fun 'ra Rẹ",
                "Ti Jesu Kristi ṣẹgun iku.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O ṣẹsin 'tori yin, O gba'ya 'tori wa",
                        "O ku nitori ẹlẹṣẹ; O tun pada j'ọba aiye.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọdọ Agutan irekọja, Ọmọ bibi ti Baba",
                        "O gba ẹsẹ gbogbo aiye yi ru, ki a le ye titi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O ṣẹgun lori iku O jere ọrun fun wa",
                        "O tun fun wa ni ifẹ Rẹ, ki a le ye titi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Araiye ronu yin, Ẹni Mimọ ni Baba",
                        "Ki a le jinde pẹlu Rẹ, l'o f'ọmọ Rẹ ji wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimọ awa de, Edumare gb'ẹbẹ wa",
                        "F'ẹmi Mimọ Rẹ si wa l'ọkan ki a le sin Ọ titi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "184",
            Title = "OLUWA TI JINDE",
            Category = "IGBA AJINDE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O jinde, o jinde Oluwa ti jinde",
                        "Gbogbo aiye ẹ yọ ṣẹṣẹ Oluwa ti jinde",
                        "Ibanujẹ d'ayọ fun wa",
                        "K'a kọrin Aleluya (3ce)",
                        "Ibanujẹ d'ayọ fun wa",
                        "K'a kọrin Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O ṣẹgun o, O ṣẹgun o Oluwa ti jinde",
                        "O ṣẹgun ẹsu Aleluya Oluwa ti jinde",
                        "Oju ti t'eșu o wo lulẹ",
                        "K'a kọrin Aleluya",
                        "Oju ti t'eșu o wo lulẹ",
                        "K'a kọrin Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ologo o, Ologo o; Oluwa ti jinde",
                        "O ṣiṣẹ Rẹ O fi gbayi, Oluwa ti jinde",
                        "O gbade iye to logo ju, k'a kọrin Aleluya",
                        "K'a korin Aleluya (2ce)",
                        "O gbade iye to logo ju,",
                        "K'a korin Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O lẹyẹ o, O lẹyẹ̣ o Oluwa ti jinde",
                        "Ẹgan at' ẹtẹ ti dopin o, Oluwa ti jinde",
                        "O bori ọta O ṣẹgun o, k'a kọrin Aleluya",
                        "K'a kọrin Aleluya (2ce)",
                        "O bori ọta o ṣẹgun o",
                        "K'a kọrin Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Aiye ẹ yọ, aiye ẹ yọ; Oluwa ti jinde",
                        "Igbala ma de; ara wa o, Oluwa ti jinde",
                        "Ayọ igbala ti je tiwa o, k'a kọrin Aleluya",
                        "K'a kọrin Aleluya (2ce)",
                        "Ayọ; igbala ti jẹ tiwa o",
                        "K'a kọrin Aleluya.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "185",
            Title = "IJO OSE KEJI LEHIN AJINDE\nORIN IWOLE: 	Ps. 32 (33)",
            Category = "IGBA AJINDE",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹ ho, ẹ yọ",
                "Ninu Oluwa Ọlọrun",
                "Ẹnyin Olododo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ kọrin titun si Oluwa",
                        "Ẹ f'ijo f'ayọ yin Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tirẹ ni 'dajọ ododo",
                        "Ilẹ aiye kun fun aanu Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Nipa ọrọ Rẹ Oluwa",
                        "L'a ti da aiye pẹlu ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ki gbogbo aiye bẹru Rẹ",
                        "Ki gbogbo ẹda f'iyin f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba; Ọmọ, Ẹmi-Mimọ",
                        "Oyigiyigi Onibu-ọrẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A duro de Ọ Oluwa",
                        "Fun 'ranlọwọ ati abo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Lati 'bugbe Rẹ Ọlọrun",
                        "O ti fi sọ Rẹ sọ gbogbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "186",
            Title = "IJO OSE KẸTA LEHIN AJINDE (Ps. 65)",
            Category = "IGBA AJINDE",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Aleluya, Aleluya; Aleluya.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ hio iho ayọ si Ọlọrun",
                        "Ẹyin ẹda aye gbogbo, aleluya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ kọrin iyin s'oruko Rẹ,",
                        "Ẹ fi ijuba fun ogo Rẹ aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ wo Oluwa b'o ti lẹru to",
                        "Pẹlu gbogbo iṣẹ̣ ọwọ Rẹ, aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbogbo aiye ni yio sin Ọlọrun",
                        "Ni wọn yio si yin Baba logo, aleluya.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "O sọ okun di ilẹ gbigbe",
                        "K'awọn ayanfẹ Rẹ kọja lọ, aleluya.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a fi ibukun f'Oluwa",
                        "Ẹnyin eniyan aiye gbogbo, aleluya.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Nitori o mu wa wa laaye",
                        "O mu wa duro gbọingbọin, aleluya.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "187",
            Title = "IJỌ ỌSẸ KẸRIN LẸHIN AJINDE",
            Category = "IGBA AJINDE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ẹ kọrin titun s'Oluwa",
                "Ẹ kọrin ogo s'Olugbala.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa ti ṣe ohun iyanu aleluya",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O ti fi ododo Rẹ han aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O la'ju awọn keferi aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O fi ọwọ otun Rẹ gba wa la aleluya.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Nipa iku Rẹ mimọ aleluya",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ogo ni fun Baba ati fun Ọmọ",
                        "Ogo ni fun Ẹmi-Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Bi o ti wa latetekọsẹ",
                        "Titi aiye ailopin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "188",
            Title = "OSE KARUN LEHIN AJINDE",
            Category = "IGBA AJINDE",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ẹ ho iho ayọ s'Ọlọrun",
                "Ẹnyin orile ede gbogbo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ wa ki a kọrin s'orukọ Rẹ",
                        "Ki a si tun yin In logo…aleluya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ mu iho ayọ ro șinșin",
                        "Ki a si gbọ nigbagbogbo….aleluya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ rohin fun gbogbo aiye",
                        "Pe Oluwa ti gb'eniyan Rẹ la…aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ogo ni fun Baba ati fun Ọmọ",
                        "Ogo ni fun Ẹmi Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Bi o ti wa la tete kọ ṣe",
                        "Titi aiye ailopin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "189",
            Title = "ỌLA, OGO AT'AGBARA",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Ẹgbẹ Akọrin Oshogbo",
            Chorus = new List<string>
            {
                "Ọla, ogo at'agbara",
                "Oun ni tirẹ",
                "Kabiyesi Ọba wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Lori itẹ ogo Rẹ",
                        "Titi aiye ailopin.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ yio ṣe 'dajọ ododo",
                        "Laarin awọn eniyan Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọba gbogbo aiye",
                        "Nibi gbogbo, nigba gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbogbo awọn ọba alade",
                        "Ni wọn yio si ma wolẹ fun Ọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iyin ni fun orukọ Rẹ",
                        "Titi aiye ailopin.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Olubukun ni Iwọ Oluwa",
                        "Pẹlu orukọ mimọ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "190",
            Title = "IBA FUN O JESU OBA",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iba fun Ọ Jesu Ọba (2ce)",
                        "T'a tun le pejọ Jesu, O ṣeun;",
                        "A si ṣ'ọpẹjọjọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Igbẹkẹle Rẹ Baba (2ce)",
                        "A gbẹkẹle Ọ Jesu Ọba.",
                        "Olubori Ọba rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jọwọ o Jesu Ọba (2ce)",
                        "K' O wa gba wa ka le jẹ tirẹ titi",
                        "Olubori ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ibukun Rẹ o Baba (2ce)",
                        "L'a mbẹbẹ fun o, wa ran wa lọwọ;",
                        "K'a le ṣ'ọpẹjọjọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọna Rẹ dun, O dunjọjọ (2ce)",
                        "Jẹ k'a le maa fẹran Rẹ titi,",
                        "K'a si le d'ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jọwọ Olu Ọrun Baba (2ce)",
                        "K'o wa gba wa ka le fẹran ara wa.",
                        "K'a le ba Ọ d'ọrun rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "191",
            Title = "GBỌKAN LE JESU",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Gb'ọkan le Jesu, Oun l'oba t'ole gba ni. (2ce)",
                "Adura Ṣiṣẹ, o Ṣiṣẹ bi aṣẹ Ọlọrun",
                "Gb'ọkan le Jesu, Oun l'oba t'o le gba ni.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Kini mo n-fẹ toba Oluwa ko le se,",
                        "Onigbagbọ atata, t'o ba m'Ọlọrun l'ọba",
                        "Ko jẹ lọ 'le Alawo t'o ba f'ọkan tan Jesu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Kini mo n fe t'alawo le ṣe fun mi;",
                        "Onigbagbọ atata ni lati m'Ẹlẹda eweko,",
                        "Ko s'Ẹlẹda eweko lọtọ, a fi Iwọ nikan.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọrun Ọba, kini mo le gbe kọja odọ Rẹ;",
                        "Onigbagbọ atata ni lati wolẹ f'Ọlọrun",
                        "Oyigiyigi, l'o d'awo at'eweko.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọlọrun Ọba, Iwọ l'o d'eiye oju ọrun",
                        "Onigbagbọ atata t'o ba tilẹ roju okun",
                        "Kọ jẹ pẹgan Olodumare, fun 'sẹ ribiribi t'o ṣe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọrun Ọba, mo ti b'ọkan mi pinnu",
                        "Onigbagbọ atata t'o ban d'ẹsẹ s'Ọlọrun",
                        "K'o tọrọ idariji k'o le r'oju Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "192",
            Title = "A O FI 'YIN F'OLUWA",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "B. A. Aluko",
            Chorus = new List<string>
            {
                "Ọba wa o, a o fi 'yin f'Oluwa Ọba wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ a f'iyin f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Adimula l'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Abani w'aiye l'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọgbagba ti gb'ọmọ lọ 'ku.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọrọ ti nsọ'bi d'ire.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọba a rinu r'ode.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Olumọran ọkan ni.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "193",
            Title = "ỌRỌ MI DAYO",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ibanujẹ ti kuro, ayọ lo de ba mi",
                        "Mo ti ni Jesu l'Oluwa o, ayọ mi kun rere",
                        "Adani magbagbe l'Oluwa Ọba Mimọ",
                        "Ọrọ mi dayo Jesu ti gbọ tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Aigbagbọ ti kuro mo sun m'Oluwa",
                        "Mo ti ni Jesu ni tẸmi o, tile tile",
                        "Onibu-ola ma l'Ọlọrun Ọba to da mi",
                        "Ọrọ mi dayo Jesu ti gbọ tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Airoju ti kuro mo yọ m'Oluwa",
                        "Mo ti ni Jesu- l'Ọba o Mo dupe",
                        "Awimayehun lo fi 'yọ s'aiye mi",
                        "Ọrọ mi dayo Jesu ti gbọ tẸmi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ipọnju ti kuro, ọrọ lo de ba mi",
                        "Mo ti ni Jesu l'Oluwa o, tẹbitẹbi",
                        "Mo b'Ọlọrun ṣowo pọ Baba pọn mi le",
                        "Ọrọ mi dayo Jesu ti gbọ tẸmi.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "194",
    Title = "KI L'O MBA YIN LẸRU",
    Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
    Author = "Joseph Bayo Ojo",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "1",
            Lines = new List<string>
            {
                "Kil'o mba yin leru?",
                "Iberu ko si ninu ọkan mi,",
                "Mo ni Jesu lẹhin,",
                "Iberu ko si ninu ọkan mi.",
            }
        },
        new Verse
        {
            Number = "Lile: a.",
            Lines = new List<string>
            {
                "Baba n'ile, Baba l'oko",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo, nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "Lile: b.",
            Lines = new List<string>
            {
                "Iwo ni a gb'oju le",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "2",
            Lines = new List<string>
            {
                "Kil'o mba yin leru?",
                "Ifoya ko si ninu ọkan mi,",
                "Mo ni Baba lẹhin",
                "Ifoya ko si ninu ọkan mi.",
            }
        },
        new Verse
        {
            Number = "Lile: a.",
            Lines = new List<string>
            {
                "Olugbala l'Oluwa",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "Lile: b.",
            Lines = new List<string>
            {
                "Iwo ni a fehin-ti",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "3",
            Lines = new List<string>
            {
                "Tani Olupese?",
                "Jesu nikan l'Olupese",
                "Ko ma s'ẹlomiran,",
                "Jesu nikan l'Olupese.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Iwọ l'Ọba Olupese",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Wa pese fun wa",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "4",
            Lines = new List<string>
            {
                "Nibo nile ayọ?",
                "Bikose odo Baba nikan",
                "Jare mu mi de'bẹ",
                "Olugbala l'Ọlọrun mi.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Iwọ l'Ọba ti ngba 'ni",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Ogbigba ti ngbara adugbo",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Aabo nigba ipọnju mi.",
            }
        },
        new Verse
        {
            Number = "5",
            Lines = new List<string>
            {
                "Oluwa wa Jesu",
                "Iwọ l'Ọba ti o ga julọ,",
                "Pelu ohun ayọ o",
                "Mo kigbe pe Ọ o Baba.",
            }
        },
    }
},
        new Hymn
        {
            Number = "195",
            Title = "OLUWA MO BẸ Ọ",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Oluwa mo bẹ ọ (2ce)",
                "Wa poro ẹsẹ ninu ọkan mi.",
                "Tori ẹlẹsẹ ki yoo lọ laijiya",
                "Maṣe jẹki npofo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ranti wa, Oluwa maṣe gbagbe wa",
                        "Iwọ ti j'ọba lori aye",
                        "Wa f'ọrọ to dara si mi l'ẹnu",
                        "K'ọrọ mi le dara loju Ọba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa, maṣe gbagbe wa",
                        "Iwọ ti j'ọba lori aiye,",
                        "Wa f'aṣọ to dara si mi l'ara,",
                        "K'aṣọ ini le dara, l'oju Ọba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa; maṣe gbagbe wa,",
                        "Iwọ ti j'ọba lori aiye,",
                        "Wa f'ounjẹ to dara si mi l'ẹnu",
                        "Ki ọkan mi le yọ, l'oju Ọba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ranti wa Oluwa; maṣe gbagbe wa,",
                        "Ẹmi o 'jakara, Ọlọrun mi;",
                        "Ẹmi o mu waini; ọrun pelu (oti rẹ pelu);",
                        "Nihin: ngo gba idariji ẹsẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "196",
            Title = "ỌJỌ ỌDUN MIMO TI PENTOSTI\n(TABI ISOKALẸ ẸMI MIMỌ WA SORI AWỌN APOSTOLI\nORIN IWỌLE:",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Wa Ẹmi Mimọ Olutunu",
                "Wa ba s'ori gbogbo wa",
                "Lọjọ oni o,",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba mimọ awa de",
                        "Lati ju lẹsẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Ọba Ọlọla",
                        "Jẹ alagbawi gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹmi Ọlọrun aiyeraiye",
                        "Fun wa lọgbọn pẹlu oye.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Imọran, agbara; ifọkansin",
                        "Jọwọ fifun wa Ọba t'o pe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ibẹru Oluwa, Imọ pipe;",
                        "K'o jẹ tiwa lọjọ gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "197",
            Title = "ẸMI MIMỌ WỌLE DE",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Ẹmi Mimọ wọle de",
                "Ẹmi okunkun parada",
                "Ọba Mimọ l'Ọlọrun wa",
                "Araiye ẹ yọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Araiye ẹ sare wa",
                        "T'ẹgbẹ t'ọba ẹ kọrin",
                        "Ọba Mimọ l'Oluwa",
                        "Gbogbo aiye ẹ yọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gbogbo araiye ẹ tẹwọ",
                        "Ẹniti ko ri a ri Ṣe",
                        "Ọba Mimọ l'Ọlọrun",
                        "Araiye ẹ yọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aboyun a bi wẹrẹ",
                        "Ọmọde ko ni ku o",
                        "Ẹni t'o nke pe Jesu",
                        "Ọrọ wọn yio d'ayọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọba Mimọ a dupe",
                        "Ọba Atata a yege",
                        "Ẹmi Mimọ Ọlọrun",
                        "O de ba wa l'ayọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "198",
            Title = "SOKALE ẸMI MIMO",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "",
            Chorus = new List<string>
            {
                "Sọ-ka-lẹ Ẹmi-Mimọ",
                "Olorisun iwa rere",
                "Wa o, Wa o;",
                "Alagbara julọ wa o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Irusun Ọgbọn oun oye",
                        "Apata iye tootọ jare wa o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Alagbara ẹlẹbun pipe",
                        "Ye wa fun wa lagbara Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Sare wa l'awọ adaba",
                        "Ko wa ba sori gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa pẹlu ẹbun Rẹ mejeje",
                        "Wa kun wa fun ẹbun Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ Olumọna tootọ,",
                        "Dakun ṣ'amọna wa gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iwọ ni imọlẹ tootọ,",
                        "Dakun tan imọlẹ s'aiye wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Olutunu tootọ",
                        "Alagbara julọ, wa o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "199",
            Title = "SOKALẸ WA Ẹmi MIMO",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Sokalẹ wa o Ẹmi Mimọ",
                "Wa sinu ọkan wa",
                "Wa fun wa l'ẹbun meje Rẹ",
                "Wa fun wa ni ọgbọn.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Finu ọkan wa ṣe'bugbe",
                        "Jẹ alaabo wa ni ọjọ gbogbo",
                        "To wa s'ona ninu ẹsin wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Ọgbọn Rẹ o, fi han wa",
                        "Wa ṣe ona wa ni ire",
                        "Wa o, dakun d'abobo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Wa da wa ni imọran to jọju",
                        "Jẹ Olumọran rere fun wa",
                        "T'ọ wa s'ona, wa f'ona han wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Agbara atata Rẹ fihan wa",
                        "Jẹ agbara fun gbogbo wa",
                        "Jẹ ka bori ọta wa gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Wa fi imọ ẹsin wa han wa",
                        "Jẹ orisun imọ rere fun wa",
                        "Wa tan ina Rẹ sinu ọkan wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Wa fun wa ni 'fọkansin otito",
                        "Jẹ ka sin Baba b'otiye",
                        "Wa fun wa ni ere igbagbo.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ wa ba wa gbe",
                        "Fun wa ni ibẹru Ọlọrun",
                        "Jẹ ka bẹru Rẹ titi d'opin",
                        "Fun wa ni ogo ẹbun Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "200",
            Title = "ẸMI MIMỌ OLUTUNU",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ẹmi Mimọ Olutunu,",
                "Sọkalẹ sori wa.",
                "Kun wa f'ọgbọn atoye",
                "Olodumare.",
                "Wa gbọ tiwa Ẹmi ọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olutunu Ọba iye, Iwọ lorisun ọgbọn;",
                        "Fun wa lọgbọn to ye koro,",
                        "Fun wa nimo t'a o fi mọ Ọ.",
                        "Ẹni kẹta ti Mẹtalọkan Mimọ, a mbẹ Ọ o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ Ọba oke, Iwọ lorisun ọla",
                        "Fun wa lọla ti ko legbin.",
                        "Fun wa niye t'a o fi sin Ọ",
                        "Ẹni kẹta ti Mẹtalọkan Mimọ a mbẹ Ọ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aniyi-k'aiye Olupese, Iwọ lorisun ọpẹ",
                        "Fun wa lọpẹ ti ko lopin",
                        "Tọ wa s'ona, mu wa de'le",
                        "Ẹmi keta ti Mẹtalọkan Mimọ a mbẹ Ọ o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "201",
            Title = "IRANLOWỌ RẸ",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Iranlowọ Rẹ l'awa n toro (2ce)",
                "Ọlọrun Mẹtalọkan",
                "Ọna Oluwa awamaridi",
                "Ala-i le mọ ni:",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Tani o mọ iro Oluwa?",
                        "Tani iṣẹ igbimo Rẹ?",
                        "Ko s'ohun ta le ṣe lẹhin Rẹ",
                        "Iranlowọ Rẹ l'awa n toro.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka kọ'rin yin 'luwa",
                        "Fun alaipin iwa 'sọkan Rẹ",
                        "Wa fun wa l'ore ọfẹ igbala",
                        "Iranlowọ Rẹ l'awa n toro.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Orukọ Rẹ ti niyi to",
                        "Fun wa ni iṣọkan alaipin",
                        "Mu wa kuro ninu ipọnju ọta",
                        "Iranlowọ Rẹ l'awa n toro.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo ti b'Oluwa duro ti pe",
                        "Oluwa l'agbawi mi",
                        "Iná ko si f'awọn to gbẹkẹle Ọ",
                        "Iranlowọ Rẹ l'awa n toro.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "202",
            Title = "WA O, ALASE ỌRUN",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Wa o Alase Ọrun, Wa o Ọlọrun Ọba;",
                "Ye, sọkalẹ wa ba wa gbe lọjọ oni o;",
                "Wa o Ọlọrun Ọba.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mẹtalọkan Edumare wa ba wa pe.",
                        "Mẹtalọkan Edumare wa mi si wa,",
                        "Jẹ k'o yẹ wa lọjọ oni, iba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mẹtalọkan Edumare wa da wa si,",
                        "Mẹtalọkan Edumare wa sun mo wa,",
                        "Sure fun wa lọjọ oni o, iba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oludare Edumare wa kẹ wa ye,",
                        "Oludare Edumare wa ran wa ṣe,",
                        "Da wa lare lọjọ oni o, iba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oludare Edumare jẹ ko ye wa,",
                        "Oludare Edumare ka maa ri ṣe,",
                        "Da wa lare lọjọ oni o, iba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ye Ọlọrun Edumare da wa lọla,",
                        "Ye Ọlọrun Edumare ka maa ṣe iṣẹ,",
                        "Ṣegun fun wa lọjọ oni o, iba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Fun wa l'okun Edumare maa ba wa gbe,",
                        "Fun wa l'okun Edumare ka maa rije,",
                        "Da wa lare lọjọ oni o, iba Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "203",
            Title = "MẸTALỌKAN ỌLỌRUN KAN",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "B. A. Odunuyi",
            Chorus = new List<string>
            {
                "Mẹtalọkan Ọlọrun kan (2ce)",
                "Baba, Ọmọ Ẹmi-Mimọ;",
                "Mẹtalọkan-Mimọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba ran ọmọ Rẹ",
                        "Kanṣoṣo wa s'ile aiye",
                        "Lati ra wa pada:",
                        "Jesu de 'le aiye",
                        "Ifẹ Baba Rẹ lo ṣe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nigbati Oluwa wa de 'le aiye",
                        "Aiye kọ Ọ silẹ",
                        "Ṣugbọn ki O to goke tọ",
                        "Baba Rẹ lọ,",
                        "O si ṣe 'leri Olutunu fun wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọjọ kẹwa,",
                        "Lẹhin ti Oluwa ti goke",
                        "Lọ si ọrun",
                        "Wa s'ile aiye.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹmi-Mimọ",
                        "Kun inu awọn Apostoli",
                        "O fi ọrọ si wọn l'enu",
                        "O si fun wọn ni okun",
                        "Lati f'ogo Ọlọrun han.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbogbo araiye, ẹ tẹwọ adura",
                        "Si Mẹtalọkan Mimọ",
                        "Lati fun wa ni okun at'agbara,",
                        "Ki a le sin l'otito ati l'ododo",
                        "L'ọjọ aiye wa gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "204",
            Title = "ỌJỌ ỌDUN MIMỌ TI ARA OLUWA\n(KORPUS KRISTI)\nORIN IWỌLE Ps. 80 (81)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Oluranlowo l'Ọlọrun wa",
                "Ẹ ho iho ayọ si Oluwa",
                "Ẹ kọrin ogo s'Olugbala.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ f'ijo f'ayọ yin Oluwa",
                        "Olubukun l'Ọba ogo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ninu ipọnju mi Oluwa",
                        "Iwọ nikan l'Otunu mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ko s'ọba meji a f'Ọluwa",
                        "Ọbangiji Onibuọrẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwọ l'Oluwa Ọlọrun mi",
                        "Oludande Ọba rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "O f'onjẹ iye fun wa jẹ",
                        "O f'eje mimọ ra wa pada.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "205",
            Title = "ONJẸ IYE",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Onjẹ iye aladun",
                "L'Oluwa fi bọ wa Aleluya",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O f'ora, alikama bọ awọn eniyan rẹ",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oyín lat'inu apata lo fi te wa l'ọrun",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aleluya aleluya, Oluwa ti bọ wọn yo",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ ho iho ayọ s'Ọlọrun Oluranlowo",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ kọrin s'oke s'Ọlọrun Jakọbu",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹmi yio ṣe ẹlẹri, Israẹli wa gbọ tẸmi",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹmi ni Oluwa Ọlọrun nyin",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Mo mu nyin kuro l'oko ẹru Egypti",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "La ẹnu rẹ, Ẹmi yio si bọ ọ yo",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ogo ni fun Baba / Ogo ni fun Ọmọ",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Ogo ni fun Ẹmi Mimọ",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Bi o ti wa ni ibẹrẹ aiye",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Bẹni ni isisiyi",
                    }
                },
                new Verse
                {
                    Number = "14",
                    Lines = new List<string>
                    {
                        "Bẹni yio si ma ri ni igba gbogbo",
                    }
                },
                new Verse
                {
                    Number = "15",
                    Lines = new List<string>
                    {
                        "Aiye ainipẹkun - Amin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "206",
            Title = "ATOBIJU L'O DE",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Atobiju l'o de",
                        "Gba'yi gbọ ọmọ igbala ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Orisun ayọ pipe )",
                        "Jọwọ mu wa de ọrun rere ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ara, ẹ fife gbe )",
                        "Ifẹ l'o yẹ k'a fi sin Baba ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a tọna to tọ )",
                        "Eyi l'o yẹ 'mọ igbala ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a huwa mimọ )",
                        "Iwa mimọ Olugbala ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "B'aiye ngbogun huwa mimọ )",
                        "Fi ba fun Ọba Edumare ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Mo ki Ọ Olubukun )",
                        "Alewilese Olugbala ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Oluwa ran wa lọwọ )",
                        "Gba wa ki a jẹ ti Baba ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Oluwa Olubukun )",
                        "Bukun fun gbogbo eniyan ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Oluwa ṣaanu )",
                        "Ṣaanu fun wa Olugbala ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Jesu Kristi ṣaanu )",
                        "Ṣaanu fun wa Olupese ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Oluwa f'ona han wa )",
                        "Ṣe 'tọju wa d'ọrun rere ) 3ce",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Oluwa Oluranlowo )",
                        "Jọwọ mu wa ṣẹgun ibi ) 3ce",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "207",
            Title = "MO WỌLẸ MO F'ORI BALẸ",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Mo wọlẹ mo foribalẹ f'Ọba mimọ (2ce)",
                "Mo ki Ọ Olugbala",
                "Mo ki Ọ Olupese",
                "Mo ki Ọ Oluranlowo mi lati ọrun",
                "Mo wọlẹ mo foribalẹ f'Ọba mimọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Onigbagbo ẹ jo, ẹ yọ, ẹ f'iyin f'Oluwa",
                        "Onigbagbo ẹ jo, ẹ yọ, ẹ f'iyin f'Olugbala",
                        "Ko s'ẹyẹ meji t'o dabi ọkin n'igbo",
                        "Ko s'ọba meji t'o dabi Oluwa o",
                        "Onigbagbo ẹ jo, ẹ yọ, ẹ f'iyin f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Onigbagbo ẹ yi pada, ẹ tọna mimọ o",
                        "Onigbagbo ẹ yi pada, ẹ huwa t'o gba yi",
                        "Ko s'ohun meji t'o dabi ifẹ pipe",
                        "Ko s'ohun meji t'o f'ifẹ Oluwa han",
                        "Onigbagbo ẹ yi pada, ẹ tọna mimọ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo juba f'Ọba t'o ga ju, mo f'igbagbo sun mọ Ọ",
                        "Mo juba f'Ọba t'o ga ju mo f'igbagbo mi han",
                        "Ọrẹ aiye le wa kọ mi t'ọjọ ba yi",
                        "Ṣugbọn Olu-Ọrun f'ifẹ pipe fẹ mi",
                        "Mo juba f'Ọba t'o ga ju, mo f'igbagbo sun mọ Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onigbagbo ro'nu rẹ wo, k'o bọwọ f'Oluwa",
                        "Onigbagbo ro'nu rẹ wo, k'o bọwọ f'Edumare",
                        "Ko s'eniyan meji t'o nṣe 'kẹ ẹda l'aiye",
                        "Ko s'ibi t'eniyan wo ti ko s'Ọlọrun",
                        "Onigbagbo ro'nu rẹ wo, k'o bọwọ f'Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "208",
            Title = "JẸ K'A SIN JESU DE OPIN",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jẹ k'a sin Jesu de opin, ara mi (2ce)",
                        "Ileri t'o ti ṣe fun wa ko yẹ titi aiye",
                        "Jẹ k'a sin Jesu de opin, ara mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Wa fun wa nigbagbo Rẹ, Oluwa (2ce)",
                        "Ẹda t'o ba gba t'Oluwa ko le ṣina titi aiye",
                        "Wa fun wa nigbagbo Rẹ, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa fun wa n'ireti Rẹ Oluwa (2ce)",
                        "Ileri ti o ṣe fun wa ko le yẹ titi aiye",
                        "Wa fun wa n'ireti Rẹ, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa fun wa nile Rẹ, Oluwa (2ce)",
                        "Ifẹ mimọ ti Oluwa oun ni'wa t'o pọn wa le",
                        "Wa fun wa n'ifẹ Rẹ, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jẹ k'a jogun ajinde ologo (2ce)",
                        "Ipin ninu ire l'ọrun oun l'ẹbun t'o dara pe",
                        "Jẹ k'a jogun ajinde ologo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Wa mu wa de 'bugbe ọrun, Oluwa (2ce)",
                        "Ekun rere ire l'ọrun oun nireti ti a ni,",
                        "Wa mu wa de 'bugbe ọrun Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Wa fun wa ni Ẹmi Rẹ, Oluwa (2ce)",
                        "Ẹmi mimọ Baba l'ọrun oun l'ẹbun ti mu rere wa",
                        "Wa fun wa ni Ẹmi Rẹ, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Mi si wa k'a ṣe 'fẹ Rẹ Oluwa (2ce)",
                        "Ifẹ mimọ ti Oluwa ati iwa mimọ yẹ wa",
                        "Mi si wa k'a ṣe 'fẹ Rẹ, Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Jẹ ka ṣiṣẹ ajinde ara mi (2ce)",
                        "Ẹda t'oba ti lọ s'ọrun ko le dẹhin s'ile aiye",
                        "Jẹ k'a ṣiṣẹ ajinde, ara mi.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ranti Majẹmu Rẹ Oluwa (2ce)",
                        "Ileri ti o ṣe fun wa ko le yẹ titi aiye",
                        "Ranti Majẹmu Rẹ, Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "209",
            Title = "PẸNTIKỌSTI\n(IJỌ ỌSẸ KEJI LẸHIN PENTIKỌSTI)\nORIN IWỌLE: Ps. 17 (18)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹmi fẹ Ọ Oluwa (2ce)",
                "Agbara mi",
                "Ẹmi fẹ Ọ Oluwa",
                "Olugbala mi",
                "Ẹmi fẹ Ọ Oluwa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo kigbe si Ọ Oluwa",
                        "Gba mi lọwọ amọniṣeni",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Irora iku wa yi mi ka",
                        "Ẹru iku ṣiji bo mi",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ninu ipọnju mi Oluwa",
                        "Mo kigbe si Ọ lojoojumọ",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo kiyesi ona Rẹ Oluwa",
                        "Mo duro ṣinṣin t'Onibuọrẹ",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oluwa yio pese ohun rere",
                        "Fun mi gẹgẹ bi o ti yẹ",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹmi yio f'iyin fun Ọga ogo",
                        "Nibi gbogbo, nigbagbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "210",
            Title = "IJỌ ỌSẸ KẸTA LẸHIN PẸNTIKỌSTI\nORIN IWỌLE: Ps. 24 (25)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Iwọ ni mo gb'okan mi s'oke si Oluwa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo gb'okan le Ọ",
                        "Maṣe da mi l'ara",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "F'ona Rẹ han mi Oluwa",
                        "Kọ mi nipa ona Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ranti majemu Rẹ Oluwa",
                        "Fi otito Rẹ han fun mi",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Yipada si mi Ọlọrun",
                        "Ṣaanu fun ọmọ-ọdo Rẹ",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Wo ipọnju mi Oluwa",
                        "Fun imukuro awọn ẹsẹ mi",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Pa ọkan mi mọ Oluwa",
                        "Iwọ ni mo gbẹkẹ mi le.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "211",
            Title = "IJỌ ỌSẸ KEFA LẸHIN PENTIKỌSTI\nORIN IWỌLE: Ps. 26 (27)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Mo kigbe si Ọ Oluwa",
                "Iwọ ni apata igbala mi",
                "Jọwọ da mi lohun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gbọ ẹbẹ mi Oluwa",
                        "Bi mo ti nkigbe pe Ọ",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mu mi yera kuro l'ona ibi",
                        "Ki mba le rin l'ona Rẹ",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Yi awọn ẹlẹsẹ l'okan pada",
                        "Ki wọn ba le jẹ Tire",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olubukun ni Iwọ Oluwa",
                        "Nitori ti O gbọ ẹbẹ mi",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ l'Oluwa agbara mi",
                        "Ẹmi yio si ma f'iyin fun Ọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "212",
            Title = "IJỌ ỌSẸ KEJE LẸHIN PENTIKỌSTI\nORIN IWỌLE: Ps. 46 (47)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹyin orile-ede",
                "Ẹ patẹwọ lati yin Oluwa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ fi iho ayọ kigbe pe Ẹ",
                        "Ẹ f'inu didun juba f'Oluwa",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oluwa lo ga ju gbogbo wa lọ",
                        "Oun l'Ẹlẹda ohun gbogbo",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Alakoso aiye l'Oluwa wa",
                        "Awimayehun l'Ọba tiwa",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin ẹda ẹ wọle f'Ọlọrun",
                        "Ẹ f'ibere yin han f'Ọba rere",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ fi imore yin han f'Ọlọrun",
                        "Nipa igbega iṣẹ Oluwa",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "213",
            Title = "IJỌ ỌSẸ KẸJO LẸHIN PENTIKỌSTI\nORIN IWỌLE: Ps. 47 (48)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹni nla ni Oluwa",
                "K'a kọrin ogo si",
                "Ka f'iyin pipe fun",
                "Ni ibi mimọ Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Lori oke Sioni",
                        "Oke mimọ ibi ayọ",
                        "Ọlọrun f'ara han",
                        "Bi asa fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn ọta gb'ogun de",
                        "Lati wa ba wa ja",
                        "Ṣugbọn Oluwa Ọlọrun",
                        "Ti gba wa lọwọ gbogbo wọn.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ti riṣẹ Oluwa",
                        "Larin awọn eniyan",
                        "Ni ile ati l'ona",
                        "N'ibi gbogbo n'igba gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "214",
            Title = "IJỌ ỌSẸ KẸSAN LẸHIN PENTIKỌSTI\nORIN IWỌLE: Ps. 59 (54)",
            Category = "IGOKE RE ỌRUN TI JESU TITI DI ỌDUN KRISTI ỌBA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ọlọrun Olugbala",
                "F'eti si ẹbẹ mi",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awọn ọta dide si mi",
                        "Nwọn fẹ lati pa mi lara",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun gbe 'ja mi",
                        "O ṣe 'ranlowo fun mi",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn ọta dojubolẹ",
                        "Niwaju Rẹ Oluwa",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹmi yio yin Oluwa",
                        "Ngo si rubọ si Ọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "215",
            Title = "AWA MBẸ MARIA IYA ỌLỌRUN",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Maria Mimọ a mbẹ Ọ o, wa gbọ ti wa",
                        "Iya Ọlọrun jọwọ o, wa gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Awa mbẹ Ọ o, Maria Iya Ọlọrun",
                        "Ayaba Mimọ a mbẹbẹ wa gbọ ti wa",
                        "Jọwọ o Maria ṣamọna wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya oniwa pipe, A wolẹ l'ẹsẹ Rẹ",
                        "Jọwọ o a mbẹbẹ f'eti si wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun ran wa lọwọ, f'eti si adura wa",
                        "A wolẹ fun Ọ o, Ayaba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa jẹ Oluranlowo fun awa ọmọ Rẹ",
                        "A kigbe pe Ọ o, Maria Iya Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "216",
            Title = "MARIA IWỌ L'A BẸ",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Maria iwọ l'a bẹ (2ce)",
                "Ba wa bẹ ọmọ rẹ,",
                "Maria iwọ l'a bẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ko dari ẹṣẹ ji wa Ayaba alaanu, Maria iwọ l'a bẹ",
                        "Digi ti ododo Iya aileeri, “",
                        "Iya Olufe Iya ti Olugbala “",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya oniyanu, Iya ti Ẹlẹda Maria iwọ l'a bẹ",
                        "Wundia Oloye julọ, Wundia ọlọla “",
                        "Wundia Olokiki, Wundia Alagbara “",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wundia Olotitọ, Ibujoko ti ọgbọn Maria iwọ l'a bẹ",
                        "Idi ayọ wa, Ohun elo elẸmi “",
                        "Ohun elo Ọlọla Itanna Ijinlẹ “",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ile t'a fi wura ko, Ilẹkun ọrun Maria iwọ l'a bẹ",
                        "Irawo Owurọ, Ilera alaisan “",
                        "Abo awọn ẹlẹsẹ, Olori awọn Wundia “",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "217",
            Title = "IGBEGOKE LỌ SỌRUN TI MARIA",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Maria mimọ jagun molu o",
                "O dade wura loke ọrun",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ami nla kan si han ni ọrun,",
                        "Maria mimọ fi oọrun ṣe aṣọ wo, O goke ọrun lọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Osupa nran labẹ ẹsẹ rẹ, a de Maria",
                        "Lade onirawo mejila loke ọrun rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "218",
            Title = "Ẹ KỌRIN TITUN",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Ẹ kọrin titun si Oluwa",
                "Nitori ti O ṣeun jọjọ",
                "O ti mu 'gbala wa fun wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O fi ododo Rẹ han fun wa",
                        "Ọna igbala l'o ti fi ye wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O ranti aanu Rẹ si wa",
                        "O f'ona igbala han gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ ho iho ayọ si Ọlọrun",
                        "Ẹ kọrin iyin s'Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Dùrú, atẹwọ, fere; ipe",
                        "Ẹ f'ohun gbogbo yin Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ki gbogbo ẹda yin Baba l'ogo",
                        "Awimayehun Ọba rere.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Oun yio ṣe 'dajo ododo",
                        "Ti orile-ede aiye gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Maria mimọ jagun m'olu",
                        "O gb'ade ogo l'ode ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "219",
            Title = "AYABA MIMỌ MARIA",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Ayaba Mimọ Maria, jẹ Oluranlowo wa",
                "Wundia Ologo julo Iya Ọlọrun",
                "A mbẹbẹ gbọ ẹbẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Maria Mimọ Iya Ọlọrun, gbọ ẹbẹ wa",
                        "Ayaba Mimọ a mbẹbẹ gbọ ẹbẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A ki Ọ Ayaba Mimọ, Ọlorisun ayọ wa",
                        "A kigbe pe Ọ o, Maria, wa gbọ tiwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A fi irẹlẹ ọkan bẹ Ọ, Iya oninure",
                        "Jẹ alagbawi wa Ayaba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya oniwa pipe, Iya Ọlọrun",
                        "Iya alagbara julo, ṣ'amọna wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ayaba Mimọ ran wa lọwọ, Iya Olugbala wa",
                        "Ran wa lọwọ a mbẹbẹ, f'eti si adura wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "220",
            Title = "MARIA GBA MI",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "C.S.O. Baluje",
            Chorus = new List<string>
            {
                "Irẹ (3) loni o, irẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Maria gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Josefu gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Anjeli gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbogbo Ẹni-Mimọ gba mi, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Kristi gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Olugbala gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Oluwa gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Edumare gba mi o, irẹ.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ọlọrun gba mi o, irẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "221",
            Title = "IYA MIMỌ MARIA",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Iya Mimọ Maria, a de (2ce)",
                "Jẹ Oluranlowo wa,",
                "Iya Ọlọrun Alagbara julo,",
                "Gbọrẹ wa o, gbọrẹ wa (2ce)",
                "Dakun Iya Mimọ wa gbọpẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun a wa s'ope,",
                        "Fun abo Rẹ l'ori wa,",
                        "Ọpẹ ye Ọ o, Iya Ọlọrun,",
                        "A wa f'ope fun Ọ Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun, a m'ore wa,",
                        "A tun wa f'ore wa han si Ọ",
                        "F'eti si wa Iya Ọlọrun.",
                        "A wa s'ope fun Ọ, Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iya Oni'wa mimọ a de,",
                        "Jọwọ maa ṣ'amọna wa,",
                        "Iya Alagbara dakun o,",
                        "Jọwọ gb'ope wa, Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun, awa mbẹ Ọ,",
                        "Ayaba Mimọ Orisun Ayọ,",
                        "Jẹ alagbawi wa Maria,",
                        "A nkigbe si Ọ Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iya Alagbara ran wa lọwọ.",
                        "Iya Ọlọrun wa gbọ ti wa.",
                        "F'eti si wa jọwọ Maria,",
                        "A wa s'ope fun Ọ. Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iya Oninure awa de,",
                        "Gba wa lọwọ ọta ile ọta ode,",
                        "A nkigbe pe Ọ Maria,",
                        "Iya Mimọ, a de, awa kigbe si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ayaba Mimọ Oluranlowo,",
                        "Wa ṣ'amọna wa nigbagbogbo.",
                        "A nkigbe pe Ọ Maria,",
                        "A wa f'ope fun Ọ, Iya Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "222",
            Title = "MARIA MIMỌ A BẸ Ọ",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Maria Mimọ, a bẹ Ọ",
                "Iya Ọlọrun n'Iwọ nṣe",
                "Iwọ l'o bi Olugbala, ti o k'ẹsẹ aiye lọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Baba Mimọ jare gbọ, gbọhun awa ọmọ Rẹ",
                        "Ma jẹ k'a ku sinu ẹsẹ, ma jẹ ki a pofo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọmọ Ọlọrun t'a bi s'aiye",
                        "Ti ko labawọn ẹsẹ kan",
                        "Ọmọ eniyan di iwa ọtẹ, wọn kan Jesu m'ori igi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Agbelebu t'o wuwo, la gbe l'ejika Oluwa",
                        "B'o ti wuwo, ko f'ohun, o fi irẹlẹ doju iku.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onigbagbo k'ẹ piwada, Jesu ku fun gbogbo wa",
                        "O ta ẹjẹ sile fun wa, k'a ba le r'oju Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọkan mimọ l'o dara, f'onigbagbo ododo",
                        "Ero mimọ, ifẹ atata, k'a fẹ 'nikeji wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "B'o ti wu ki a gbọn to, a o f'aiye yi sile",
                        "Ọjọ idajọ ku si deede, Maria ṣ'amọna wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "223",
            Title = "AYABA ORILẸ EDE",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "F. A. Ọnasanya (Mrs.)",
            Chorus = new List<string>
            {
                "Maria Mimọ Oninure,",
                "Ayaba Orilẹ Ede,",
                "Awa ọmọ Rẹ nkepe Ọ o",
                "Ma ṣai tẹti si wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ayaba Mimọ a nki Ọ",
                        "Iwọ ni irawọ okun",
                        "Ṣọ wa ninu ewu",
                        "Gba wa lọwọ ibi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya Mimọ jọwọ o",
                        "Iwọ ni ayanfe wa",
                        "Ran wa lọwọ o",
                        "Bẹbẹ fun wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun sunmọ wa",
                        "Iwọ ni alaabo wa",
                        "F'ona han wa o",
                        "Bẹbẹ fun wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya Mimọ, gbọwọ wa",
                        "Iwọ l'Oluranlowo wa",
                        "Ṣipẹ fun wa",
                        "F'ona han wa o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "224",
            Title = "MARIA",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Maria, Maria, Maria",
                "Ayaba Mimọ Alagbara julo",
                "Ayaba Orilẹ-Ede A kepe Ọ o",
                "Wundia Ologo gb'ebẹ wa",
                "Dakun o, a kepe Ọ o Maria.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ayaba Mimọ, a kepe Ọ o",
                        "Iya Ọlọrun jọwọ gbọ ti wa",
                        "Ran wa lọwọ Maria, Ayaba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ayaba Mimọ Orisun ayọ",
                        "Alagbara julo, wa gbọ ti wa",
                        "Ran wa lọwọ Maria, Iya Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ran wa lọwọ Ayaba Mimọ",
                        "Iya Ọlọrun awa wolẹ",
                        "F'ona han wa Maria, wa ṣ'amọna wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya Oniwa-pipe a de",
                        "Lati f'ore wa han si Ọ o",
                        "Jọwọ wa gbọ Maria, Ayaba ọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun wa ran wa lọwọ",
                        "Awa Ọmọ Rẹ mbẹbẹ",
                        "Iya Mimọ Maria, f'eti si ẹbẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iya Alagbara ran wa lọwọ",
                        "A nkepe Ọ wa da wa lohun",
                        "Jọwọ wa gbọ Maria, Ayaba ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "225",
            Title = "IYA MIMỌ A JUBA RẸ",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya mimọ ye o, a juba Rẹ",
                        "Maria Mimọ Iya oninu rere",
                        "Iya aanu jọwọ bẹbẹ fun wa o",
                        "Lọdo Jesu Olupese Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iya pipe a de o, gbọ ti wa",
                        "Ran wa lọwọ Iya olododo",
                        "Iya tootọ jọwọ fire fun wa o",
                        "K'a le sin Jesu Olupese Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iya ọlọla, a wolẹ l'ẹsẹ Rẹ",
                        "Tu wa ninu Iya Alagbara",
                        "Iya Mimọ jọwọ ṣe wa lọmọ o",
                        "K'a le yin Jesu Olupese Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya Jesu a de o, wa gb'ore",
                        "Ṣe wa ni pipe Iya oninu rere",
                        "Wa f'ona han wa t'awa yio fi d'ọrun o",
                        "K'a le ba Jesu Olupese wọle ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "226",
            Title = "MARIA MIMỌ A KEPE Ọ",
            Category = "ORIN SI MARIA WUNDIA",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Maria Mimọ a kepe Ọ o",
                "Ayaba Ọrun",
                "Maria Mimọ a kepe Ọ o",
                "Ayaba Ọrun",
                "Wa gb'ẹja wa l'aiye nibi",
                "Ayaba Ọrun",
                "Mu wa de ibi alafia",
                "Ayaba Ọrun",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iwọ n'Iya Ọlọrun Ayaba Ọrun",
                        "Ti a loyun Rẹ laini ẹsẹ kẹsẹ Ayaba Ọrun",
                        "Ireti awa ẹlẹsẹ Ayaba Ọrun",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Wundia Ologo julo Ayaba Ọrun",
                        "Ti nyo 'bọ bi oọrun owurọ Ayaba Ọrun",
                        "Ti o l'ewa bi osupa Ayaba Ọrun",
                        "Mu wa ka le jẹ Tire Ayaba Ọrun",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọla julo ninu ẹda o Ayaba Ọrun",
                        "Onisuru julo ninu ẹda o Ayaba Ọrun",
                        "Ti Baba ti da l'ola Ayaba Ọrun",
                        "Gba wa sinu agbo Rẹ Ayaba Ọrun",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oloye julo ninu ẹda o Ayaba Ọrun",
                        "Ayaba ti Ẹmi Mimọ o Ayaba Ọrun",
                        "Wa sọ wa di mimọ Ayaba Ọrun",
                        "K'a le maa wu Ọmọ Rẹ Ayaba Ọrun",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ l'awa gbọjule Ayaba Ọrun",
                        "Iwọ l'awa f'ehinti Ayaba Ọrun",
                        "Wa fun wa ni Iforiti Ayaba Ọrun",
                        "K'a le maa yin Ọ l'ọrun Ayaba Ọrun",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "K'a lejọ yin Ọlọrun Baba Ayaba Ọrun",
                        "K'a lejọ yin Ọlọrun Ọmọ Ayaba Ọrun",
                        "K'a lejọ yin Ẹmi Mimọ Ayaba Ọrun",
                        "Titi aiye ainipẹkun Ayaba Ọrun",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "227",
            Title = "AIYE L'AJO",
            Category = "ORIN FUN ISINKU",
            Author = "H. A. Ọrẹdipe",
            Chorus = new List<string>
            {
                "Ara ẹ ma jẹ k'a gbagbe",
                "Pe aiye l'ajo",
                "Ọrun n'ile wa",
                "O pe ni, o ya ni,",
                "Iku ni lati mu wa lọ,",
                "Ẹrin loni, ẹkun lọla,",
                "Aiye l'ajo, ọrun ni 'le wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nigbati a ba wa l'aiye",
                        "Nigbati a wa l'aàye wa",
                        "Ohun aiye a jọ wa loju",
                        "Bẹni pe a ko ni ku titi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Owo at'ola asan ni",
                        "Ipo at'oro ofo ni o",
                        "K'a ma jẹ ki wọn fọ wa loju",
                        "K'a ba le r'ohun t'ise t'ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ojiji firi n'ile aiye jẹ",
                        "Arinrin ajo ni gbogbo wa o",
                        "Ẹ jẹ k'a f'eyi ṣe iranti",
                        "K'a ma ṣe huwa igberaga.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Igbese n'iku ẹ jẹ k'a ronu",
                        "Iba j'Ọmọde tabi agba",
                        "Iba s'ọba tab'Ọmọde",
                        "Iku ni lati mu wọn ṣa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Boya l'owurọ, boya alẹ",
                        "Boya ajin mẹfa tab'osan gangan",
                        "Iku a de were b'eji alẹ",
                        "Ẹ jẹ k'a tete gbaradi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "K'a kepe Jesu Oluwa",
                        "K'o tọ wa s'ona l'ọjọ gbogbo",
                        "K'o ma jẹ k'aiye fo wa loju",
                        "K'a ma padanu ile ayọ.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹnyin t'o nṣe igberaga",
                        "Ẹnyin t'ohun aiye kun loju",
                        "T'ẹ ba sun l'alẹ k'ẹ ranti pe",
                        "Owo at'ola asan ni o.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Nigbati a ba p'oju de",
                        "Nigbati a k'aiye p’odigbọse",
                        "Yio ku wa pelu iwa wa",
                        "Ọjọ atisun ọjọ nla ni.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "228",
            Title = "ỌRUN RERE LO NLỌ",
            Category = "ORIN FUN ISINKU",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Ara ẹ ma sọkun (2ce)",
                "Onigbagbo atata",
                "T'o ba lọ jẹ 'pe Olodumare",
                "Ọrun rere l'o nlọ",
                "Ọrun iye ni.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹni t'aa jọ nje",
                        "Ẹni t'aa jọ nmu",
                        "L'o yi pada",
                        "To wa f'ile bora bi aṣọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹni lọ s'oja",
                        "Lo npada sile o o",
                        "Aiye l'oja",
                        "Ọrun ma ni'le o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O d'arinnako",
                        "O tun d'oju ala o",
                        "O d'Ọjọ ikẹhin",
                        "K'a to f'oju kan 'ra.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin ara mi",
                        "Ẹyin eniyan mi",
                        "Aiye wa yi",
                        "Fun igba diẹ ni.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iku o d'Ọjọ",
                        "Arun o d'osu",
                        "Ẹni wa l'aiye",
                        "Ko sise rere.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ki lo mbẹ l'aiye",
                        "Ti a le joko ti",
                        "Afẹ aiye",
                        "Afọwọba-fi-sile ni.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ara ti a gbe wọ",
                        "Inu ile l'a ti mu",
                        "A o bọ sile",
                        "Ko ba erupẹ ile lọ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Onigbagbo",
                        "Ranti Ajinde",
                        "Oluwa Jesu",
                        "L'o ṣẹgun iku o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "229",
            Title = "ỌLỌRUN WA",
            Category = "ORIN FUN ISINKU",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Ọlọrun wa, Edumare Baba wa",
                "Baba l'a o maa bẹ",
                "L'orukọ Jesu Kristi",
                "Fun ẹmi oloogbe",
                "Ni isimi ailopin.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olodumare Ọba aye,",
                        "Ẹmi ọmọ Rẹ",
                        "K'o simi lọdọ Rẹ",
                        "Baba o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olu-Ọrun ati aiye,",
                        "F'aanu w’Ọmọ Rẹ,",
                        "T'o yẹ 'ra s'ọdọ Rẹ",
                        "Baba O.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O yipo pada lọ 'le",
                        "Ifẹ Baba awa,",
                        "L'o p'ẹni t'o sun lọ",
                        "Ifẹ ni.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olu-Ọrun ati aiye,",
                        "F'ibukun rere Rẹ",
                        "Fun ẹnit'o sun lọ",
                        "Jọwọ o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹ gb'ohun s'oke, ẹ s'ope",
                        "Aiku l'Ọba awa,",
                        "Yio mu u jinde",
                        "Pẹl'ayọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "230",
            Title = "ONIGBAGBỌ ODODO",
            Category = "ORIN FUN ISINKU",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Onigbagbọ ododo, mura, mura",
                "Aiye l'ọja, ọrun n'ile,",
                "Tete mura k'alẹ rẹ ba dara,",
                "Ọrun n'ile.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Igba ti mo sun ti mo ji,",
                        "Ti mo ronu mi wo nibo mo lọ?",
                        "Iku o ma pẹ, b'eni r'ajo ni ṣe",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Igba t'a ba wa l'ominira",
                        "K'a ronu wa wo b'oti ri",
                        "F'ẹsẹ sile nitori atisun rẹ",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Igba ti mo wo 'ṣe iyanu t'Oluwa ṣe",
                        "Iku o ma pẹ, b'eni sun l'ori",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Igba t'a d'aiye ki l'a mu wa?",
                        "Igba t'a o pada ki l'a o mu lọ?",
                        "Iku ko m'Ọlọrọ ko m'ẹnikan",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Igba t'aba wa ninu aiye",
                        "K'afi t'Oluwa s'okan ṣaju ohun gbogbo;",
                        "Gba iku ba de a o le ṣe ohunkohun",
                        "Ọwọ at'ẹsẹ, o ti rọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Igba t'a ba wa ninu aiye,",
                        "Owo, at'ola asan ni",
                        "Ọjọ atisun ṣe wọn yio fo loju wa",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Bẹru Oluwa ṣaju ohun gbogbo",
                        "Maa gbadura ki o ba l'ẹṣu lọ.",
                        "Aiye l'ọja, ọrun ni'le,",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọrun n'ile onigbagbọ ẹ ṣọra;",
                        "Iku o d'Ọjọ, arun ko d'osu,",
                        "Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ko si ti pe a o jẹ, a o mu;",
                        "Aya at'Ọmọ wọn o fi wa sile;",
                        "O wa ku ẹ, ku'wa rẹ. Oṣe, Oṣe, Oṣe.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ile aiye asan, imule-m'ofo",
                        "L'Ọjọ atisun, a o pada d'iyẹpe o",
                        "Yara; yara yiwa pada.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "231",
            Title = "L'ỌJỌ IKU",
            Category = "ORIN FUN ISINKU",
            Author = "C. S. O. Balufe",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "L'Ọjọ iku Maria mimọ ṣ'amọna mi o,",
                        "Ki mba le ri Jesu.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "O, Jesu mi o (3ce)",
                        "Ọkan mi ko le fẹ Ọ ku.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "L'Ọjọ iku Josefu mimọ ṣ'amọna mi o,",
                        "Ki mba le ri Jesu.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "L'Ọjọ iku Angeli mimọ ṣ'amọna mi o,",
                        "Ki mba le ri Jesu.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "232",
            Title = "ONIGBAGBỌ AIYE",
            Category = "ORIN FUN ISINKU",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Onigbagbọ aiye",
                        "Ẹ mura ọjọ nlọ",
                        "Ẹda ko ni 'bugbe",
                        "Ninu aiye ti awa wa",
                        "Ọjọ kan mbọ ọjọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ọrun nile (2ce) ara mi",
                        "Ọrun nile ara mi ẹ jẹ a mura",
                        "Aiye l'oja Ọrun ni'le (2ce)",
                        "Iku ko l'Ọjọ, iku l'osu",
                        "Gedegbe ni nyọ",
                        "O ṣe o, Ara mi - Mura o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Onigbagbọ aiye",
                        "Ọjọ Oluwa de o",
                        "Gbese ni'ku jẹ",
                        "Ẹda, ko s'ẹni ti ko ni san",
                        "Ọjọ kan mbọ mura siwa rẹ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Onigbagbọ aiye",
                        "Ile ewu laiye ṣe",
                        "Igba a de'nu aiye, o jẹ ọjọ ẹrin o",
                        "Igba iku bade, o jẹ ọjọ idaro",
                        "Ṣugbọn ọjọ kan mbọ, ọjọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onigbagbọ aiye, ronu rẹ daradara",
                        "Ile aiye ti awa yi",
                        "Asan ni, ara mi",
                        "Alafia kan kosi",
                        "Lori aiye ti awa wa;",
                        "Ọjọ kan mbọ ọjọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "K'oto omije l'a wa yi",
                        "Orisun ewu l'aiye nṣe",
                        "Ẹda inu aiye",
                        "Ranti pe ọjọ kan mbọ",
                        "Ọjọ kan mbọ, ọjọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Onigbagbọ aiye",
                        "F'ẹsẹ sile ki o ṣọra",
                        "To ba r'ijẹ titi",
                        "Ranti pe opin mbẹ fun o",
                        "Ọjọ kan mbọ, ọjọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ọla ko gbeni bori",
                        "Ọrọ igbala ti mbẹ l'ọrun",
                        "Iyi ko ni fun ọ laye",
                        "Lati lọ s'ọrun",
                        "Iwa ni yio b'oniwa",
                        "D'ẹnu saare",
                        "Ọjọ kan mbọ ọjọ Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "233",
            Title = "IKU NI ERE ẸṢẸ",
            Category = "ORIN FUN ISINKU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo wọle aiye lọṣu u )",
                        "Ẹmi ko ri ayọ kan nibẹ ) 2ce",
                        "Owo loni, osi lọla",
                        "Afẹ aiye asan ni.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iku ma ni ere ẹsẹ",
                        "A ni lati ku dandan ni",
                        "Baba, dakun o, ma jẹ a pofo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo wọle aiye, mo mi nu )",
                        "Ẹmi ko ri adun kan nibẹ ) 2ce",
                        "Ijo loni, ofo lọla",
                        "Ile aiye asan ni",
                        "Iku ma ni ere ẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo wọle aiye mo yera )",
                        "Ẹmi ko ri iyi kan nibẹ ) 2ce",
                        "Ere loni, iya lọla",
                        "Ara aiye buru o",
                        "Iku ma ni ere ẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo wọle aiye mo pinnu )",
                        "Ẹmi ko fẹ ọla kan nibẹ ) 2ce",
                        "Ọla loni, iya lọla",
                        "Ile aiye ti gbo mi",
                        "Iku ma ni ere ẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A wa'le aiye a tun nlọ )",
                        "Awa ko le yo nkan nibẹ ) 2ce",
                        "A o rele wa l'ọrun",
                        "Iku ma ni ere ẹsẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "234",
            Title = "AIYE LỌJA ỌRUN NILE",
            Category = "ORIN FUN ISINKU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "B'oti wu k'ẹniyan jẹ )",
                "O ni lati ku dandan ni ) 2ce",
                "Aiye lọja ara wa",
                "Ọrun ma n'ile.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nile aiye a j'alejo, Ọrun ma nile",
                        "Ọja lasan laiye o, Ọrun ma nile",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ile aiye ile ọrọ, Ọrun ma nile",
                        "Ẹwa aiye asan ni, Ọrun ma nile",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ile aiye a ṣa ọ ti, Ọrun ma nile",
                        "Ilu mimọ mbẹ l'ọrun, Ọrun ma nile",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Afẹ aiye a gbe ọ ti, Ọrun ma nile",
                        "Ogo pipe mbẹ l'ọrun, Ọrun ma nile",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ile aiye l'a gbe mọyi, Ọrun ma nile",
                        "Adakedajo mbẹ l'ọrun, Ọrun ma nile",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "235",
            Title = "ENIYAN RANTI PE IKU MBẸ",
            Category = "ORIN FUN ISINKU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Eniyan ranti pe erupẹ ni 'wọ,",
                "Iwọ yio tun pada si erupẹ lọla.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "L'atete kọṣe l'Ọjọ kẹfa ida aiye",
                        "Ọlọrun fi erupẹ m'ara eniyan",
                        "O da ni pipe O mi ẹmi iye si",
                        "Eniyan d'ọlọla tan o nyan kiri",
                        "Oun yio tun pada si erupẹ lọla.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "K'eniyan ṣọra ko ma gbẹkẹle aiye",
                        "Aiye ko lo tara, o ntan 'niyan",
                        "Eniyan ma k'aiye kun, iku mbẹ gidi",
                        "Iwọ yio tun pada si erupẹ lọla.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "K'eniyan mura ọjọ kẹhín to wọle",
                        "Iku ko mọ awada, o npa 'niyan",
                        "A p'ọlọla tan, a mu ẹmi rẹ lọ",
                        "Eniyan ranti iku, iku mbẹ gan ni,",
                        "Iwọ yio tun pada si erupẹ lọla.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu jọwọ o wa mu wa rin ka wọle",
                        "Ile Rẹ pataki l'ọna iye",
                        "Ṣọ wa ka dele, ka l'ayọ to ga julo",
                        "Ọgbagba-ti-ngba-'raiye ṣe wa ye lọmọ",
                        "Jọwọ ye, f'ayọ kari, dariji wa o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "236",
            Title = "ILE AIYE ILE ASAN",
            Category = "ORIN FUN ISINKU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ile aiye, ile asan, jọwọ ki l'ayọ rẹ",
                "Bi mo ba gbẹkẹ l'Oluwa",
                "Abuse ti buse.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Kini ka fun Ọ Oluwa wa",
                        "Jesu Kristi Ọba Ogo",
                        "Ọpẹ lo yẹ wa ka ma da",
                        "Ka ma yin Ọ o l'ọjọ gbogbo",
                        "Ma fi wa sile Edumare",
                        "L'aiye wa o Baba rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Kini ka fi dupẹ oore gbogbo",
                        "T'o tọdọ Rẹ wa Oluwa wa",
                        "Kilo tun yẹ wa j'Ọpẹ dida",
                        "Ka tun yin Ọ o gidigidi",
                        "Ma fi wa sile Edumare.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fun wa l'ọgbọn lati mọ ohun gbogbo",
                        "T'a o fi sin Ọ o b'o ba ti yẹ",
                        "Jẹ k'a sin Ọ d'ọjọ iku",
                        "D'ọjọ iku, iku rere",
                        "Ma fi wa sile Edumare.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa Mimọ Ọloore",
                        "Olodumare Ọba Ogo",
                        "Sure fun wa titi dalẹ",
                        "K'a le sin Ọ o l'ọjọ gbogbo",
                        "Ma fi wa sile Edumare.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "L'ọjọ ikẹhin ọjọ to ga",
                        "Ti gbogbo wa y'o jẹ ipe Rẹ",
                        "Ọrun rere l'awa nwa",
                        "Mu wa de 'bẹ ni 'le wa",
                        "Ma fi wa sile Edumare.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "237",
            Title = "O RE 'LE O",
            Category = "ORIN FUN ISINKU",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "O re ile o (4ce)",
                "…….re 'le o,",
                "…….g'oke odo",
                "Erin wo",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "lọ s'ọrun o……..",
                        "……..re 'le o",
                        "O jẹ Ọlọrun n'ipe",
                        "Erin wo…….",
                        "O ṣe, O ṣe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O ṣe t'Ọlọrun o",
                        "………rẹ 'ra sile",
                        "O fi t'Ọlọrun l'eke",
                        "Erin wo…….",
                        "O ṣe, O ṣe.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "K'o simi l'ọrun o",
                        "Ọlọrun gbọ wa o",
                        "K'o simi l'ọrun o",
                        "Erin wo",
                        "O ṣe, O ṣe.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O ṣe gudugudu meje o",
                        "……….s'ohun meje o",
                        "Ẹ wo iṣẹ Ọlọrun o",
                        "Erin wo…….",
                        "O ṣe, O ṣe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "238",
            Title = "AWỌN EMI T'O NJIYA",
            Category = "ORIN FUN ISINKU",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Ṣaanu wọn (4ce)",
                "Awọn Emi t'o njiya",
                "Ninu Ina Iwẹnumọ",
                "Ṣaanu wọn.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa nkigbe pe Ọ,",
                        "Iwọ Olugbala,",
                        "Ṣaanu f'awọn Ọmọ odo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ Ọlọrun aanu",
                        "Ti ko ṣe 'ku ẹlẹsẹ",
                        "Ṣaanu f'awọn Ọmọ odo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ Ọlọrun otito",
                        "Iwọ Ọlọrun iye",
                        "Ṣaanu f'awọn Ọmọ odo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ajinde",
                        "Iwọ l'Olugbala",
                        "Ṣaanu f'awọn Ọmọ odo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwọ l'awa gbọjule",
                        "Iwọ l'awa f'ehinti",
                        "Ṣaanu f'awọn Ọmọ odo Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "239",
            Title = "ORIN FUN IJE IPE RERE",
            Category = "ORIN ITANKALE IGBAGBO",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ o, fun wa ni Saserdoti ọmọ ibile.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jọwọ wa, Baba Mimọ o, jọwọ wa.",
                        "Fun wa ni Saserdoti ọmọ ibile",
                        "Jọwọ wa, Olugbala o, tẹ'ti si wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olodumare Ọba Mimọ, tẹ'ti si wa o, Baba rere",
                        "Wa pese ayanfẹ Rẹ, ti yio ṣe iṣẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mẹtalọkan a mbẹ Ọ, jẹ k'alẹ ri ọmọ ibile",
                        "Ti yio f'ara rẹ ji lati ṣe iṣẹ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olugbala Ọba Mimọ, jẹ ki igbagbo Rẹ",
                        "Tan kakiri orilẹ ede, wa mi si wa o, Baba rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Olugbala lo wi pe, Emi yio fi aṣọ igbala",
                        "Bo awọn Ojise Ọlọrun ti Sioni.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹmi Ọrun dakun ye, wa mi si orilẹ ede",
                        "Lati le ri awọn eniyan ti yio f'ara wọn ji fun Ọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "240",
            Title = "OLUWA FẸRAN MI",
            Category = "ORIN ITANKALE IGBAGBO",
            Author = "Alufaa T. M. Lesanmi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oluwa fẹran mi",
                        "Mo gba daju Oluwa fẹran mi (2ce)",
                        "O da mi",
                        "O kẹ mi",
                        "Ayọ mi kun",
                        "Oluwa fẹran mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo ji mo juba Rẹ",
                        "Baba Mimọ mo ji mo juba Rẹ (2ce)",
                        "Ọba iye",
                        "Onibu-ọrẹ",
                        "Olutunu",
                        "Mo ji mo juba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo ba wọn jẹ 'pe rere (2ce)",
                        "Mo gbọ t'Olu-ọrun",
                        "Mo sun mọ Baba",
                        "Mo gb'aye rere",
                        "Ayọ mi kun",
                        "Mo ba wọn jẹ pe rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Afẹ aiye ofo ni (2ce)",
                        "Ọla aiye ofo ni",
                        "Sun mọ Baba",
                        "Gb'aiye rere",
                        "K'o f'ifẹ gbe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oluwa gbọ t'emi (2ce)",
                        "Ani, Oluwa gb'ẹbẹ mi",
                        "Aiye ti gbimọ",
                        "Wọn l'oun ibi",
                        "Mo bẹ Ọ ye",
                        "Oluwa gbọ t'emi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "N o gb'ade ogo (2ce)",
                        "Mo gba daju, n o gba'de ogo",
                        "B'aiye gbogun",
                        "B'o gbona jan-in-jan-in",
                        "Ma di m'Olu",
                        "N o gb'ade ogo.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "O ṣe Olu-Ọrun (2ce)",
                        "Ani ọpẹ Olu-Ọrun",
                        "Mo dupẹ Baba",
                        "Mo dupẹ Ọmọ",
                        "Ẹmi Mimọ",
                        "O ṣe Olu-Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "O tọ mi s'ona rere (2ce)",
                        "O gbe mi sipo rere",
                        "Oluwa ṣeun",
                        "Mo dupẹ Baba",
                        "Ayọ mi kun",
                        "O tọ mi s'ona rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "241",
            Title = "IYIN OLUWA",
            Category = "ORIN ITANKALE IGBAGBO",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "Kọrin s'Ọba Mimọ; onilu ẹ tẹ ra mọ (2ce)",
                "Ẹgbẹ akọrin o: gbogbo yin o ẹ gberin.",
                "Dùrú wura ko maa dun; Ipe fadaka maa fun o",
                "Gbogbo agbaiye o, ẹ gbọhun didun s'oke",
                "S'Ọba oninure, ẹni to ṣeun fun wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ọmọ rẹ to fi dawa l'ola",
                        "Ẹni t'o ku'ku ẹsin fun wa",
                        "O fara Rẹ ji nitori ẹlẹsẹ",
                        "O s'aiye wa d'otun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọ'fẹna iye da wa l'ola",
                        "O tọka s'ọdọ Baba fun wa",
                        "Ẹmi Mimọ Rẹ l'o tun fi sile",
                        "Lati dari wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fun awọn t'o f'ara wọn ji",
                        "Awọn to ka afẹ aiye s'ofo",
                        "Awọn t'o jẹwọ Jesu Kristi",
                        "D'oju iku wọn.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "F'awọn t'o fi ile wọn sile",
                        "Ti wọn lọ s'ilu ailara o",
                        "Lati waasu f'awọn alaimọ",
                        "Ni gbogbo agbaiye.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "F'awọn t'o n ṣiṣẹ lọwọ nisisiyi",
                        "Mu igbagbo wọn duro ṣinṣin",
                        "Ninu irumi aiye yi o",
                        "Tọ wọn si ọna Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "242",
            Title = "ORIN FUN AWON ALUFAA",
            Category = "ORIN ITANKALE IGBAGBO",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Baba Mimọ ṣ'akoso ọmọ Rẹ (2ce)",
                "Ti o f'ara rẹ ji lati jẹ ojise Rẹ",
                "Jẹ alaabo rẹ a mbẹ Ọ o, Ọlọrun Eduma",
                "Jọwọ o, a mbẹ Ọ o, wa gbọ ti wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Tọ ọ si ona rere Amin o, Amin Amin",
                        "Jẹ alaabo rẹ “",
                        "Tan imole Rẹ yi i ka “",
                        "Mẹtalọkan ran an lọwọ “",
                        "Lati maa ṣe'fẹ Rẹ “",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ran an lọwọ Oluwa Amin o, Amin",
                        "Lati jẹ atona rere “",
                        "Fi ifẹ Rẹ baa gbe “",
                        "Baba Mimọ ran an lọwọ “",
                        "Lati maa ṣe'fẹ Rẹ “",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa fun Un l'oye Rẹ Amin o, Amin Aṣẹ",
                        "Lati sin Ọ b'oti yẹ “",
                        "F'ibukun Rẹ baa gbe “",
                        "Oyigiyigi ran an lọwọ “",
                        "Lati f'iyin fun Ọ “",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "243",
            Title = "HA, Ẹ BA MI YO",
            Category = "ORIN ITANKALE IGBAGBO",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ha, ẹ ba mi yọ, ẹ ba mi yọ; Olodumare lo da mi l'ola (2ce)",
                        "N'g o maa f'ogo f'Oluwa",
                        "Yungbayungba ni mo nyọ nigbati mo mọ",
                        "Jesu l'Ọba ninu ọkan mi",
                        "O fun mi l'ayọ, ọkan mi balẹ Aleluya",
                        "Ọlọrun Ayọ lo da mi si",
                        "Ọpẹ ni temi l'ọjọ gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ha' mo jo, mo yọ, mo jo; mo yọ; Olodumare lo da mi si (2ce)",
                        "N'g o maa kọrin s'Oluwa",
                        "Gbẹdẹgbẹdẹ ni mo l'ayọ nigbati mo gba Jesu",
                        "l'Ọba ninu ọkan mi",
                        "O gbe mi leke, mo de'nu ọla Aleluya",
                        "Ọlọrun Ayọ lo yẹ mi si",
                        "N'g o f'ara mi f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ha, ara, ẹ yọ, ẹ jo ẹ yọ; Olodumare lo da wa l'ola (2ce)",
                        "A o fi'yin fun Un l'ọjọ gbogbo (2ce)",
                        "Gbẹdẹgbẹdẹ ni yio rọrun bi iwo ba gba Jesu",
                        "l'Ọba t'okan rẹ",
                        "A gbe ẹ leke, wa a ni ayọ Aleluya",
                        "Awimayehun a da ẹ l'ola",
                        "O o maa yọ ni l'ọjọ gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "244",
            Title = "EMI YIO RE 'LE OLUWA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Jerome Ojo",
            Chorus = new List<string>
            {
                "Emi yio re 'le Oluwa",
                "Pẹlu ayọ o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nitori ile Oluwa ni",
                        "Emi yio gb'ero rere si.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nitori awọn eniyan mi",
                        "Ki alafia Rẹ jẹ tiwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A fi suru duro ṣinṣin",
                        "Gbọ dura ọmọ ọdọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fun wa ni 'dẹra Oluwa",
                        "Fi otitọ Rẹ han fun wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awọn t'o bẹru Rẹ Oluwa",
                        "Jọwọ fun wọn ni 'gbala Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Otitọ, ododo, aanu Rẹ",
                        "Alafia Rẹ k'o jẹ tiwa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "F'ohun 're ji wa Oluwa",
                        "Fun wa ni ọpọ ikore rere.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Fi ododo Rẹ siwaju wa",
                        "Ki o jẹ amọna fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "245",
            Title = "IKORE MA TUN DE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Ikore maa tun de",
                "Aye ọpẹ ma tun ṣi silẹ",
                "Fun gbogbo wa",
                "Awa yio sọpẹ o",
                "F'Eledumare, ka ma pofo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Oun lo ti pa wa mọ",
                        "Ninu ewu gbogbo",
                        "Oun lo to mu wa yẹ, titi doni",
                        "Ẹ sure tete, Ẹ dupẹ fun Un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ ma ṣe farahan niwaju Oluwa",
                        "Li ọwọ ofo,",
                        "Arinu rode l'Olodumare",
                        "Adakẹ-dajọ l'Olodumare.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Onibu-ọla l'Ọlọrun wa",
                        "Onibu-ọla Alewileṣe",
                        "Onibu-orẹ a pese fun wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awọn adẹtẹ mẹwa kọ la mu lara da",
                        "Ọkan ṣoṣo lo wa sọpẹ fun Oluwa",
                        "Awọn mẹsan yoku ti gba b'miran lọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọba Olukore, bukun fun wa",
                        "Pa wa mọ titi o, Edumare ma",
                        "F'eyi ṣopin fun wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Edumare Olubukun",
                        "Bukun fun wa bukun fun ile wa, Olupese",
                        "Ka ma pofo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "246",
            Title = "AWỌN TI NFOMIJE FÚNRÚGBÌN",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Awọn ti nfomije fúnrúgbìn",
                "Wọn yio f'ayọ ka,",
                "Wọn yio f'ayọ ka (2ce)",
                "Awọn ti nfomije fúnrúgbìn",
                "Wọn yio f'ayọ ka.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nigbati Oluwa mu Sioni pada",
                        "Kuro ninu igbekun rẹ",
                        "O ya wa lẹnu jọjọ",
                        "A dabi ẹni ti nla ala o loju orun",
                        "Ẹrin gba enu wa",
                        "Ahan wa kọrin ayọ Si Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn keferi sọ wipe",
                        "Ohun nla ribiribi",
                        "L'Olodumare ṣe fun wọn.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa ṣeun o;",
                        "Ohun nla lo ṣe fun wa,",
                        "Awa nyọ ninu Baba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa da ayọ wa pada,",
                        "Bi iṣan omi ti nṣan lati gusu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹni to f'ẹkun rin lọ",
                        "Pẹlu irugbin lọwọ Rẹ.",
                        "Ibanujẹ yio d'ayọ fun yin",
                        "Ẹ o si ru ọpọlọpọ iti wọlé o.",
                        "Ogo ni fun Baba etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "247",
            Title = "ORIN OPE FUN AJỌDUN TABI IKORE\nẸ JỌ, Ẹ YỌ ṢẸṢẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ajọdun wọlé/Ikore lo de",
                        "Ara ẹ jọ o, ẹ yọ ṣẹṣẹ",
                        "Ajọdun wọlé/Ikore lo de",
                        "Ẹ wa f'iyin fun Ọlọrun Ọba (2ce)",
                        "Ẹ wa sọpẹ fun Oluwa t'o d'awa si d'oni o",
                        "Yin In o, t'ijo t'ayọ, yin In o.",
                    }
                },
                new Verse
                {
                    Number = "Egbe (A):",
                    Lines = new List<string>
                    {
                        "Mukulumukẹ (2ce)   Ẹ jọ ẹ yọ (2ce)",
                        "Ẹyin ara                   -do-",
                        "K'ẹ yin Baba             -do-",
                        "Ẹ f'ilu yin In              -do-",
                        "Ẹ f'ijo yin In              -do-",
                    }
                },
                new Verse
                {
                    Number = "Gbogbo Akọrin:",
                    Lines = new List<string>
                    {
                        "Ẹ jọ, ẹ yọ o si Ọba Edumare",
                        "Ẹ-yọ, Ẹ-jo.",
                        "Ọpẹ yẹ Ọ, Baba mimọ.", 
                    }
                },
                new Verse
                {
                    Number = "Egbe (B):",
                    Lines = new List<string>
                    {
                        "Baba mimọ a juba fun Ọ;",
                        "A dupẹ fun oore Rẹ              -do-",
                        "Ti O da wa si d'oni o              -do-",
                        "A wa sọpẹ fun Ọ                   -do-",
                        "Dakun, da wa si d'amọdun o -do-",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ajọdun wọlé/Ikore lo de",
                        "Ara ẹ f'iyin fun Ọba wa o",
                        "Ajọdun wọlé/Ikore lo de",
                        "Ẹ wa juba fun Onibu-Ọre (2ce)",
                        "Ẹ wa dupẹ fun Oluwa fun oore Rẹ lori wa",
                        "Yin In o, t'ijo t'ayọ, yin In o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ajọdun wọlé/Ikore lo de",
                        "Ara ẹ wa f'opẹ fun Oluwa o",
                        "Ajọdun wọlé/Ikore lo de",
                        "Ẹ damuso si Ọlọrun Ọba (2ce)",
                        "Ẹ gbadura s'Oluwa k'o da wa si d'amọdun o",
                        "Yin In o, t'ijo t'ayọ, yin In o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "248",
            Title = "ỌDÚN IKORE MA TUN DE O",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọun Ikore ma tun de o, o ma tun de (2ce)",
                        "Ẹ jẹ k'a fi 'yin f'Ọlọrun wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ọdún ọpẹ, ọdún ọpẹ",
                        "Ọdún ayọ, f'Ọmọ Ọlọrun (2ce)",
                        "F'owo rẹ yin Oluwa",
                        "M'ọpẹ rẹ wa, ọrẹ atata",
                        "M'ọpẹ rẹ wa, orẹ ododo",
                        "M'ọpẹ rẹ wa, m'ọpẹ rẹ wa",
                        "Anu Rẹ ma pọ o, ti o bukun fun wa (2ce)",
                        "Ohun ọgbin wa ndagba",
                        "Igi oko mi s'eso",
                        "Alafia to wa o Ọba Onibu-Ọre (2ce)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "L'ọdun yi, k'a kunlẹ ọpẹ",
                        "K'Ọlọrun k'o bukun fun wa. (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "K'Olodumare ṣaanu o, k'o ṣaanu",
                        "K'O fun wa lọpọ ikore rere (2ce)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olodumare bukun fun wa k'a s'amọdun",
                        "Olu ọrun jọwọ gbọ tiwa. (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "249",
            Title = "Ẹ JIJO ALAYỌ GBẸDẸMUKẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "F. O. Ọdẹyẹmi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'alafia Rẹ ba wa gbe Olukore",
                        "Yo wa ninu ọgbun ẹsẹ o Baba rere )",
                        "Ka ṣerere l'aiye wa o ki a to lọ )2ce",
                        "Baba rere, jọwọ ye o, diwa mu o",
                        "Jọwọ dakun, dakun, dakun ye o.",
                        "Baba ṣọ wa d'amọdun.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jo o ara wa o",
                        "Ẹ jijo alayọ gbẹdẹmukẹ )",
                        "Mukulumukẹ, Mukulumukẹ, )2ce",
                        "Ẹ jijo alayọ gbẹdẹmukẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Fi 'bukun Rẹ ba wa gbe, Baba atata",
                        "Ka rowo na lasiko yi o, Baba rere )",
                        "Sẹri 'bukun Ọrun sori wa o, Baba, Baba ye gbọ )2ce",
                        "Baba rere, jọwọ ye o, diwa mu o",
                        "Jọwọ dakun, dakun, dakun ye o",
                        "Baba ṣọ wa d'amọdun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "F'otitọ rẹ ba wa gbe Olukore",
                        "Iwọ lagbojule lafẹhinti o, Baba o ṣeun )",
                        "Jehova dakun tẹwọ gb'ẹbo wa o )2ce",
                        "Baba ye gbọ",
                        "Baba rere, jọwọ ye o, diwa mu o",
                        "Jọwọ dakun, dakun, dakun ye o",
                        "Baba ṣọ wa d'amọdun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fi igbagbo rẹ ba wa gbe Baba iye",
                        "Tan Imọlẹ rẹ s'inu wa o Baba Mimọ",
                        "Jẹ ka le ṣe ifẹ rẹ o Baba laiye",
                        "Baba rere, jọwọ ye o, diwa ye o",
                        "Jọwọ dakun, dakun, dakun ye o",
                        "Baba dakun sọ wa d'amọdun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "250",
            Title = "MO SINMI LE Ọ BABA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Mo sinmi le Ọ Baba",
                "Mo sinmi le Ọ (2ce)",
                "T'aiye eṣu, ẹsẹ ko le gba mi lọwọ Rẹ",
                "Baba, mo sinmi le Ọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọrẹ ti mo mu wa niyi",
                        "Baba wa gba a",
                        "Ẹbun ti mo mu wa niyi",
                        "Baba wa fi bukun si i",
                        "Ninu eeri, Baba wẹ mi mọ nibẹ",
                        "Baba mo sinmi le Ọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọrẹ ti mo mu wa niyi",
                        "Baba wa gba a",
                        "Ẹbun ti mo mu wa niyi",
                        "Baba wa f'ibukun si i",
                        "Maṣai tẹwọ gba a",
                        "Bi i t'ẹbo Abeli",
                        "Baba mo sinmi le Ọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọrẹ ti mo mu wa niyi",
                        "Baba wa gba a",
                        "Ẹbun ti mo mu wa niyi",
                        "Baba wa f'ibukun si i",
                        "Kini mo le ni",
                        "Ti ki iṣe lat'ọdọ Rẹ",
                        "Baba mo sinmi le Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọrẹ ti mo mu wa niyi",
                        "Baba wa gba a",
                        "Ẹbun ti mo mu wa niyi",
                        "Baba wa f'ibukun si i",
                        "Ki l'ere wa",
                        "Bi ko ba ṣe ibukun Rẹ",
                        "Baba mo sinmi le Ọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọrẹ atinuwa niyi",
                        "Baba wa gba a",
                        "Ọrẹ at'okanwa niyi",
                        "Oun l'ore ti o ga",
                        "T'aiye, eṣu, ẹsẹ",
                        "Ko le j'ọba lori i rẹ",
                        "Baba mo sinmi le Ọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "251",
            Title = "ỌDUN IKORE WA L'ODE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "A. Adeboye",
            Chorus = new List<string>
            {
                "Ọdun Ikore wa l'ode,",
                "Ka sọpẹ f'Oluwa,",
                "Ọdun Ikore wa lo de o,",
                "L'awa n f'iyin f'Ọlọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka ranti oore Rẹ",
                        "N'ile at'oke d'ode Ọrun",
                        "Obangiji awa tunde tomotomo",
                        "Lati wa sọpẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka jijo, ijo ayọ,",
                        "Lati fi imo oore wa han fun",
                        "Baba loke awa dupẹ gidigidi",
                        "Dakun wa gb'Ọpẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka sọpẹ t'ijo-tayọ",
                        "Lati wa fi yin Ọba Ogo",
                        "Gbe wa nija, ran wa lọwọ, Ọba rere",
                        "Dakun wa gb'Ọpẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka kọrin aleluya",
                        "Ki tẹgbẹ tọgba si gberin",
                        "Ti wa lẹhin, tu wa ninu, Ọba rere",
                        "Dakun wa gb'Ọpẹ wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "252",
            Title = "PEREGEDE LA O YE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "A:-",
                    Lines = new List<string>
                    {
                        "Ajọdun de o, ajọdun de o, ajọdun de o",
                        "Ajọdun d'ode o (2ce)",
                        "Peregede la o ye t'ọmọtọmọ",
                        "Peregede la o ye t'ọmọtọmọ (2ce)",
                        "Ṣọ wa t'ọmọtọmọ - Aṣẹ",
                        "Ṣọ wa t'aratebi...- Aṣẹ",
                        "Ṣọ wa nile....... -  Aṣẹ",
                        "Ṣọ wa l'ode.......- Aṣẹ",
                    }
                },
                new Verse
                {
                    Number = "B:-",
                    Lines = new List<string>
                    {
                        "Ẹni ọdun ṣoju rẹ ko yọ dandan",
                        "Ara ẹ yọ, ara ẹ yọ",
                        "Ẹ yọ s'Oluwa, ẹ yọ s'Oluwa, ẹ yọ s'Oluwa (2ce)",
                        "Edumare Asọro-mayẹ",
                        "Wa sure fun wa Baba Mimọ.",
                        "Ilẹkun asenu.... Ti i Baba",
                        "Ilẹkun aibimo.... Ti i Baba",
                        "Ilẹkun iponju.... Ti i patapata Baba jare",
                    }
                },
                new Verse
                {
                    Number = "C:-",
                    Lines = new List<string>
                    {
                        "Ọdun de ara wa ẹ kun f'Ọpẹ",
                        "Ẹ f'Ọpẹ to ga yin Baba o",
                        "Ẹ jo, ẹ yọ, ẹ damuso",
                        "S'Oluwa loke to d'awa si",
                        "Onile-ayọ wa mu 'nu wa dun.",
                        "Ṣọ wa ni irin ajo, jẹ ka wa s'amọdun",
                        "Ye! dakun o Baba Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Peregun ọmọ rẹ lawoye",
                        "Peregede la o ye t'ọmọtọmọ.",
                        "Ṣaanu fun wa (3ce)  Baba Ọrun (2ce)",
                        "Ṣaanu fun wa (3ce)  Baba Ọrun (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "253",
            Title = "IKORE L'O DE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ikore lo de, ara, ẹ mọrẹ wa;",
                        "Ikore lo de o ẹ yọ (2ce)",
                        "Ẹ jo ẹ yọ si Olukore Ọba Onibuore",
                        "Ọpẹ yẹ Ọ o Baba Mimọ,",
                        "T'O da wa si d'Ọjọ oni o",
                        "Awa dupẹ o lọdọ Rẹ, ye Jehofa,",
                        "Edumare t'O da wa si o",
                        "O yẹ ka f'iyin fun Olukore Ọba rere.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Awa dupẹ o lọdọ Rẹ ye Baba",
                        "Awa dupẹ lọdọ Rẹ, ye, t'o da wa si o",
                        "A! Ara ẹ jo, ẹ yọ, ẹ yọ; si Olukore",
                        "Ọba Onibuore.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ikore l'ode, ara ẹ wa sọpẹ,",
                        "Ikore lo de o, ẹ yọ",
                        "Ẹ jo ẹ yọ si Olukore Ọba Onibuore )",
                        "Ẹ mọrẹ wa o, ẹ wa sọpẹ fun Olukore Ọba rere )2ce",
                        "Awa sọpẹ o lọdọ Rẹ, ye, Jehofa;",
                        "Edumare t'o da wa si o",
                        "Ẹ jẹ ka f'iyin fun Olukore Ọba rere. (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ikore l'ode, a wa lati dupẹ,",
                        "Ikore lo de o, ẹ yọ",
                        "A jo a yọ si Olukore Ọba Onibuore",
                        "Ara ẹ wa o, ẹ wa sọpẹ fun Olukore Ọba rere",
                        "Awa sọpẹ o lọdọ Rẹ, ye, Jehofa;",
                        "Edumare t'o da wa si o",
                        "O yẹ ka f'iyin fun Olukore Ọba rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "254",
            Title = "OKIKI IKORE MILẸ TITI",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Ki langbo, ki langbọ, ariwo nke tantan",
                        "Okiki milẹ ladugbo, p'ọdun ayọ o tun de.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ọmọde nraṣọ titun, agbalagba nra bata",
                        "P'ọdun Ikore Katoliki lo de o ara ba wa yọ",
                        "Ẹbẹ la n bẹ k'ajọdun 'kore yi o",
                        "Ko gbe wa korire (2ce)",
                        "Jehova Ọba nla, Edumare Ọba ogo",
                        "Ṣ'ore fun wa titi dalẹ: le 'pọnju lo fun wa",
                        "Oni adara, ọla a dara ṣe fila agba ngun rebate",
                        "Ẹbẹ la n bẹ k'ajọdun 'kore yi o, ko gbe wa korire.",
                        "A, B, A, B etc",
                    }
                },
                new Verse
                {
                    Number = "A:\nB:",
                    Lines = new List<string>
                    {
                        "Ara ẹ ṣami o",
                        "N'go jẹwọ orire ni t'emi",
                        "Mo bere iwọ nkọ?",
                        "N'go jẹwọ orire ni t'emi",
                        "A dara fun mi ṣe o",
                        "N'go jẹwọ orire ni t'emi",
                    }
                },
                
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jehova Ọba nla, Edumare Ọba ogo",
                        "Ṣ'ore fun wa titi dalẹ: le 'pọnju lo fun wa",
                        "Oni adara, ọla a dara ṣe fila agba ngun rebate",
                        "Ẹbẹ la n bẹ k'ajọdun 'kore yi o, ko gbe wa korire.",
                        "A, B, A, B etc",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "255",
            Title = "OLUKORE ỌBA MIMỌ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olukore Ọba Mimọ a de o lati wa f'ore wa fun Ọ.",
                        "Olukore Ọba Mimọ, a de o, A de o Olupese",
                        "Olu Ọrun jare wa gbọ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹnyin ara ẹ jo ẹ yọ ṣẹṣẹ (Lẹẹmẹji)",
                        "Ikore lo wọle (Lẹẹmẹji)",
                        "Ẹ jijo ayọ - Gbẹdẹmukẹ, Ẹ jijo ayọ Gbẹdẹmukẹ",
                        "Ikore lo wọle o, Ẹ jo ẹ yọ gbẹdẹmukẹ",
                        "Mukulumukẹ, mukulumukẹ ẹ jijo ayọ gbẹdẹmukẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olukore Ọba Mimọ a de o, lati wa f'Ọpẹ fun Ọ",
                        "Olukore Ọba Mimọ a de o, A de o Olupese.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olukore Ọba Mimọ a de o, dakun fun wa lore Ọfẹ",
                        "Olukore Ọba Mimọ a de o, a de o Olupese",
                        "Ṣọ wa ka le ṣe t'amọdun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "256",
            Title = "ARA Ẹ JO Ẹ JẸ K'A JỌ YỌ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ara ẹ jo ẹ jẹ ka jọ yọ",
                        "K'a wa dupẹ )",
                        "Kọrin iyin ọdun tun de o )",
                        "Kọrin ayọ, kọ tun kọrin ogo )2ce",
                        "Ara ẹ jo ẹ jẹ ka jọ yọ, k'a wa dupẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa sọpẹ, ẹ wa ka jọ sin )",
                        "Ẹ sare wa )",
                        "Gberin iyin, ọdun tun yipo )2ce",
                        "Gberin iyin, kọ tun gberin ẹyẹ )",
                        "Ẹ wa sọpẹ, ẹ wa ka jọ sin )2ce",
                        "Ẹ sare wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O da wa si onile ayọ )",
                        "A m'Ọpẹ wa )2ce",
                        "Baba gb'ẹbun t'a mu wa, fun Ọ )",
                        "Baba gb'ẹbun kọ tun gb'ore awa )2ce",
                        "O da wa si onile ayọ, a m'Ọpẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O ba wa gbe, O tun ṣọ wa o )",
                        "A tun r'ọdun )",
                        "Ọba Oke a wa dupẹ o )",
                        "Baba a yọ O ṣe Baba Ọrun )2ce",
                        "O ba wa gbe, O tun ṣọ wa o (2ce)",
                        "A tun r'ọdun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "257",
            Title = "AJỌDUN IKORE WỌLẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ajọdun Ikore wọlẹ ara ẹ jo ẹ yọ ṣẹṣẹ",
                        "Si Olukore Ọba rere, Ara ẹ jo ẹ yọ (2ce)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "(A) Ọdun de ka wa sọpẹ (2ce)",
                        "(B) Olukore wa gbọ tiwa jọwọ ye (2ce)",
                    }
                },
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "A & B: Ọdun Ikore yi o, dun jọjọ.",
                    }
                },
                new Verse
                {
                    Number = "A:",
                    Lines = new List<string>
                    {
                        "Ara ẹ yọ ṣẹṣẹ si Oluwa     Ikore yi dun",
                        "Ka f'ọpẹ f'Oluwa               o dun jọjọ",
                        "Ka f'ijo yin Baba                     -do-",
                        "Ibukun Oluwa ko ba wa gbe  -do-",
                        "A ṣe yi s'amọdun Ọ                -do-",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ajọdun Ikore l'ode ara ẹ maa f'iyin fun",
                        "Olukore Ọba wa, Ara ẹ ho ẹ yọ (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ajọdun Ikore lo de ara ẹ maa f'ilu at'orin",
                        "Yin Olukore Ọba, Ara ẹ jo ẹ yọ (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "258",
            Title = "ỌPẸ NI FUN Ọ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. Feyisitan",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọpẹ ni fun Ọ Baba Mimọ",
                        "Jọwọ wa gb'Ọpẹ wa Baba",
                        "Ọpẹ at'iyin lo yẹ Ọ o",
                        "Jọwọ wa gb'Ọpẹ wa Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awa o ma yin Ọ titi,",
                        "Jọwọ wa gb'Ọpẹ wa Baba",
                        "Ọpẹ at'iyin ni fun Ọ,",
                        "Jọwọ wa gb'Ọpẹ wa Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Anu Rẹ l'o gbe wa ro,",
                        "Jọwọ wa gb'Ọpẹ wa Baba",
                        "Igba wa n bẹ lọwọ Rẹ",
                        "Jọwọ wa gb'Ọpẹ wa Baba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fun 'bukun Rẹ tianri",
                        "Jọwọ wa gb'Ọpẹ wa Baba",
                        "Iyin ni fun Ọ t'Ọsan t'Ọrun",
                        "Jọwọ wa gb'Ọpẹ wa Baba.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Fun aabo Rẹ tianri",
                        "Jọwọ wa gb'Ọpẹ wa Baba",
                        "Nitori Jesu Ọmọ Rẹ",
                        "Jọwọ wa gb'Ọpẹ wa Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "259",
            Title = "OBANGIJI AWA TUN DE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "S. O. Ogundipẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọbangiji awa tun de, pẹlu iyin )",
                        "Fun oore Rẹ igba gbogbo )",
                        "Awa sọpẹ, Baba rere )2ce",
                        "Wa gba 'yin gb'Ọpẹ wa )",
                        "Edumare gb'Ọpẹ wa )",
                        "Oyigiyigi a de o )",
                        "Dakun, gb'ẹbọ wa )2ce",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tu wa lara Ẹmi Mimọ, gbe wa ni 'ja",
                        "Jẹ ka s'eso iwa rere,",
                        "Busi 'gbagbo gbogbo wa.",
                        "Jẹ k'iyin Rẹ jẹ tiwa )",
                        "Edumare ko jẹ tiwa )",
                        "Oyigiyigi a de o )",
                        "Dakun gb'ẹbẹ wa )2ce",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ran wa lọwọ Ẹmi Mimọ )",
                        "Fun wa ni 'mọ )2ce",
                        "K'a le mọ Ọ, Ni gba gbogbo )",
                        "Awa mbẹ Ọ, Baba rere )2ce",
                        "Ye jọwọ, ranti wa )",
                        "Edumare ranti wa )",
                        "Oyigiyigi a de o )",
                        "Dakun ma gbagbe wa )2ce",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Baba dakun, tu wa ninu )",
                        "Awa b'ẹbẹ )",
                        "Fun wa lọwọ ati ọmọ )",
                        "L'Ọjọ aiye wa gbogbo )2ce",
                        "Mi si wa, wa gbọ tiwa )",
                        "Edumare wa gbọ tiwa )",
                        "Oyigiyigi a de o )",
                        "Dakun, gb'ẹbẹ wa )2ce",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba, Ọmọ, Ẹmi Mimọ )",
                        "Dabobo wa )",
                        "Wa tọju wa ninu ewu )",
                        "A ke pe Ọ Baba rere )2ce",
                        "Tan 'molẹ Rẹ s'okan wa )",
                        "Edumare, ka le riran o )",
                        "Oyigiyigi a de o )",
                        "Dakun, gb'ẹbẹ wa )2ce",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "260",
            Title = "ỌPẸ, ỌPẸ, EDUMARE, ỌPẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Ọpẹ, Ọpẹ, Edumare Ọpẹ",
                "Ọpẹ lo yẹ (2ce) Edumare",
                "T'o nṣe ohun gbogbo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A ti wa ni inu ewu",
                        "A si tun pada bọ l'aiye",
                        "Ọpẹ lo yẹ f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A ti lọ si oju ogun",
                        "A si tun pada bọ l'ayọ",
                        "Ọpẹ lo yẹ f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ti lọ si ori omi",
                        "A si tun pada bọ l'ayọ",
                        "Ọpẹ lo yẹ f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "A ti fò ni oju ọrun",
                        "A si tun pada bọ l'ayọ",
                        "Ọpẹ lo yẹ f'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A dupẹ fun ẹnyin ara",
                        "Ẹnyin ọrẹ at'aladugbo",
                        "Ti ẹ wa ba wa y'ayọ yii",
                        "Ire akari gbogbo wa, aṣẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "261",
            Title = "BU S'AYO ARA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "S. O. Ogundipe",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bu s'ayọ ara (2ce)",
                        "Ara ẹ yọ, Ọdun ti de.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ara ẹ wa / Ara ẹ wa,",
                        "Ara ẹ yọ / Ara ẹ yọ",
                        "Ẹgbẹ ẹ wa / Ẹgbẹ ẹ wa,",
                        "Ẹgbẹ ẹ wa / Ẹgbẹ ẹ yọ,",
                        "Ore ẹ yọ / Ore ẹ wa",
                        "Ore ẹ yọ / Ore ẹ yọ",
                        "Bu s'ayọ ara etc.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tun m'ẹbun rẹ wa (2ce)",
                        "Fun Oluwa, to da wa si",
                        "Ara ẹ wa etc.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jẹ k'ayọ rẹ kun (2ce)",
                        "F'oore Oluwa to ṣe fun wa",
                        "Ara ẹ wa etc.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jẹ k'a fi 'dunnu (2ce)",
                        "Ati ayọ ṣe 'kore yi o",
                        "Ara ẹ wa etc.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu jọwọ ye (2ce)",
                        "Ko da wa si, d'ọdun t'on bọ",
                        "Ara ẹ wa etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "262",
            Title = "ORIN ỌPẸ ATI IYIN",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọbangiji mo mọrẹ wa, mo de lati fi 'yin fun Ọ",
                        "Jọwọ o, Baba rere, wa gb'Ọrẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Oyigiyigi Baba (2ce)",
                        "Mo jo mo yọ mo jo mo yọ",
                        "Mo wa f'Ọpẹ fun Ọ Ọba",
                        "Onibuọrẹ o, o ṣeun",
                        "Mo wa f'Ọpẹ fun Ọ, Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Fun ore Rẹ l'ori mi, mo de lati juba",
                        "Baba Mimọ jọwọ o, wa gb'Ọrẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "F'oju aanu Rẹ wo mi, Baba Mimọ jọwọ o",
                        "Ran mi lọwọ o Baba rere, wa gbọ igbe mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jọwọ sọ mi ninu ewu ati lọwọ awọn ọta",
                        "Ọbangiji mo mbẹbẹ, dari ẹsẹ mi ji mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "To mi si ona Rẹ ki n le sin Ọ bi o ti yẹ",
                        "Jọwọ o Baba rere, wa gb'Ọrẹ mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "263",
            Title = "GBOGBO ARA Ẹ WA KA DUPẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gbogbo ara ẹ wa ka dupẹ f'Ọlọrun wa",
                        "To da wa si d'Ọjọ oni o, a dupẹ o",
                        "Ka fi 'bukun f'Olodumare Ọlọrun wa",
                        "Olupese Baba Mimọ o, a juba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ ka jo, ẹ jẹ ka yọ",
                        "Ẹ kọrin Ọpẹ s'Olu Ọrun",
                        "Ka jẹ k'aiye mọ p'Ọlọrun ṣeore fun wa o",
                        "Oyigiyigi Atobiju a dupẹ o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Emi dupẹ mo tun dupẹ lọwọ Baba",
                        "F'oore to ṣe fun mi latesi mo dupẹ o",
                        "B'Ọmọde dupẹ oore ana a ri gba si",
                        "Emi otosi ẹlẹsẹ mo wa dupẹ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ko s'ẹyẹ meji to dabi ọkin n'igbo",
                        "Ko s'Ọba meji to dabi Ọlọrun o",
                        "Iwọ lajiki, lajiyin l'Ọjọ gbogbo",
                        "Olubukun Awimayehun a juba Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jẹ ka rowo na, ka ri jẹ ka ri mu",
                        "Kagan rọmọ bi, k'a b'oyun bi tibi tire",
                        "Ṣilẹkun aanu fun wa basiri wa",
                        "Jọwọ gba wa lọwọ ọta abinu eni.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "264",
            Title = "IWỌ MỌ IRO MI ỌLỌRUN",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Iwọ mọ iro mi Ọlọrun",
                "Ẹsẹ mi ko pamọ li odo Rẹ",
                "Iransẹ Rẹ li emi",
                "Fun mi ni oye Ọlọrun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Funfun gboo li ọrọ Rẹ",
                        "Ododo li Iwọ Ọlọrun",
                        "Emi oo juba Rẹ l'Ọjọ gbogbo",
                        "N'go o si maa p'ofin Rẹ mọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ṣe onigbọwọ mi fun rere",
                        "Ki o si kọ mi nipa ona Rẹ",
                        "Mo ji lati foribale fun Ọ",
                        "Oluwa gbọ ohun mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Tẹ'wọ gba ọrẹ iranse Rẹ",
                        "Ọba ajiki, Ọba ajiyin,",
                        "O fun ẹyẹ ni itẹ wọn,",
                        "O da oṣupa fun lilo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oorun m'akoko iwo Rẹ",
                        "O sọ okunkun di oru",
                        "Kiniun ndun ohun ode",
                        "O nwa ounjẹ ti yio jẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "O boju w'aiye, aiye wa riri",
                        "Iwọ p'oju mọ ara ko rọ wọn",
                        "Wọn pada si erupẹ wọn",
                        "Oluwa gbọ ohun mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Iwọ mọ ẹgọ mi Ọlọrun",
                        "Ibẹru Rẹ m'ara mi wa riri",
                        "Ẹsẹ mi ko pamọ li odo Rẹ",
                        "Omi ṣan sile li oju mi.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ṣe amọna mi Ọlọrun",
                        "Gba mi ninu ododo Rẹ.",
                        "Ki l'ere ẹjẹ Ọmọ Rẹ",
                        "Bi nko ba sin Ọ bi o ti yẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "265",
            Title = "OLUPESE A WA Ṣ'ỌDUN",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olupese am'Ọpẹ wa (2ce)",
                        "Jare gb'Ọpẹ wa (2ce)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Pese fun wa o (2ce)",
                        "Baba Onibuọrẹ",
                        "Pese fun wa o",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Olupese a m'owo wa (2ce)",
                        "Jare gb'owo wa (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olupese a wa ṣ'ọdun (2ce)",
                        "Jare j'ọdun y'abo (2ce)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olupese a tun dupẹ (2ce)",
                        "Jare m'aiye yẹ ni (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "266",
            Title = "A TI YỌ! A DUPẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
                "A ti yọ, A dupẹ, Awa sọpẹ lọwọ Rẹ Baba Olọore-ọfẹ (2ce)",
                "F'aabo Rẹ lori wa, ninu isin wa oni,",
                "Dakun wa gb'adura wa o, Olọore-Ọfẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa ọmọ Rẹ de o",
                        "Baba Mimọ, a de lati yin Ọ l'ogo o,",
                        "Olọore-ọfẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi a sun, t'Oluwa ni",
                        "Orukọ Rẹ nikan, to wa o, Ọlọrun Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ninu ewu o, wa gba wa Baba",
                        "Ninu idanwo, Iwọ l'a kesi Olọore o.",
                        "Olọore o, ti wa d'ọwọ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "267",
            Title = "IYIN NI FUN OLUWA ỌBA ỌRUN",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Iyin ni fun Oluwa Ọba Ọrun o",
                "Ẹ mura lati kọrin iyin si Oluwa",
                "Ẹ gb'ohun yin s'oke, ẹ yin Oluwa logo",
                "Ẹ dupẹ f'Ọba Olọore Olurapada wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ mọrẹ wa o, ẹ fi iyọnu f'Ọrẹ f'Oluwa",
                        "Ẹ jẹ ki a mura giri o",
                        "K'a sọpẹ f'Ọba Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ mura lati fi iwuri kọrin f'Oluwa",
                        "Ẹ jẹ ki gbogbo wa yọ",
                        "K'a sọpẹ f'Ọba Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹ gbọhun yin s'oke, Ẹ yin Baba wa logo.",
                        "Ẹ dupẹ lọwọ Ọlọrun f'oore t'o fun wa kari.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹ bẹrẹ, ẹ tẹriba mọlẹ",
                        "Ẹ dupẹ f'Ọba Mimọ.",
                    }
                },
            }
        },
        new Hymn
{
    Number = "268",
    Title = "AWA SỌPẸ",
    Category = "ORIN FUN ỌDUN IKORE",
    Author = "Jide Ogunsusi",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Awa de lati juba Rẹ o",
                "Ọlọjọ oni o awa sọpẹ",
                "Awa de lati juba Rẹ o",
                "Eledumare awa sọpẹ",
                "Fun 'fọkanbalẹ ti O fun wa",
                "F'ere pupo lori iṣẹ",
                "O tun da wa si d'Ọjọ oni o",
                "Eledumare awa sọpẹ",
                "Awa de lati juba Rẹ o",
                "Ọlọjọ oni awa sọpẹ.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Ma jẹ k'a lo 'gbesi aiye wa rederede",
                "Ma ṣe jẹ ka r'ibi idanwo ẹṣu",
                "Gba wa lọwọ ikẹkun aiye, Oluwa",
                "Eledumare awa sọpẹ",
                "Awa de lati juba Rẹ o",
                "Ọlọjọ oni o awa sọpẹ.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Wẹ mi mọ Oluwa mi, wẹ mi mọ",
                "Wẹ mi mọ o, k'emi le jogun iye.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Wẹ mi mọ (2ce)",
                "Wẹ mi mọ o, k'emi le jogun iye",
                "Tun 'le aiye ṣe fun wa Baba Olọore",
                "Ẹbẹ l'a bẹ Ọ, k'o gb'ẹbẹ wa o",
                "Ẹnu wa ko gb'Ọpẹ (2ce)",
                "Ete wa ko gba iyin",
                "Ọlọrun l'o johun gbogbo lọ",
                "Ọrọ wa d'ọwọ Rẹ o, Ọba Ọrun.",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Wa gb'Ọrẹ wa oni Baba Eledumare",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Ẹbẹ l'a bẹ Ọ k'o gb'ẹbẹ wa o, Ọba Ọrun",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Jẹ k'o yẹ wa kalẹ o, Baba Eledumare",
                "Fun wa l'owo na o, Baba Eledumare",
                "Fun wa l'Ọmọ rere, Baba Eledumare.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Arinu-rode Olumọran-ọkan",
                "Ọmọ agbejo-kalẹ ni k'o fun wa",
                "Eledumare Ọba Ogo",
                "Baba awa ọmọ Rẹ",
                "A de lati yin Ọ logo o Ọba Ọrun (2ce)",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Ile ti a kọ, Iwọ l'o kọ fun wa",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Yẹ o, Yẹ o, Baba rere",
            }
        },
        new Verse
        {
            Number = "Lile:",
            Lines = new List<string>
            {
                "Ọmọ ti a bi o Iwọ l'o fi fun wa",
                "Owo ti a ni Iwọ l'o fi fun wa",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Ẹni t'Ọla yẹ l'o yẹ k'a b'Ọla fun",
                "A b'Ọla fun Jehofa gb'ẹbẹ wa o",
                "A gb'ojú s'oke si Ọ, Ọba Ogo",
                "Ma ṣe jẹ k'a r'arinnu l'aiye wa o.",
            }
        },
        new Verse
        {
            Number = "Egbe:",
            Lines = new List<string>
            {
                "Ẹyin'jọ (Ekiti) k'a sọpẹ f'Oluwa",
                "Fun ori're t'Ọlọrun fi da wa l'Ọla (2ce)",
                "Ọlọrun t'o fi fun wa ma ma gba lọwọ wa (2ce)",
                "Edumare jẹ k'o yẹ wa kalẹ o",
                "Baba wa gbadura wa",
                "Ẹyin 'jọ Ekiti k'a sọpẹ f'Oluwa",
                "Fun ori're t'Ọlọrun fi da wa l'Ọla.",
            }
        },
    }
},
        new Hymn
        {
            Number = "269",
            Title = "Ẹ MỌRẸ WA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Ẹyin ara, Ẹ mọrẹ wa",
                "Ẹni t'o sọnu lo nri he",
                "Ibukun Ọlọrun ki i pọju",
                "Tete yara ki o mọrẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin ara, Ẹ mọrẹ wa.",
                        "Ọba ti ngbani l'Olugbala",
                        "Oluwa dẹ'ti sile fun 'bere",
                        "Tete bere ohun ti o fẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹyin ara Ẹ mọrẹ wa.",
                        "Ọpọlọpọ l'o wa ti o nṣawun",
                        "Ọlọrun l'o fun ọ lọnakọna",
                        "Ki ọwọ bọ'po ma ṣe roju.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọrẹ atinu wa, ni k'e mu wa",
                        "Ọrẹ at'okan wa l'Ọrẹ atata",
                        "Ọlọrun ṣe fun wa o jẹ'lomiran",
                        "Tete mọrẹ wa, tí o jọ ju.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin ewe oni, ẹ ma roju",
                        "Ọgbọn ori rẹ ṣe pataki",
                        "Ta lo fun ọ l'oye at'imo",
                        "Tete yara ki o wa sọpẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹyin ọrẹ ẹ ku Ọdun",
                        "Ẹ ku ijo mukẹlẹ mukẹ",
                        "Ọba t'o da wa ki i s'Ọba ika",
                        "A ti b'Ẹgbẹ mu, a si b'Ọgba jọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọrẹ atinu wa ni mo mu wa",
                        "Ọrẹ at'okan wa l'Oluwa bere",
                        "Ọrẹ t'Abẹli f'Olugbala",
                        "On l'Ọba oke f'ọwọ si.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Baba gb'Ọrẹ wa tinutinu",
                        "Baba gb'Ọrẹ wa t'okan-t'okan",
                        "Ọba ti ki i gan 'gbe ẹlẹsẹ",
                        "Jọwọ ṣe fun wa ju 'bere wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "270",
            Title = "EMI YIO MAA FI IBUKUN FUN OLUWA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Oloye J. F. Odunjo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Emi yio maa fi ibukun fun Oluwa ni igba gbogbo",
                        "Iyin Rẹ yio si wa l'ẹnu mi titi lai.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹnu mi ko gb'Ọpẹ",
                        "Iwọ ni n'g o maa yin titi",
                        "Ẹnu mi ko gb'Ọpẹ",
                        "Iwọ ni n'g o maa yin titi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọkan mi yio si maa ṣogo lati yin Oluwa",
                        "Ẹnyin Ọlọkan tutu, ẹ gbọ ki ẹ si maa yọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aleluya, Aleluya.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Oluwa Ọlọrun igbala mi, emi nkigbe t'Ọsan-t'oru",
                        "Gbọ ohun adura mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "271",
            Title = "MO DE MO DE O",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọba Oluwa mo mu Ọrẹ mi wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Mo de, mo de o, Olugbala mo de; mo de",
                        "Tẹwọ gba Ọrẹ mi Ọba Ogo o, Olugbala mo mu Ọrẹ mi wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jẹ ki Ọrẹ mi jẹ atẹwọgba fun Ọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jẹ ki Ọrẹ mi sọ eso rere fun mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ma ṣe kọ mi silẹ ninu ẹsẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Ọba Ogo wa tẹwọ gb'Ọrẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ma ṣe jẹ ki awọn ọta ṣẹgun mi.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ki o si wa pẹlu mi ni igba gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọba Oluwa mo mu Ọrẹ mi wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "272",
            Title = "GB'ỌRẸ WA, OLUWA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gb'Ọrẹ wa Oluwa, ti a mu wa fun Yin",
                        "Gb'Ọrẹ wa Oluwa ki o si gb'Ọpẹ wa",
                        "Atẹwọgba ni ki o jẹ lọdọ Rẹ Oluwa",
                        "Awa o si maa rohin oore nla Oluwa (3ce)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo f'iyin f'Ọba Oluwa fun oore ti mo ti gba",
                        "Mo f'iyin f'Ọba Oluwa fun oore Rẹ gbogbo",
                        "Olọore aanu, jọwọ tẹwọ gb'Ọrẹ mi",
                        "Jẹ ki n le maa rohin iṣẹ ọwọ Rẹ (3ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọwọ ọtun Oluwa ti fi agbara Rẹ han",
                        "Ọwọ ọtun Oluwa si gbe mi ga",
                        "Emi ki yio ku, bikoṣe yiye",
                        "Emi o si maa rohin iṣẹ Oluwa (3ce)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo sa di Ọ Oluwa, Jesu Olugbala,",
                        "Mo sa di Ọ Oluwa, Jesu Oninure,",
                        "Rọ 'jo Ibukun Rẹ Mimọ sori mi, l'Ọjọ gbogbo",
                        "Jẹ ki n le maa bẹru Orukọ Mimọ Rẹ (3ce)",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Dariji mi Oluwa, Olufijìn ẹsẹ",
                        "Dariji mi Oluwa Ọba adarijini",
                        "Atẹwọgba ni ki n jẹ lọdọ Rẹ Oluwa",
                        "Jẹ ki n le jogun Ọrun titi aiye ainipẹkun (3ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "273",
            Title = "OLODUMARE AWA DẸ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "P. A. Fragoso",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olodumare awa de",
                        "Ọbangiji a wa siwaju Rẹ",
                        "Gb'Ọpẹ wa t'a mu wa",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹbọ aiku ti a mu wa",
                        "Jọwọ sọ ọ di ohun pipe fun wa",
                        "Sọ ile wa di Mimọ",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oniwatutu a tun de",
                        "Awa kunlẹ lati yin Ọ logo",
                        "Ṣ'Ọjọ wa ni pipe",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹlẹsẹ l'Ọrun l'awa jẹ",
                        "F'ifẹ nla Rẹ san ifẹ pinninsin wa",
                        "Ṣ'aiye wa ni pipe",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Onisuru ni Ọ jẹ",
                        "T'Ọsan t'igba l'a fi nkẹ niwaju Rẹ",
                        "Dari wa titi lai",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Onirẹlẹ ọkan ni Ọ jẹ",
                        "Ti wa l'ehin lati f'Ọpẹ fun Ọ",
                        "Olọore wa pipe",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ọjọ adura l'oni jẹ",
                        "Awa mbẹbẹ Ọrẹ Mimọ nla Rẹ",
                        "A fẹ Ọ titi lai",
                        "Bukun fun wa laiku kan.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Titi d'Ọjọ alẹ",
                        "Bukun fun wa laiku kan",
                        "K'o to d'Ọjọ ipe",
                        "Bukun fun wa laiku kan. Aṣẹ",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "274",
            Title = "IDUPẸ ỌMỌ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Jesu, mo dupẹ o; Ọmọ Ọlọrun mo tọpẹ da",
                "Mo ti ṣako jina, Jesu, o tun wa mi ri",
                "Mo ti ṣako jina, Jesu, Ọpẹ l'o yẹ Ọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Abiye lọmọ mi o, mo dupẹ, mo tọpẹ da (2ce)",
                        "Ọpẹ l'o yẹ Jesu loke, f'Ọmọ rere ti O fun mi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                       "Mo dupẹ o Jesu            Ọpẹ l'o yẹ Ọ",
                       "F'Ọmọ rere ti O fun mi    \"",
                       "Jẹki o yẹ mi kalẹ Baba    \"",
                       "Kabiyesi alayelua         \"",
                       "Ọdundun a sọ 'de d'erọ    \"",
                       "Ọba a de, k'ile roju      \"",
                       "Ọba a de, ki ọna rọrun     \"",
                       "Jesu Ọpẹ l'o yẹ Ọ          \"",
                       "Mo dupẹ o Jesu             \"",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jesu mo dupẹ o etc.",
                        "Jesu mo dupẹ o etc.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Abiye lọmọ mi o, mo dupẹ mo tọpẹ da (2ce)",
                        "Ma jẹ ki o 'kagbako lọna",
                        "Baba ba mi boju to o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo dupẹ o Jesu",
                        "Ọba ataiye rọ bi agogo",
                        "Ọba a sọrọ mayehun",
                        "Ogbigba ti n gb'ara adugbo",
                        "Jesu alatunṣe ile aiye",
                        "Jesu Ọmọ Maria",
                        "Jesu Ọmọ Ọlọrun",
                        "Jesu Olurapada",
                        "Mo dupẹ o Jesu",
                        "Egbe: Jesu mo dupẹ o etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "275",
            Title = "ỌBANGIJI MO MỌRẸ WA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọbangiji mo mọrẹ wa, mo de lati fi 'yin fun Ọ",
                        "Jọwọ o, Baba rere, wa gb'Ọrẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Oyigiyigi, Baba (2ce) Mo jo; mo yọ;",
                        "Mo jo, mo yọ",
                        "Mo wa f'Ọpẹ fun Ọ Baba Onibu-ọrẹ o, O ṣeun",
                        "Mo wa f'Ọpẹ fun Ọ Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Fun oore Rẹ lori mi, mo de lati juba",
                        "Baba Mimọ jọwọ o, wa gb'Ọrẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "F'oju aanu Rẹ wo mi, Baba jọwọ o",
                        "Ran mi lọwọ o Baba rere, wa gbọ igbe mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jọwọ sọ mi ninu ewu ati lọwọ awọn ọta",
                        "Ọba-N-giji mo mbẹbẹ dari ẹsẹ mi ji mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Tọ mi si ọna Rẹ ki n le sin Ọ bi o ti yẹ",
                        "Jọwọ o Baba rere wa gb'Ọrẹ mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "276",
            Title = "IBUKUN RẸ OLODUMARE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Ibukun Rẹ, Olodumare",
                "L'awa n tọro s'ori gbogbo iṣẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Fi 'gbagbo fun wa",
                        "K'ẹsẹ wa ma yẹ",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Fi 'reti fun wa",
                        "K'ale sin Ọ yẹ",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fi 'fẹni fun wa",
                        "K'ale sin Ọ pọ",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fi 'sọ Rẹ sọ wa",
                        "K'ama k'agbako",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Bukun fun 'le wa",
                        "K'o rọ wa l'ọrun",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ṣe 'ranlọwọ wa",
                        "K'a yẹra f'ẹsẹ",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ṣ'aanu fun wa",
                        "K'a le gba wa la",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ọba alagbara",
                        "A-ṣe-kan-ma-ku",
                        "Mu wa ka le jẹ Tire.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Bukun fun 'ṣẹ wa",
                        "K'a jere 'kẹhin",
                        "Mu wa ka ma pọfo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "277",
            Title = "O ṢEUN O, BABA WA",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "eun o, Baba wa. O ṣeun o, Baba wa",
                        "Iwọ l'o jẹ n lọwọ lọwọ “",
                        "Iwọ l'o jẹ n l'alafia “",
                        "Iwọ l'o jẹ n b'Ọmọ to gbọn “",
                        "Iwọ l'o jẹ n wa d'oni “",
                        "O ṣeun o, Baba wa “",
                        "A ti gbagbe aimoye ẹda “",
                        "Iwọ l'o m'okan mi balẹ “",
                        "A dupẹ, dupẹ lọwọ Rẹ “",
                        "A ṣe yi s'amọdun k'a tun ṣe miran “",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "278",
            Title = "ỌPẸ YẸ Ọ O, BABA MIMỌ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Ọpẹ yẹ Ọ o, Baba Mimọ (2ce)",
                "Ti O da wa si d'oni o",
                "A wa f'Ọpẹ fun Ọ o",
                "Edumare Ọba Onibu-ọrẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olodumare a dupẹ fun Ọrẹ Rẹ lori wa",
                        "A wa f'yin fun Ọ Baba Ọrun wa gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A fi ilu at'orin yin Ọ, Baba Mimọ O ṣeun",
                        "Baba Mimọ a mbẹbẹ, sọ wa k'a le ṣe t'amọdun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Sicilia Mimọ alaabo Ẹgbẹ Akorin",
                        "A kigbe pe Ọ o, wa tẹ'wọ gb'adura wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Sicilia Mimọ a mbẹ Ọ o, wa gbọ ti wa",
                        "Ran wa lọwọ a mbẹbẹ, ṣ'amọna wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimọ a mbẹ Ọ, jọwọ da wa si d'amọdun o",
                        "Ka tun le yin Ọ o, Baba Ọrun wa gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A o maa yọ ninu Rẹ, a o maa yọ ninu Rẹ",
                        "Baba Mimọ a mbẹbẹ, sọ wa k'a le ṣe t'amọdun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "279",
            Title = "KI LO YẸ K'A ṢE T'A O MỌ",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
                "Kí lo yẹ k'a ṣe t'a o mọ.",
                "Awa ko f'ojú, awa ko y'arọ",
                "Awa ko rin l'Ọjọ ebi n pọna",
                "Awa ko t'oju oorun d'oju iku.",
                "Aisan t'o ju wa ko si gbe wa de",
                "Awa l'a dide t'a bọmi s'ara wa o",
                "Awa l'a dide t'a jẹun fa-lala",
                "Awa l'a dide t'a wọ aṣọ to yẹ wa",
                "Ọpẹ, iyin l'o yẹ ka fi fun Un",
                "Kí lo yẹ k'a ṣe t'a o mọ.",
            },
            Verses = new List<Verse>
            {
            }
        },
        new Hymn
        {
            Number = "280",
            Title = "GB'ỌPẸ WA EDUMARE",
            Category = "ORIN FUN ỌDUN IKORE",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gb'Ọpẹ wa Edumare, gb'Ọpẹ wa o, gb'ẹbẹ wa (2ce)",
                        "Ọba Onibu Ọrẹ, Ọlọrun Ayọ",
                        "Ọba Onibu Ọrẹ, gb'Ọpẹ wa o",
                        "A kigbe si Ọ, Ọlọrun Edumare",
                        "Gb'Ọpẹ wa o, gb'ẹbẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gb'Ọpẹ wa Edumare, gb'Ọpẹ wa o,",
                        "Baba Mimọ (2ce)",
                        "Ọba Arinurode, Orisun Ayọ",
                        "Ọba Arinurode, a foribale",
                        "Ọba Arinurode, gb'Ọpẹ wa o",
                        "A kigbe si Ọ Ọlọrun Olupese",
                        "Gb'Ọpẹ wa o, gb'ẹbẹ wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "281",
            Title = "ỌBA MIMỌ SỌ WỌN PỌ",
            Category = "ORIN IGBEYAWO",
            Author = "A. Adeboye",
            Chorus = new List<string>
            {
                "Ọba Mimọ sọ wọn pọ l'aṣẹ Rẹ (2ce)",
                "Awọn ti a sopọ nigbeyawo,",
                "Bukun fun wọn o, Baba Mimọ",
                "Fi didun s'aiye wọn, Ọba Ogo (Interlude)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ma fi jijẹ mimu han wọn Aṣẹ",
                        "Ma f'airijẹ ba wọn “",
                        "Ran wọn lọwọ Oluwa “",
                        "Ma pada lẹhin wọn “",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ma f'Ọmọ bibi han wọn “",
                        "Ma l'airoju ba wọn “",
                        "Ran wọn lọwọ Oluwa “",
                        "Ma pada lẹhin wọn “",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ma f'airowona ba wọn “",
                        "Ma fi ile aiye su wọn “",
                        "Ran wọn lọwọ Oluwa “",
                        "Ma pada lẹhin wọn “",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ma f'ibanujẹ ba wọn “",
                        "Ma f'aṣeri ba wọn “",
                        "Tu wọn ninu Oluwa “",
                        "Ma pada lẹhin wọn “",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "282",
            Title = "RAN WỌN LỌWỌ O, EDUMARE",
            Category = "ORIN IGBEYAWO",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awa nbe Ọ o, Jehova Ọba Onibu-ọrẹ",
                        "Awa nbe Ọ o Jehova, rọ'jo ibukun Rẹ s'ori awọn ọmọ Rẹ",
                        "Ti a sopọ ni igbeyawo",
                        "Awa nbe Ọ o Olu-Ọrun Ọba Onibu-ọrẹ.",
                        "Awa nbe Ọ o Jehova Ọba Onibu-ọrẹ",
                        "Awa nbe Ọ o Jehova, pese ibukun Rẹ",
                        "Fun awọn ọmọ Rẹ ti a so pọ ni igbeyawo",
                        "Awa nbe Ọ o Olu-Ọrun Ọba Onibu-ọrẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ran wọn lọwọ Olodumare lati le maa gbe pọ pẹlu ifẹ ati ododo",
                        "F'ọna han wọn Olodumare lati le ṣe ifẹ Rẹ",
                        "Tọ wọn si ọna Rẹ, wa bukun fun wọn",
                        "Jẹ ki wọn le ri awọn ọmọ ọmọ wọn",
                        "Ran wọn lọwọ o Edumare lati le ṣe Tire.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awa nbe Ọ o, Jehova Ọba Onibu-ọrẹ",
                        "Awa nbe Ọ o Jehova, s'ami ororo Rẹ",
                        "S'ori awọn ọmọ Rẹ ti a so pọ ni igbeyawo",
                        "Awa nbe Ọ o Olu-Ọrun, Ọba Onibu-ọrẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "283",
            Title = "IGBEYAWO YI A ṢESO RERE",
            Category = "ORIN IGBEYAWO",
            Author = "H. A. Ọrẹdipẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Igbeyawo yi a ṣeso rere (2ce)",
                        "Ki Baba ba wa fi 'bukun si",
                        "Igbeyawo yi a ṣeso rere",
                        "                             Egbe:", 
                        "A ki gb'oju lọwọ ori           \"",
                        "A ki gb'ẹsẹ lọwọ ona           \"",
                        "Tọkọ t'iyawo ajọgbojọtọ        \"",
                        "Abimọgbọmọpọn ni t'ẹyẹ adan    \"",
                        "Iran esusu ki i yagan          \"",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu Kristi Ọba awọn Ọba",
                        "Iwọ t'o bukun fun igbeyawo",
                        "Akoko ti wọn ṣe ni Kana",
                        "Jọwọ wa ba wa bukun tiwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O yẹ ki ọkọ ati aya mu'ra wọn",
                        "Ki wọn ma ṣe gbagbe",
                        "Pe wọn ti di 'kan ninu Kristi",
                        "Ki wọn ba'ra wọn lo fẹ gidi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọkọ l'olori awọn aya",
                        "Wọn si ni lati d'aya wọn mu",
                        "Báwọn ki idanwo ti pọ to",
                        "Ọba Oluwa, Ọba t'o to sin",
                        "A ma ba wọn wa l'Ọjọ gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "284",
            Title = "BI ỌSUN GBẸGẸ ETI ODO",
            Category = "ORIN IGBEYAWO",
            Author = "J. A. Ọla Talabi",
            Chorus = new List<string>
            {
                "A dara fun yin o, Igba yin yio toro mini o (2ce)",
                "Bi omi ta fi owurọ pọ́n",
                "Igbesi aiye yin yio si tutu mini",
                "Bi Ọsun gbẹgẹ eti odo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iṣẹ l'akoja ofin gbogbo",
                        "Eyi lo yẹ fi ṣe'akọle",
                        "Nibikibi ti a ba ngbe pọ",
                        "Eyi jẹ dandan ati dandan.",
                        "Tẹriba fun ọkọ rẹ iwọ obinrin",
                        "Ma ṣe mu binu nitori pe",
                        "Alaabo ati olori rẹ ni o.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Olodumare k'o maa tọ yin si ona rere",
                        "K'o bukun fun yin, ki ẹ maa bi si",
                        "Ki ẹ si maa rẹ si o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹlẹda yio fi ọmọ rere ṣike yin",
                        "Aya yio fi inu ṣ'oyun, yio f'ehin pọ́n mọ",
                        "Ẹ ko ni ku mọ ara yin lori o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọlọrun yio ṣe yin ni ọrẹ ara yin k'ale",
                        "Yio pese fun aini yin, yio ran yin lọwọ",
                        "Ẹ ko ni d'agba osi laiye yin o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "285",
            Title = "MISA FUN IGBEYAWO",
            Category = "ORIN IGBEYAWO",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "F'ibukun Rẹ aiyeraiye",
                "Ọba Ọrun jọwọ o",
                "S'ori awọn ayanfẹ Rẹ",
                "T'o sa s'abẹ aabo Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Bọwọ fun aya rẹ iwọ okunrin",
                        "Ma ṣe ni lara nitori pe",
                        "Oluranlọwọ ati ẹnikeji rẹ ni o.",
                        "Fun wọn ni 'simi lẹhin iṣẹ",
                        "Fun wọn l'ounjẹ n'igba ebi.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ibukun ni fun ẹni na",
                        "T’o n rin lọna Rẹ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ninu ọpọ aanu Rẹ",
                        "Baba mi pese fun wọn.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "F'ohun rere ji wọn Oluwa",
                        "Tọju wọn ninu ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jẹ ki ọkọ k'o fẹran aya",
                        "Ki aya si f'ara mọ ọkọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Fun wọn ni 'dẹra ninu ile",
                        "F'aabo Rẹ bo wọn lọna oko.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Jẹ ki wọn bi si, ki wọn rẹ si",
                        "F'Ọmọ rere ta wọn l'orẹ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Fi ọrẹ-ọfẹ Rẹ ṣe 'kẹ wọn",
                        "Ki wọn k'o le ri ọmọ ọmọ wọn.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "286",
            Title = "ORIN ẸKỌ ATI ADURA FUN AWỌN ONIGBEYAWO",
            Category = "ORIN IGBEYAWO",
            Author = "J. A. Akinkuoye",
            Chorus = new List<string>
            {
                "Ẹyin to wa ṣe 'gbeyawo",
                "Ọlọrun lo n sọ yin pọ",
                "Titi iku yio fi ya yin",
                "Lẹ o wa pọ l'ohun gbogbo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Tọ wọn s'ona Rẹ Onibu-ọrẹ",
                        "Titi wọn yio fi d'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin o m'Ọlọrun l'Ọba",
                        "Pẹlu ifẹ aisẹtan f'aya",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Pẹlu itẹriba ti o yẹ f'Ọkọ",
                        "Pẹlu ifẹ aisẹtan f'aya",
                        "Lẹ o fi wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Alafia la n tọro fun yin",
                        "Ẹmi gigun pẹlu ayọ",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Owo, ọmọ, ni a o fi da a yin lola",
                        "Ara lile ẹmi gigun………",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹkọ to yẹ f'Ọmọ ni ẹ o fun un",
                        "Isowo pọ a wa……..",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ẹ o ṣojuṣe ni 'jo t'Ọlọrun",
                        "Ẹ o ni rẹhin ti t'eniyan",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹ o gbade iye l'Ọrun lọdọ Oluwa",
                        "Ogo Ọlọrun ni ẹ o tọ……",
                        "Bi ẹ ba ti wa pọ l'ohun gbogbo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "287",
            Title = "ỌDUN IFẸ NI TI ONI",
            Category = "ORIN IGBEYAWO",
            Author = "Ẹgbẹ Akọrin Bodija",
            Chorus = new List<string>
            {
                "Oni l'Ọdun Ifẹ o, ara ẹ gbọ (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Lehin ila kọọkan:-",
                    Lines = new List<string>
                    {
                        "Ifẹ l'o yẹ yin",
                        "Ẹ fi 'fẹ j'aiye.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọdun Ifẹ ni t'oni",
                        "Ọkọ Iyawo ọlọla",
                        "Eniyan pataki",
                        "Ẹnit'o tọkọ iṣẹ",
                        "Ọmọ luwabi eniyan",
                        "Ẹni a bi ire.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọdun Ifẹ ni t'oni",
                        "Iyawo mo ki ọ",
                        "Ọmọge apọnbepore",
                        "(Ọmọge adumaradan)",
                        "Ọmọge af'iwa ṣe ẹwa",
                        "A b'Ọkọ gbe d'Ọjọ iku",
                        "Iya niwura obinrin",
                        "Ẹni a bi ire.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọdun Ifẹ ni t'oni",
                        "Tọkọtaya ni mo ki",
                        "Ifẹ lo sọ yin pọ",
                        "Ẹ ṣe 'ranti Ọjọ",
                        "Ti ẹ jọ sọrọ pọ",
                        "Oni l'o f'ade bori",
                        "Ẹni a bi ire.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "288",
            Title = "IRE TA ṢU L'EDENI KO TASE",
            Category = "ORIN IGBEYAWO",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ire akọkọ t'Edeni ko tase ti Baba ni",
                        "Ifẹ ti Baba ni pe ka bi si, ka re si,",
                        "Ad-i-tu ni igbeyawo o",
                        "Ẹ ma tu wo, iṣẹ Ọlọrun Ọba.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ohun ayọ ni igbeyawo f'Onigbagbọ o",
                        "Ohun iyi ni igbeyawo f'Ọmọ Ọlọrun",
                        "Aṣẹ Ọlọrun ni pe ka ma a bi si, ka ma re si",
                        "Ire akọkọ ko tase, o wa titi ni.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ogo akọkọ t'Edeni ko ma ṣa, ti Baba ni",
                        "Ifẹ ti Baba ni ka b'Ọmọ ka si tọ",
                        "Asiri nla ni igbeyawo o",
                        "Ẹ ma tu wo, iṣẹ Ọlọrun Ọba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹyẹ akọkọ ti Edeni ko ma ti, ti Baba ni",
                        "Ifẹ ti Baba ni ka rire ka sin In",
                        "Ẹyẹ to l'ogo ni igbeyawo",
                        "Ẹ ma tu wo, iṣẹ Ọlọrun Ọba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "289",
            Title = "Ẹ MAA BI SI",
            Category = "ORIN IGBEYAWO",
            Author = "C. S. O. Balufẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ maa bi sì, ẹ maa re si",
                        "Jọwọ Oluwa, dabobo wọn.",
                    }
                },
                new Verse
                {
                    Number = "Solo:",
                    Lines = new List<string>
                    {
                        "L'aṣẹ Oluwa gbogbo ire mo yin loni o. Amin aṣẹ",
                        "Ẹ maa bi si. L'aṣẹ Oluwa adura gba fun yin loni o.",
                        "Amin aṣẹ Ẹ maa bi si.",
                        "Baba ọkọ f'ikoko ṣe 'bẹ - Oyin mọmọ!",
                        "Iya ọkọ f'ikoko ṣe 'bẹ Oyin mọmọ!",
                        "Oyin mọmọ (3ce) Ẹ maa bi si.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "L'aṣẹ Oluwa Ọmọ titun niwoyi amọdun",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "L'aṣẹ Oluwa Ọmọ rere niwoyi amọdun.",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "Baba Iyawo f'ikoko ṣe 'bẹ Oyin mọmọ!",
                        "Iya Iyawo f'ikoko ṣe 'bẹ Oyin mọmọ!",
                        "Oyin mọmọ (3ce) Ẹ maa bi si.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "L'aṣẹ Oluwa k'ile san yin, a mbẹ Oluwa.",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "L'aṣẹ Oluwa k'ọna san yin, a mbẹ Oluwa.",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "Gbogbo Ẹbi f'ikoko ṣe 'bẹ Oyin mọmọ!",
                        "Gbogbo ara f'ikoko ṣe 'bẹ - Oyin mọmọ!",
                        "Oyin mọmọ (3ce) Ẹ maa bi si……….",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "L'aṣẹ Oluwa k'ore-ọfẹ kun yin d'opin o.",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "L'aṣẹ Oluwa k'ayọ 'dunnu ba yin t'alẹ o",
                        "Amin aṣẹ. Ẹ maa bi si",
                        "Ọkọ Iyawo f'ikoko ṣe 'bẹ, Oyin mọmọ;",
                        "Ani Iyawo f'ikoko ṣe 'bẹ, Oyin mọmọ.",
                        "Oyin mọmọ (3ce) Ẹ maa bi si……",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "290",
            Title = "ẸṢU BELEKE KO LE RI WA GBẸṢE",
            Category = "ORIN ONIRUURU",
            Author = "P. A. Fragoso",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin Onigbagbọ ẹ lọ ye 'fa da l'aiye o",
                        "Ẹyin aborisa ẹ wa gba Jesu",
                        "Awa Onigbagbọ gba Kristi l'Ọba ni ti wa,",
                        "Ẹṣu beleke ko le ri wa gbẹṣe!",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹṣu beleke ko le ri wa gbẹṣe,",
                        "Ẹṣu beleke ko le ri wa gbẹṣe",
                        "Ẹṣu odara ko le ri wa gbẹṣe",
                        "Ẹṣu odara ko le ri wa gbẹṣe",
                        "Bi a ba npe Jesu,",
                        "Ẹṣu beleke ko le ri wa gbẹṣe",
                        "Ẹni ba npe Jesu,",
                        "Ẹṣu beleke ko le ri i gbẹṣe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹyin oniro ẹ lọ ye 'rọ tu l'aiye o",
                        "Ẹyin ọlọtẹ ẹ ye gbimo pọ",
                        "Awa Onigbagbọ ti mọ Ọlọrun ni ti wa",
                        "Ẹṣu beleke ko le ri wa gbẹṣe.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹyin ọlọgbọn ẹ ronu t'Ọpẹ l'aiye o",
                        "Ẹyin ọdalẹ ẹ wa p'iwa da",
                        "Awa Onigbagbọ n tọ Jesu lọ ni ti wa",
                        "Ẹṣu beleke ko le ri wa gbẹṣe.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Otito inu l'oye wa titi l'aiye o",
                        "Ọpọ eniyan ko ṣe f'inu han;",
                        "Bi a ba le jẹ ki ami o jina siwa l'aiye o",
                        "Ẹṣu beleke ko le ri wa gbẹṣe.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹyin Ọlọpẹ ẹ wa f'Ọpẹ yin f'Oluwa",
                        "Lati gba 'Bukun lọwọ Ọlọrun;",
                        "Bi a ba n gba Jesu si 'nu wa l'Ọjọ gbogbo",
                        "Ẹṣu beleke ko le ri wa gbẹṣe.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "291",
            Title = "BA MI ṢE OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Ba mi ṣe o, pa 'banujẹ mi rẹ",
                "Oluwa, ba mi ṣe o,",
                "Baba sọ̀rọ̀ mi d'ayọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo wo waju mo wẹhin",
                        "Emi ko rẹni kan mọ mi",
                        "Gba mi o, gba mi o, Ọba Ọrun",
                        "Wa ko mi yọ o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọba pipe Agbọrandun",
                        "Pa 'banujẹ mi rẹ o",
                        "Rẹmi o, rẹmi o, ninu ẹkun",
                        "Wa ko mi yọ o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Baba Mimọ Olupese",
                        "Ṣe iranwọ Rẹ fun mi",
                        "Gba mi o, gba mi o, lọwọ aiye",
                        "Wa ko mi yọ o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọba ọlọla Ọba Ogo.",
                        "F'ọna Mimọ Rẹ tọmi",
                        "Baba o, lo mi o, ki n ṣe Tire",
                        "Wa tun mi ṣe o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo ti duro n ko bẹru",
                        "Ọrọ mi d'ayọ mo rire",
                        "Jọwọ o, jọwọ o, jẹk'oyẹmi",
                        "Wa gbe mi ga o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "292",
            Title = "OLUWA L'OLUSỌ AGUTAN MI",
            Category = "ORIN ONIRUURU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Oluwa l'Olusọ agutan mi o",
                "Emi ki yio ṣ'alaini ohunkohun o",
                "Ko ni jẹ ki nwa lọwọ ofo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "O mu mi lọ sibi papa oko tutu minimini",
                        "O tọ mi s'ona lọ si b'omi itura",
                        "O sọ ẹmi mi ji ninu ireweṣi rẹ",
                        "O mu u pada bo sipo rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O tu ọkan mi lara, O si mu mi lọ",
                        "Nipa ona ododo",
                        "Nitori orukọ Rẹ ododo ni.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi mo tilẹ nrin larin afonifoji ojiji iku",
                        "Emi ko ni bẹru ibi kan",
                        "Ọgọ Rẹ at'Ọpa Rẹ,",
                        "Wọn ntu mi ninu",
                        "Nitori O wa pẹlu mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O tẹ tabili ounjẹ sile niwaju mi",
                        "Loju awọn ọta mi",
                        "Iwọ da ororo si mi l'ori",
                        "Ifẹ mi si kun akun de ẹnu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ire ati aanu ni yio ma tọ mi lẹhin",
                        "Titi Ọjọ aiye mi yio fi dopin o",
                        "Emi yio si ma gbe ile Oluwa",
                        "Titi aiye o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "293",
            Title = "EMI KO BẸRÙ",
            Category = "ORIN ONIRUURU",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Emi ko bẹru ẹnikan-kan",
                "Oluwa l'Olugbala mi",
                "Njẹ ta lo le deru ba mi",
                "Oluwa ni Imọlẹ mi.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ohun kan ni emi n tọro lọdọ Oluwa",
                        "Oun naa l'okan mi fa si",
                        "Lati fi ile Ọlọrun ṣe ibudo",
                        "Ni ọjọ aiye mi gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọkan mi wi fun Oluwa pe",
                        "Oju Oluwa ni n'g o maa wo",
                        "Ma ṣe moju kuro l'ara mi",
                        "Ma ṣe fi binu gbọn mi junu.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jọwọ, ma ṣe kọ mi lọmọ",
                        "Oluwa Igbala mi",
                        "Bi baba ati iya tile kọ mi",
                        "Oluwa ṣetan lati gba mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Dajudaju emi gbagbọ pe",
                        "N'g o roju rere Oluwa",
                        "Ni ile awọn alaye",
                        "Emi gbẹkẹle Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Duro d'Oluwa, Iwọ ọkan mi",
                        "Tujuka, yio mu o l'aiya le",
                        "Oun nikan ṣoṣo l'o le gba mi",
                        "Duro d'Oluwa gbọnin-gbọin. Amin",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "294",
            Title = "GBỌ T'EMI GBỌ T'EMI OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
                "Gbọ t'emi gbọ t'emi",
                "Gbọ t'emi Oluwa",
                "Gbọ t'emi Eledumare",
                "Gbọ t'emi Ẹlẹda mi",
                "Iwọ ni mo duro de",
                "Olugbala gbọ t'emi o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọlọrun Baba Mimọ",
                        "Olu Ọrun Ẹda Ọrun",
                        "Tete sare wa gbọ ti wa",
                        "K'a ma ṣe raun l'aiye wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gbọ ti wa Baba Mimọ",
                        "A f'ehin ti Ọ Olu Ọrun",
                        "Ẹda t'o ba ti gb'ẹkẹle Ọ",
                        "Ko ma ni pada lọwọ ofo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "B'o ba ti yẹni l'o yẹ k'a wi",
                        "Eledumare a wole fun Ọ",
                        "Oju Rẹ nikan l'a now",
                        "Eledumare Baba wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Nigba ti Ọlọjọ ba de",
                        "K'a wa jẹwọ igbagbọ wa",
                        "Niwaju Rẹ Ọlọrun",
                        "La o ti gba dajọ rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu Baba Mimọ",
                        "Tirẹ l'o ku ta wa o ṣe",
                        "A ṣe leri niwaju pepe",
                        "K'a ma ṣe jina mọ si Ọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọlọrun Baba Mimọ",
                        "A wa sin Ọ tinutinu",
                        "Eyi ni igbagbọ wa",
                        "K'a ma ṣe rẹhin ninu Ijọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "295",
            Title = "IWA MIMỌ BI T'ỌLỌRUN KO SI",
            Category = "ORIN ONIRUURU",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
                "Iwa Mimọ bi t'Ọlọrun ko si (2ce)",
                "Ẹ jẹ k'a huwa rere",
                "K'a le j'ogun ayọ",
                "K'a le b'Ọlọrun gbe pọ l'oke.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "B'iwo ba ṣe k'Ọlọrun",
                        "K'o ma jina si o",
                        "Ṣe rere, ara mi gb'adura",
                        "Ma ṣe huwa buburu, ọrẹ mi k'o ṣọra,",
                        "K'Ọlọrun k'o ba le fẹran rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun Baba wa",
                        "Iwọ l'awa gbẹkẹle",
                        "Ṣaanu wa ma jẹ k'oju ti wa l'Ọjọ aiye wa yü",
                        "T'o kun fun ipọnju",
                        "K'a ba le j'ogun Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mimọ Mimọ",
                        "L'Ọlọrun Baba wa",
                        "Ẹlẹda Ọrun oun aye",
                        "Ki l'a le fi j'ogun",
                        "Ninu aye wa yii",
                        "Ko si mọ, a f'ọdọ Rẹ nikan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Ọlọrun wa",
                        "Jẹ k'a ri Ogo Rẹ",
                        "Nigba ti opin Ọjọ ba de",
                        "K'ẹmi wa bọ s'ọwọ Rẹ",
                        "Oluwa b'o ti le pe",
                        "K'ẹmi wa ri 'simi alafia.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ayọ Ayọ Ayọ ni ti wa",
                        "Ẹyin Ijọ, ẹ jẹ k'a maa yọ",
                        "K'a di amure wa",
                        "K'a tọ Jesu lẹhin",
                        "Ki igbesi aye wa k'o san wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "296",
            Title = "GBA MO BA JI",
            Category = "ORIN ONIRUURU",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
                "Gba mo ba ji",
                "Ma ke pe Oluwa",
                "Oluwa l'Ọba mi",
                "Oun ni mo n ke pe",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Gbọ adura mi",
                        "Wa feti s'ẹbẹ mi",
                        "Ninu otito Rẹ Baba",
                        "Wa da mi lohun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Gbọ adura mi",
                        "Ọngbẹ ngbẹ ọkan mi",
                        "Baba wa da mi lohun",
                        "Ninu otito Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gbọ adura mi",
                        "Olubukun l'Oluwa mi",
                        "Ninu otito Rẹ Baba",
                        "Wa da mi lohun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gbọ adura mi",
                        "Mo gboju soke si Ọ",
                        "Ninu otito Rẹ Baba",
                        "Wa da mi lohun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Gbọ adura mi",
                        "Wa mu mi mọna Rẹ",
                        "Ninu otito Rẹ Baba",
                        "Wa da mi lohun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "297",
            Title = "AABO RẸ ELEDUMARE",
            Category = "ORIN ONIRUURU",
            Author = "J. B. Akinkuoye",
            Chorus = new List<string>
            {
                "Aabo Rẹ (2ce)",
                "Aabo Rẹ Eledumare Ọba Mimọ",
                "Baba ma ṣai fun wa ni aabo Rẹ",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi a ba ji, bi a ba sun",
                        "Baba ma ṣai fun wa ni aabo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ninu ile, l'oju ona, Baba…",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi a rin losan, bi a rin l'oganjo Baba…",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bi a rin n'ile, bi a fo l'oke Baba…",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "L'ori ile, l'ori omi, Baba...",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ninu iṣẹ, ninu faaji, Baba…",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Bi a n ṣ'ọdun, bi a n gb'aawe Baba…",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Ninu ipọnju, ninu wahala, Baba…",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Laarin ẹgbẹ, laarin ọgba, Baba…",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Ni ọjọ aye, lẹhin iku o; Baba…",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "298",
            Title = "WA BA WA YỌ",
            Category = "ORIN ONIRUURU",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
                "Ẹ wa ba wa yọ, gbogbo agbaye",
                "Pipe ni iṣẹ ọwọ Oluwa,",
                "Awamaridi n'ise Rẹ,",
                "Otito sa ni ọrọ Rẹ,",
                "Iba, Awimayehun.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nigbati a wo ayika,",
                        "Ogo iṣẹ Rẹ han lori eweko",
                        "Ọtun iṣẹ Rẹ han ni riru rẹ,",
                        "Gbogbo aye yọ, ninu iṣẹ Rẹ,",
                        "Iba f'Ọlọrun loke.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O da ewebe, l'ounjẹ ẹda,",
                        "F'awọn ẹranko at'ẹyẹ oju Ọrun",
                        "Iṣẹ Rẹ wa, lẹsẹlẹsẹ o,",
                        "Baba wa loke, a nyin Ọ o,",
                        "Iyin ni fun Ọ loke.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oke ati ilẹ, lo ti da,",
                        "Oorun, Osupa; iṣẹ ọwọ Rẹ han,",
                        "Ọba to ga ju, a juba Rẹ o,",
                        "Iba, Adaramaja.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Alagbalugbu, omi lo ti da,",
                        "Iyangbe ilẹ, iṣẹ ọwọ Rẹ ni,",
                        "Ẹja at'ẹran to nrin ninu rẹ,",
                        "Oyigiyigi Olu-Ọrun o,",
                        "Iba aṣekanmaku.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "B'Ọmọde juba agba, a jere ọgbọn",
                        "Ekolo juba ilẹ, o ra wọle lọ",
                        "Baba Mimọ a wa juba Rẹ loni o",
                        "Baba Mimọ o, jẹ ki 'ba ṣe o,",
                        "Iba f'Olu-Ọrun o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "299",
            Title = "BA WA GBẸ",
            Category = "ORIN ONIRUURU",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ba wa gbẹ o, Baba ba wa gbẹ o (2ce)",
                        "Oorun ti wọ tan, Ilẹ fẹrẹẹ ṣu,",
                        "Ayé nyi lọ bi ago, igba mbọ bi orere",
                        "Ibi aye ko kọ si, ẹda kan ko mọ",
                        "Jehovah l'o mọ, Ẹda nlogba",
                        "Wọn gbagbe atisun wọn, e,",
                        "Ba wa gbẹ o, Baba ba wa gbẹ o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ṣọ wa o, Baba ṣọ wa o (2ce)",
                        "Baba wa Ọrun a bọwọ fun Ọ ye,",
                        "Araye ba s'ibuba, wọn nhuwa ika laironu",
                        "Ọba t'o ni'le aye, O n ri wọn o",
                        "Ṣugbọn wọn ko mọ, Wọn gbin ebu ika",
                        "Ọmọ wọn a jẹ mbẹ o e,",
                        "Ṣọ wa o, Baba ṣọ wa o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Da wa si o, Baba da wa si o (2ce)",
                        "Balogun Ọrun, a bẹbẹ dakun ye,",
                        "B'aye gbogun de o e, jọwọ tete ba wọn wi",
                        "Ọba to da wa s'aye, jọwọ sọ wa o",
                        "Jọwọ gba wa o, nigba kugba,",
                        "Ma ma jẹ k'a rahun o e,",
                        "Da wa si o, Baba da wa si o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mi si wa o, Baba mi si wa o (2ce)",
                        "F'ifẹ Rẹ ran wa, k'a le fẹran Rẹ tan",
                        "Baba da wa lọla o, f'ifẹ Rẹ ba wa gbẹ",
                        "Ọba a-funni-lọla-a-funni-l'ayọ",
                        "Bukun fun wa o, awa ma bẹbẹ",
                        "Ma ma jẹ k'a lọ lọwọ ofo e",
                        "Mi si wa o, Baba mi si wa o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Da wa nide, Baba da wa nide (2ce)",
                        "Baba wa Ọrun Imọlẹ aye",
                        "Irumi aye de o, Ẹsẹ wa wa wa ri",
                        "Ọba to ni wa ṣaanu wa o",
                        "Fa wa mọra o, jọwọ gba wa la",
                        "K'a le simi lọdọ Rẹ e",
                        "Da wa nide, Baba da wa nide.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "300",
            Title = "SIN WA DE 'LE ỌLỌRUN",
            Category = "ORIN ONIRUURU",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Sin wa de'le Ọlọrun, sin wa de'le o",
                "Sin wa de'le Ọlọrun Edumare",
                "Dakun Baba rere sin wa lọ",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ibukun Rẹ s'ori wa",
                        "A n ke pe Ọ Ọlọrun wa",
                        "Ran wa lọwọ Ọlọrun o",
                        "Maa sin wa lọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọpọ ibukun Rẹ la n tọro",
                        "Baba Mimọ jọwọ da wa lohun",
                        "Jọwọ wa gbọ Ọlọrun o",
                        "Maa sin wa lọ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "301",
            Title = "BABA MIMỌ WA GBỌ T'EMI",
            Category = "ORIN ONIRUURU",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
                "Baba Mimọ wa gbọ t'emi o, Baba",
                "Olugbala wa gbọ t'emi o, Ọmọ",
                "Ẹmi Mimọ mo ke pe Ọ, rọ'jo Ibukun",
                "Mẹtalọkan wa gbọ t'emi ye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi mo ba sa ti le sin Ọ o, Baba",
                        "Ọrọ gbogbo ti niyanju o, Baba Mimọ",
                        "Ẹda t'o ba ti gbẹkẹle Baba rere,",
                        "Ilẹ-ayé ko l'ẹru fun un mọ ......",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọwọ ti mo ni o, Baba rere",
                        "Ọmọ ti mo ni o, Baba Mimọ",
                        "Alafia t'o ju 'yi o Baba,",
                        "Lọwọ Rẹ l'o ma ti wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jọwọ wa fun mi l'ayọ to pọ Baba,",
                        "F'ere s'ori iṣẹ mi o, Baba Mimọ",
                        "Da mi lọla pẹlu owo at'Ọmọ rere",
                        "Olubukun wa gbọ t'emi ye.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "B'ayé ba gb'ogun de gba mi o Baba",
                        "B'ẹṣu l'o gb'ogun de gba mi o Baba Mimọ",
                        "Ọta ile, ọta ode pọ Baba rere",
                        "Baba Mimọ mo gbẹkẹ mi le.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "B'iku ba wa gb'ọwọ eso igberaga",
                        "Jẹ k'o ba wa l'abẹ eso irẹlẹ",
                        "Idajọ ti ko l'agbejoro, Baba",
                        "Ibi Mimọ ni k'Ọ pe wa si.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "302",
            Title = "WA BA WA GBẸ EDUMARE",
            Category = "ORIN ONIRUURU",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Wa ba wa gbẹ Edumare",
                        "Baba wa Ọrun",
                        "Wa f'ifẹ Rẹ da wa lọla",
                        "Wa ba wa gbẹ o",
                        "Wa f'ifẹ Rẹ ragabo wa",
                        "Baba wa Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Wa fun wa l'ayọ Edumare",
                        "Baba wa Ọrun (2ce)",
                        "J'ayọ ifẹ Rẹ ka wa lori",
                        "Wa fun wa l'ayọ",
                        "Jẹ ayọ ifẹ Rẹ yi wa ka o",
                        "Baba wa Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa ba wa gbẹ pọ Edumare",
                        "Olutọju wa (2ce)",
                        "Wa fi'tọju Rẹ ka wa lori",
                        "Wa ba wa gbẹ pọ",
                        "Wa fi 'tọju Rẹ ragabo wa",
                        "Baba wa Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wa da wa si Edumare",
                        "Oluranlọwọ wa (2ce)",
                        "Ṣe 'tọju wa, f'aabo bo wa",
                        "Wa da wa si o",
                        "Ṣe 'tọju wa, f'aabo bo wa",
                        "Baba rere Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Wa fun wa ni iwa atata",
                        "K'a fi 'wa jọ Ọ d'opin",
                        "Atẹle Rẹ ni gbogbo ẹda",
                        "Wa fun wa ni iwa atata",
                        "Mu iwa ifẹ Rẹ si wa l'okan",
                        "Baba wa Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Wa mu wa de'po atata",
                        "Ṣe iranlọwọ (fun) wa (2ce)",
                        "Ibukun Rẹ l'a bẹbẹ fun",
                        "Wa mu wa de'po atata",
                        "Alewilesẹ rọ'jo Ibukun",
                        "Ṣe iranlọwọ (fun) wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "303",
            Title = "ORIN IBATISI",
            Category = "ORIN ONIRUURU",
            Author = "Ẹgbẹ Akorin Bodija",
            Chorus = new List<string>
            {
                "Mo wẹ ninu omi iwa rere",
                "Mo d'Ọmọ Ọlọrun lat'oni lọ",
                "Mo wẹ ninu omi iwa rere.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọjọ mo sun mọ Ọlọrun",
                        "Orisun iye ni mo sun mọ",
                        "Ọjọ mo gba Jesu l'Ọba",
                        "Mo n'iye ti ko nipekun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A mu mi de'le Ọlọrun",
                        "A mu mi t'ọna ibi Mimọ",
                        "Mo ri're Onigbagbọ o",
                        "Mo n'iye ti ko nipekun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa lo ba mi ṣẹgun",
                        "Ẹgbẹ t'ẹṣu ni mo sa fun",
                        "Ọlọrun mo gbẹkẹle Ọ",
                        "Mo juba, wa pẹlu mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ara aiye t'o nlọ s'Ọrun",
                        "Ẹ yara t'ọna Ọba Mimọ",
                        "Orukọ ti Jesu l'o yẹ",
                        "K'a ke pe de 'bugbe Ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "304",
            Title = "Ẹ KỌRIN TITUN SI OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "Gbogbo ar'aiye ẹ kọrin o",
                "Ẹ kọrin titun s'Oluwa",
                "Awimayehun Ọga Ogo.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ kọrin si Oluwa",
                        "Ẹ fi ibukun f'Orukọ Rẹ",
                        "Ẹ fi igbala Oluwa han lojojumo",
                        "Ẹ yin Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Oníṣe ara l'Oluwa",
                        "Ọrọ Ogo ati iṣẹ iyanu Rẹ la o ma sọ",
                        "Larin awọn eniyan aiye gbogbo.",
                        "Ẹ yin Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Atobiju l'Oluwa",
                        "O ni iyin k'aiye o",
                        "O t'ayọ orisa aiye gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹlẹda Ọrun l'Oluwa,",
                        "Asan ni orisa aiye gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọla nla l'Oluwa",
                        "Ẹwa ibugbe Mimọ Rẹ",
                        "Ko ṣe-e f'ẹnu sọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Orukọ Oluwa",
                        "Aiye ẹ f'ogo fun",
                        "Ẹ mọrẹ yin wa o,",
                        "S'agbala Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ẹ maa sin Oluwa",
                        "Ninu ẹwa Mimọ Rẹ",
                        "Ẹ bẹru Oluwa",
                        "Araiye gbogbo.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Iwọ Ọrun maa yọ",
                        "Ki inu aiye ko ma dun",
                        "Iwọ okun fi iho kikun",
                        "Yin Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Iwọ oko kun fun ayọ",
                        "Pẹl'awọn irugbin rẹ",
                        "Igi gbogbo ninu igbo",
                        "Ẹ yọ si Oluwa",
                        "Awimayehun Ọba Ogo.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Oluwa ma mbọ",
                        "Lati wa ṣe 'dajo",
                        "Ar'aiye gbogbo akomatika lẹhin l'Oluwa o",
                        "O mbọ wa ṣe idajo aiye gbogbo",
                        "Ogo ni fun Baba ati fun Ọmọ etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "305",
            Title = "GBỌ ADURA MI OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
                "Gbọ adura mi Oluwa",
                "Ko si jẹ ki igbe mi wa s'ọdọ Rẹ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ma ṣe pa oju Rẹ mọ kuro l'ara mi",
                        "Li ọjọ ti emi wa ninu ipọnju",
                        "De eti Rẹ si mi, da mi l'ohun l'ogan.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nitori ti ọjọ mi nlọ bi eefin",
                        "Egungun mi si jona, gẹgẹ bi aaro idana.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ṣugbọn Iwọ Oluwa ni yio duro titi",
                        "Ati iranti Rẹ lati iran de iran",
                        "Iwọ yio si dide, Iwọ yio ṣaanu",
                        "F'awọn ti o n tẹle Ọ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Bẹni awọn keferi yio maa bẹru Oluwa",
                        "Ati gbogbo ọba yio bẹru Rẹ:",
                        "Nigbati Oluwa yio gbe Sioni ro;",
                        "Oun yio fara han, ninu ogo Rẹ fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "306",
            Title = "ỌLỌPẸ L'ỌPẸ YẸ",
            Category = "ORIN ONIRUURU",
            Author = "Michael Adu",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "Lile:",
                    Lines = new List<string>
                    {
                        "Ọlọpẹ l'Ọpẹ yẹ ara mi (2ce)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọpẹ yẹ o Baba wa",
                    }
                },
                new Verse
                {
                    Number = "Gbogbo Ijo:",
                    Lines = new List<string>
                    {
                        "K'a fi 'ba fun Ọ Baba Mimọ",
                        "K'a fi iyin fun Ọ Iya Mimọ",
                        "Iwọ l'Ọpẹ yẹ Ọ Baba wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọba Mimọ A dupẹ o",
                    }
                }, new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọpẹ yẹ o Baba wa",
                        "Olọore-ọfẹ a dupẹ o",
                        "Iwọ l'Ọpẹ yẹ o Baba wa K'a…",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mẹtalọkan Mimọ a dupẹ o",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọpẹ yẹ o Baba wa",
                        "Olubukun a dupẹ o",
                        "Iwọ l'Ọpẹ yẹ o Baba wa K'a…",
                        
                    }
                },
                new Verse
                {
                    Number = "Gbogbo Ijo:",
                    Lines = new List<string>
                    {
                        "K'a fi 'ba fun Ọ Baba Mimọ",
                        "K'a fi iyin fun Ọ Iya Mimọ",
                        "Iwọ l'Ọpẹ yẹ Ọ Baba wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Olodumare a dupẹ o",
                    }
                },
                     new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọpẹ yẹ o Baba wa",
                        "Jesu Kristi a dupẹ o",
                        "Iwọ l'Ọpẹ yẹ o Baba wa K'a ...",
                        
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimọ a dupẹ o",
                    }
                },
                 new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ l'Ọpẹ yẹ o Baba wa",
                        "Olumọran a dupẹ o",
                        "Iwọ l'Ọpẹ yẹ o Baba wa K'a...",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "307",
            Title = "AWA FORIBALE FUN BABA ALAANU",
            Category = "ORIN ONIRUURU",
            Author = "H. A. Ọrẹdipẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "",
                    Lines = new List<string>
                    {
                        "Ọlọrun jọwọ f'eti si wa",
                        "K'o boju wo wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Iwọ nikanṣoṣo l'a f'ehinti",
                        "Ma dojuti wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Jẹ k'aiye wa dun bi iyọ",
                        "Jọwọ pese fun wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Fun wa n'igbagbọ,",
                        "Ireti ati ifẹ eni.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Ma jẹ k'a ṣubu sinu ẹsẹ",
                        "Fi 'mọlẹ fun wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Fun wa n'irẹpọ",
                        "Iforiti at'orire.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "F'awọn alaisan ni 'lera",
                        "Ati inu didun.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Ma jẹ k'agbara okunkun",
                        "Jọba ninu wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Ma jẹ k'a d'ẹni aṣati",
                        "Lọdọ Rẹ Baba.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                        "Ọlọrun jọwọ f'eti si wa",
                        "K'o boju wo wa.",
                        "Awa foribale fun Ọ o, Baba Alaanu",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "308",
            Title = "ỌDUN CECILIA MIMỌ",
            Category = "ORIN ONIRUURU",
            Author = "J. A. Kuforiji",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹgbẹ Ọlorin, ẹ kọrin titun si Oluwa,",
                        "Ẹ ku Ọdun, Ọdun a yabo,",
                        "Ọdun a yabo fun wa,",
                        "Ẹgbẹ Ọlorin, ẹ kọrin titun si Oluwa,",
                        "Ẹ ku Ọdun, Ọdun a yabo",
                        "Ẹ fi fere ati dundun oun agogo yin Oluwa",
                        "Ki ẹ si gbe Ẹ ga, ẹ gbe Ẹ ga",
                        "Ẹ gbe Ẹ ga, ki ẹ si gbe Ẹ ga, ẹ gbe Ẹ ga (2ce)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹgbẹ Ọlorin, ẹ kọrin Ọpẹ si Oluwa,",
                        "Ẹ tun ṣapẹ, pẹlu ariwo.",
                        "Ẹ ṣapẹ si Oluwa,",
                        "Ẹgbẹ Ọlorin, ẹ kọrin Ọpẹ si Oluwa,",
                        "Ẹ tun ṣapẹ, pẹlu ariwo.",
                        "Egbegberun awọn Mimọ ni orin wọn yin Oluwa,",
                        "Ni 'bugbe Ọlọrun, wọn gbe Ẹ ga.",
                        "Wọn gbe Ẹ ga…",
                        "Ni 'bugbe Ọlọrun, wọn gbe Ẹ ga (2ce)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Alaabo ni, Cecilia ẹni Mimọ ni,",
                        "Ẹni nla ninu orin.",
                        "Ẹni nla ninu orin.",
                        "Alaabo ni, Cecilia ẹni Mimọ ni",
                        "Ẹni nla ninu orin.",
                        "K'a jo fi duru ati molo oun agogo yin Oluwa,",
                        "Ki a si gbe Ẹ ga, k'a gbe Ẹ ga.",
                        "K'a gbe Ẹ ga……..",
                        "Ki a si gbe Ẹ ga, k'a gbe Ẹ ga. (2ce)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "309",
            Title = "PETERU",
            Category = "ORIN ONIRUURU",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa, Iwọ mọ pe mo fẹ Ọ",
                        "Gb'ẹbun igbagbọ, alaileṣe eyiti mo fun Ọ",
                        "Gb'ẹbun igbagbọ, eyiti mo fun Ọ",
                        "Maa bọ awọn agutan mi.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ lapata mi",
                        "Maa bọ awọn agutan mi /",
                        "Gb'ẹbun igbagbọ alaileṣe",
                        "Eyiti mo fun o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Si-moni / Ọmọ Jo-ha-nu / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa / Iwọ mọ pe mo fẹ Ọ",
                        "Gb'ẹbun igbagbọ alaileṣe eyiti mo fun Ọ",
                        "Maa bọ awọn agutan mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa / Iwọ mọ ohun gbogbo",
                        "Gb'ẹbun igbagbọ alaileṣe eyiti mo fun Ọ",
                        "Maa bọ awọn agutan mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa / Iwọ mọ pe mo fẹ Ọ",
                        "Gbogbo agbara li a fun mi, l'Ọrun ati aiye",
                        "Maa bọ awọn agutan mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa / Iwọ mọ pe mo fẹ Ọ",
                        "Emi o wa pẹlu yin ni ọjọ gbogbo",
                        "Maa bọ awọn agutan mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Pe-te-ru / Iwọ fẹran mi bi?",
                        "Bẹẹni Oluwa / Iwọ mọ pe mo fẹ Ọ",
                        "Ẹni t'o ba gba 'batisi la o gbala",
                        "Ẹni ti ko ba gba a gbọ, la o da lẹbi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "310",
            Title = "DABỌ OLU AIYE",
            Category = "ORIN ONIRUURU",
            Author = "Jide Ogunsusi",
            Chorus = new List<string>
            {
                "Dabọ Olu aiye, a ke pe Ọ (2ce)",
                "Awa l'ayanfe Eledumare awa mbẹ Ọ o",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ile ayọ tootọ",
                        "Ile ayọ n'ile Rẹ",
                        "Awa ko ni ṣa lai de bẹ",
                        "Awa mbẹ Ọ o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "K'oju maa ti wa l'aiye",
                        "Awa ọmọ Rẹ",
                        "Ma ṣe jẹ ki keferi yọ wa",
                        "Jọwọ gba wa o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "T'o ba d'Ọjọ idajọ",
                        "Gba wa s'ọwọ Ọtun Rẹ",
                        "Jẹ k'a ba Ọ yọ l'Ọrun rere",
                        "Awa mbẹ Ọ o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọta nle wa kiri l'aiye",
                        "Wọn ko le ri wa gbẹsẹ",
                        "L'agbara Edumare",
                        "Awa mbẹ Ọ o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Igba t'Ọlọjọ ba de",
                        "K'o ka'ṣẹ rere mo wa l'ọwọ",
                        "Ka wa le jogun iye ainipẹkun",
                        "Awa mbẹ Ọ o, Baba.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "311",
            Title = "JESU MU WA DURO",
            Category = "ORIN ONIRUURU",
            Author = "Jide Ogunsusi",
            Chorus = new List<string>
            {
                "Jesu Mimọ mu wa duro",
                "A di Ọ mu, Sure Rẹ fun wa,",
                "Bukun wa a mbẹ Ọ o,",
                "T'ọju awa ọmọ Rẹ k'a le yin",
                "Ọlogo o, ẹbẹ l'a bẹ Baba k'o ṣe wa l'okan.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ti a ba sun ti a ba ji",
                        "K'atun sọpẹ f'Oluwa",
                        "'Tori oun l'o ṣe 'tọju wa",
                        "Awa mbẹ Ọ o, Baba.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ jẹ k'a jo, k'a yọ, ki a ho iho ayọ;",
                        "Ọjọ oni de l'ayọ, o ṣoju ẹmi wa,",
                        "Gbogbo Ijọ ẹ jẹ k'a sọpẹ f'Oluwa",
                        "(Idasile agbegbe yii o ba wa l'ayọ).",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọlọrun Baba t'o da wa, l'o,",
                        "Fun wa l'ayọ yọ, Eledumare,",
                        "Baba o ṣe o, k'ade pe l'ori o,",
                        "Ki bata pe l'ẹsẹ o,",
                        "Ọlọrun k'o fi ẹ ṣ'asaaju rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Igba l'onigba nlọ igba Tirẹ a san wa,",
                        "Igba Tirẹ a ye wa, igba Tirẹ a dara;",
                        "A de wa l'Ọrun Biṣọbu o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awa ko le gbagbe Rẹ Biṣọbu Field wa.",
                        "Iwọ l'o ti nko wa bọ, a dupẹ lọwọ Rẹ,",
                        "Oluwa jọwọ ko daabo bo wa l'aiye o.",
                        "K'a le pada s'ọdọ Rẹ n'ibi ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "312",
            Title = "B'O ṢE TEMI NI",
            Category = "ORIN ONIRUURU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
                "B'o ṣe temi ní, ati 'le mi",
                "Oluwa la wa o ma sin titi aiye o.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Lootọ, lootọ l'ẹti wi nigbani pe,",
                        "Bere a o fi fun yin, wakiri ẹyin yio ri i,",
                        "Kanku a o ṣi silẹ fun yin nigbakugba",
                        "Ohun ti a beere niyi, o si fun wa.",
                    }
                },
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Inu mi dun nigbati a sọ fun mi pe",
                        "Ẹ jẹ ka re 'le Oluwa, ka tọ Baba lọ",
                        "Onile ayọ mo wa wa, mo fẹ lati sin",
                        "Iwọ nikan ni n'g o maa sin titi aiye o.",
                        "Ara ẹ wa sin Oluwa,",
                        "Ẹyin ti ẹ fẹ igbala,",
                        "Ẹ wa sin Oluwa,",
                        "Wa kọrin iyin s'Ọba Ogo,",
                        "Ẹyin ti nrin ni okunkun",
                        "Ẹ wa sinu Imọlẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Inu mi dun nigbati mo wọ inu ile",
                        "Mo wọ inu ile Oluwa mo ke si I tantan",
                        "Onile ayọ jọwọ wa da mi lare o",
                        "Iwọ nikan ni n'g o maa sin titi aiye o.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Inu mi dun mo ti wọ inu ile naa",
                        "Mo wọ inu ile Mimọ, mo d'ẹni rere",
                        "Onile ayọ jọwọ wa ṣe mi lọmọ o",
                        "Iwọ nikan ni n'g o maa sin titi aiye o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "313",
            Title = "ARA Ẹ WA SIN OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "A. A. Ogunsanwo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Inu mi dun mo ti d'ẹni ọlọla",
                        "Mo jogun ohun Mimọ mo d'Ọmọ gidi.",
                        "Mo l'Ọlọrun, ayọ mi kun, ire bami o.",
                        "Iwọ nikan ni n'g o maa sin titi aiye o.",
                        "Wẹ wa mọ Olu-Ọrun",
                        "Ẹlẹsẹ nkepe Ọ o,",
                        "Mu wa yẹ fun ile Rẹ.",
                        "Ki a le sin Ọ b'o ti yẹ,",
                        "F'ifẹ Rẹ si wa l'okan",
                        "Baba dakun ye o.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Oni ni ọjọ naa pe o,",
                        "Ọjọ ti a yan fun Oluwa",
                        "Oni ni ọjọ naa pe o,",
                        "Ọjọ sinsin Oluwa,",
                        "Ẹyin ti nreti irapada,",
                        "Ẹ wa sin Jesu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Wa sibi pepe Oluwa,",
                        "Ẹyin ti nreti idariji",
                        "Wa s'ọdọ Oluwa.",
                        "Da aniyan rẹ si Oluwa.",
                        "Ẹyin ti ṣaare ọkan,",
                        "Wa s'ọdọ Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O ti ṣetan lati gba yin o,",
                        "Onírobinujẹ ọkan, wa s'ọdọ Jesu,",
                        "Jesu npe nyin tantan o,",
                        "Onírobinujẹ ọkan, ẹ turaka o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "314",
            Title = "MO TI DURO TI JESU",
            Category = "ORIN ONIRUURU",
            Author = "Oloye L. A. Owolabi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo ti duro ti Jesu mo d'Ọlọla",
                        "Mo riye nitemi (2ce)",
                        "Mo ti duro mọ Baba, mọ Baba o.",
                        "Ọba Ọlogo julo (2ce)",
                        "Mo ti duro ti Jesu, mo d'Ọlọla",
                        "Mo riye nitemi.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo ti l'Oluwa to ju, mo ti dade",
                        "Mo l'ayọ ni temi (2ce)",
                        "Ọba oke mo bẹ Ọ, mo bẹ Ọ,",
                        "Wa ko gbaiye mi gun (2ce)",
                        "Mo ti l'Oluwa to ju, mo ti dade",
                        "Mo l'ayọ ni temi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ara Mimọ Jesu l'Ọba Mimọ",
                        "Fi nṣe kẹ mi (2ce)",
                        "Olugbala Ọ ma ṣe, Ọ ma ṣe o,",
                        "To mbọ mi yọ (2ce)",
                        "Ara Mimọ Jesu, l'Ọba Mimọ fi nṣe kẹ mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹjẹ Mimọ Jesu l'Ọba Ọlọla",
                        "Fi nwo mi san o",
                        "Mo gbawosan, mo d'Ọga, mo d'Ọga o,",
                        "Baba lo gbe mi ro",
                        "Ẹjẹ Mimọ Jesu l'Ọba Ọlọla fi nwo mi san o.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Baba Mimọ mo ke pe k'Ọba Ọlọla",
                        "Fi didun s'ọran mi",
                        "Wa f'aabo Rẹ bo mi, ye Baba o,",
                        "Ọba Atobijulo",
                        "Baba Mimọ mo ke pe k'Ọba Ọlọla",
                        "Fi didun s'ọran mi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "315",
            Title = "IGBAGBỌ DARA O",
            Category = "ORIN ONIRUURU",
            Author = "Ẹgbẹ Akọrin Oṣogbo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Igbagbọ dara o, ẹ jẹ ka gb'Ọlọrun gbọ",
                        "Ẹni da wa titi d'Ọjọ oni o.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ireti mbẹ o, bi a ba sin Mẹtalọkan",
                        "Ọjọ a darapọ ba d'Ọjọ ikẹhin.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Anfani mbẹ Ọ, bi a ba ṣe ifẹ ni",
                        "Ẹni fẹ'Ọlọrun ko ni ṣalai ni o.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ifẹ dara ju, jẹ ka ṣe ifẹ o.",
                        "Ẹni ba ni i ko s'ohun ti ko ni o.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "316",
            Title = "JESU ORISUN IYE WA",
            Category = "ORIN ONIRUURU",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu orisun iye wa o (2ce)",
                        "Olugbala a ki Ọ na",
                        "A dọbalẹ a bẹbẹ",
                        "Wa gbọ ti gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jesu o, Ore-ọfẹ",
                        "Ọgbọ́n at'agbara",
                        "Wa fi wa ṣ'ayanfẹ Rẹ",
                        "Oluwa j'aiye yẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu orisun iye wa o (2ce)",
                        "Ọdọ Agutan Olu-aye",
                        "Oludabobo ẹlẹsẹ",
                        "Wa gbọ ti gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu orisun iye wa o (2ce)",
                        "Ọmọ Maria Ọpẹ yẹ Ọ",
                        "Fun ifẹ Rẹ f'ọpọ eniyan",
                        "Wa gbọ ti gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu orisun iye wa o (2ce)",
                        "Alailakaye ẹni Mimọ",
                        "Oníwa tutu Olumọran",
                        "Wa gbọ ti gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu orisun iye wa o (2ce)",
                        "Ọba Olupese gbọ ti wa na",
                        "Ọba Atobiju, a bẹbẹ",
                        "Wa gbọ ti gbogbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "317",
            Title = "Ẹ RONU Ẹ PIWADA",
            Category = "ORIN ONIRUURU",
            Author = "Alufaa T. M. Ilesanmi",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹ ronu ẹ piwada nitori Ajinde e e e",
                        "Ẹ ronu ẹ piwada nitori atisun dandan",
                        "Ẹsẹ rẹ ko ni takọkọ o, tirẹ kọ lo fa iwọn ju",
                        "Bi o ba ti le yi wa pada, Baba a tun ẹ ṣe",
                        "Ẹ ronu ẹ piwada nitori atisun dandan.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ ronu ẹ piwada ki ẹ fẹ Baba dopin",
                        "Ẹ ronu ẹ piwada ki ẹ fẹnikeji dandan",
                        "Iwa ifẹ ni Baba n fẹ o, iwa ifẹ Olugbala",
                        "Ti a ba tile fẹnikeji, Baba a tun wa ṣe",
                        "Ẹ ronu ẹ piwada ki ẹ f'ẹnikeji dandan.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Araiye ẹ piwada ẹ s'aiye yi d'otun",
                        "Araiye ẹ piwada ẹ tan 'na Imọlẹ rere",
                        "Iwa ẹsẹ ti ba 'lu jẹ o, iwa ẹsẹ ti pọ pọ ju",
                        "Bi ẹ ba tile yiwa pada, ẹ ti t'aiye ṣe",
                        "Araiye ẹ piwada ẹ tan 'na Imọlẹ rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Mo b'Oluwa ṣowo pọ mo ti r'ere t'o tobi",
                        "Mo b'Oluwa ṣowo pọ mo jogun Ajinde",
                        "Ajaga ifẹ tile fu-yẹ o, ilana ifẹ r'Ọrun wẹyẹ",
                        "Ọjọ ti mo f'ifẹ mi han, ni mo sunmọ Baba",
                        "Mo b'Oluwa ṣowo pọ, mo jogun Ajinde.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo ti r'Ọmọ enia ti nwa'ye yi mọ'ra",
                        "Mo ti r'Ọmọ enia ti nj'aiye ajẹju dandan",
                        "Ihoho to fi rin w'aiye o, ihoho lo pada r'oke",
                        "Ọjọ to lọ 'bugbe ikẹhin ebi lo ba lọ",
                        "Mo ti r'Ọmọ enia to nj'aiye ajẹju dandan.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "318",
            Title = "ṢAANU FUN WA OLUWA",
            Category = "ORIN ONIRUURU",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
                "Ṣaanu fun wa Oluwa Ọba Olubukun",
                "Ṣaanu fun wa Oluwa",
                "Rọ'jo ibukun fun gbogbo wa",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Dawa lọla Oluwa",
                        "Ti wa lẹhin Olupese",
                        "Ran wa lọwọ",
                        "Oluwa rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ọba Oluwa a pe Ọ",
                        "Awihun-mayẹ a bẹbẹ",
                        "Fun wa l'ọgbọn Oluwa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olu aiye l'Ọlọrun",
                        "Arinurode l'Olumọran",
                        "Gba wa lọwọ ọta wa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fun wa l'oye Oluwa",
                        "Fun wa ni Imọ, Ọba iye",
                        "Rẹ wa l'ekun Oluwa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mu wa duro ṣinṣin Oluwa",
                        "Fun wa ni igbagbọ atata",
                        "Gbawa lọwọ abinu ẹni",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Wa ba wa gbẹ Oluwa",
                        "Tọ wa s'ona, ẹni ọwọ",
                        "Ka f'iwa jọ Ọ Oluwa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "K'ile san wa d'Ọjọ alẹ",
                        "K'ọna san wa d'Ọjọ ikẹhin",
                        "Dun wa ninu Oluwa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "K'a ṣe t'Oluwa nile aiye o",
                        "Ka gbọ ti Jesu l'ona ododo",
                        "Baba Mimọ Oluwa",
                        "Rọ'jo ibukun fun gbogbo wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "319",
            Title = "A JUBA KI BA ṢẸ",
            Category = "ORIN ONIRUURU",
            Author = "J. B. Ojo",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A juba ki iba ṣe / Baba, jare a juba Rẹ",
                        "Gbogbo ẹda inu omi “",
                        "Eyiti mbẹ nile “",
                        "Eyi t'inu apata “",
                        "B'erin ba ji ninu igbo “",
                        "A f'iba f'onigbo “",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "B'ẹfọn ba ji l'Ọdan / Baba, jare a juba Rẹ",
                        "A f'iba f'olu-Ọdan “",
                        "Bi lekeleke ba ji “",
                        "A foribale f'Olu-Ọrun “",
                        "Ọgbọn Olodumare “",
                        "Wa s'ona wa n'ire “",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Oluwa Kristi a juba / Kristi, jare a juba Rẹ",
                        "Olugbala gbọ tiwa “",
                        "Wa fun wa ni ifẹ Rẹ (2ce) “",
                        "Ọmọ Maria Wundia “",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Maria Mimọ / Iya, Iya, a juba Rẹ",
                        "Ọlọla ju ninu ẹda “",
                        "Wundia Oloye julo “",
                        "Wundia Ọlọla “",
                        "Wundia alagbara “",
                        "Iya Oninure “",
                        "Iya Olododo “",
                        "Ṣe 'wa l'ododo “",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọrun a juba / Baba jare a juba Rẹ",
                        "Ọba Oyigiyigi “",
                        "Ọba alewilesẹ “",
                        "Ọba Afọhun-mayẹhun “",
                        "Wa dariji wa “",
                        "Ran Ẹmi Rẹ wa “",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "320",
            Title = "Ẹ JẸ K'A Ṣ'OTITO",
            Category = "ORIN ONIRUURU",
            Author = "P. Adeboye",
            Chorus = new List<string>
            {
                "Ṣ'otito, Onigbagbọ ṣ'otito, otito sunwọ",
                "Ṣ'otito, araiye ṣ'otito, otito ngbeni (2ce)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi a ba ṣ'otito, aiye yio toro fun wa",
                        "Bi a ba ṣ'otito, ifoya ko si fun wa",
                        "Ẹ jẹ k'a ranti wipe otito bori ohun gbogbo",
                        "O yẹ k'a ṣ'otito k'Oluwa le yọnu siwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi a ba ṣ'otito, igbega yio wa fun wa",
                        "Bi a ba ṣ'otito, iberu ko si fun wa",
                        "Ẹ jẹ ka ranti wipe otito bori ohun gbogbo",
                        "O yẹ ka ṣ'otito, k'Oluwa le sunmọ wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "321",
            Title = "ỌNA ARA L'ỌLỌRUN WA",
            Category = "ORIN ONIRUURU",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ki'lo yẹmi bi ko s'Ọpẹ o,",
                        "Ọna ara l'Ọlọrun wa. (2ce)",
                        "O da wa si ninu ọla, o fun wa l'oye,",
                        "O pawa mọ lọwọ iku, lọwọ aiye o,",
                        "N'g o ma f'ifẹ yin Ọ o, Baba, Ọna ara…",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ki'lo yẹmi bi ko s'Ọpẹ o, Ọna ara…",
                        "O da wa pe, O ponwale, O fun wa l'oye;",
                        "O fun wa ni jijẹ, mimu n'ile aiye wa,",
                        "N'g o ma f'ifẹ yin Ọ o, Baba, Ọna ara…",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ki'lo ṣe yin t'ẹ o s'Ọpẹ o,",
                        "Olugbala l'Ọlọrun Ọba (2ce)",
                        "O pawa mọ ninu aiye, o fun wa l'ogo,",
                        "O mu ipọnju kuro ni igbe aiye wa,",
                        "N'g o ma f'ifẹ yin Ọ o, Baba, Ọna ara…",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ki'lo ṣe yin t'ẹ o s'Ọpẹ o,",
                        "Olupese l'Ọlọrun Ọba (2ce)",
                        "Ẹyin ara ẹ wa s'Ọpẹ fun Oluwa,",
                        "Ẹ ma jo fun ọla ti o ṣe fun wa,",
                        "Ọpẹ, Iyin fun Ọlọrun Baba, Ọna ara…",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "322",
            Title = "ỌLỌRUN ỌBA AWỌN ỌBA",
            Category = "ORIN ONIRUURU",
            Author = "E. A. Alao",
            Chorus = new List<string>
            {
                "Ọlọrun Ọba awọn Ọba,",
                "Omimi ti nmi 'le aiye,",
                "A n kepe Ọ ninu ọdun yi,",
                "Olodumare jare wa gbọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A fi ẹmi wa le Ọ lọwọ,",
                        "A f'ara wa s'abẹ abo Rẹ",
                        "Ohun gbogbo ti a fẹ d'ọwọlẹ ṣe,",
                        "Jẹ k'o yọ'ri si rere Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ogun ẹjọ ma gbe ko wa Oluwa,",
                        "Ogun Ẹṣu, ba wa gbẹ fo lọ,",
                        "Ohun rere ti a fẹ d'ọwọlẹ ṣe,",
                        "Jẹ k'o yọ'ri si rere Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọrọ ẹkun, ma fi kan wa Oluwa.",
                        "Ibanujẹ; ba wa gbẹ fo lọ,",
                        "Ohun gbogbo ti a ba d'ọwọlẹ ṣe,",
                        "Jẹ k'o yọ'ri si rere Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Airoju ma fi kan wa Oluwa.",
                        "Ogun ija, ba wa gbẹ fo lọ,",
                        "Fi ifẹ rere si'nu gbogbo wa,",
                        "Ka le fẹran ara wa fun rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Airiṣe ma fi kan wa Oluwa",
                        "Ogun Iyan ba wa gbẹ fo lọ,",
                        "Fi ire ọmọ ka rii gbogbo wa",
                        "Gbe wa leke iṣoro l'aiye wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ọba Mimọ a kepe Ọ o, dakun",
                        "F'ire ayọ fun wa ka ma pọfo,",
                        "Ohun gbogbo ti a ba d'ọwọlẹ ṣe",
                        "Jẹ k'o yọ'ri si rere Oluwa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "323",
            Title = "YIN OLUWA IWỌ ỌKAN MI",
            Category = "ORIN ONIRUURU",
            Author = "Joseph Ọkẹ",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Yin Oluwa iwọ ọkan mi (2ce)",
                        "Ninu ọlá, ninu ọlà",
                        "Ninu ọrọ, ninu aini",
                        "Nitori ti o ṣeun",
                        "Fi gbogbo agbara rẹ yin Oluwa",
                        "Nitori Oun ni itanna rẹ",
                        "Nitori Oun ni Oludari",
                        "Oun l'Ọba Iye rẹ",
                        "Nitori Oun l'Ọba Otito",
                        "Emi ke pe Ọ Ọba Kristi",
                        "Iwọ l'a o maa yin titi lai.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Yin Oluwa iwọ ọkan mi (2ce)",
                        "Oun l'Ọba Olupese rẹ",
                        "Oun ni asala rẹ ni ipọnju",
                        "Oun ni alaabo rẹ ni ọjọ gbogbo",
                        "Oun ni atokan rẹ aiyeraiye",
                        "O yẹ jojọ o yẹ ni yin yin",
                        "O yẹ jojọ, o yẹ ni fi 'bo fun",
                        "Titi l'aiye ẹ maa yin Kristi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "324",
            Title = "OLUGBALA MIMỌ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Olugbala Mimọ sọkalẹ mbọ latọrun wa",
                "Olugbala a mbẹ o.",
                "Ninu itara wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A! mo bẹ Ọ, sọkalẹ wa",
                        "Gba wa kuro ninu ẹṣẹ,",
                        "L'iku buburu k'o gba wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Anu Tirẹ li a nreti,",
                        "Oluwa ni a gb'okanlẹ,",
                        "K'o rẹ ibinu Rẹ sile.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Gbọ, Jesu, adura wa,",
                        "N'nu ẹṣẹ l'a fẹ kuro;",
                        "Olugbala dariji wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Alafia Rẹ l'a nreti",
                        "K'awa tun le ri gba l'aiye.",
                        "Ohun rere t'a padanu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Oludande ni K'o wa ṣe.",
                        "A fẹ sin Ọ tọkantọkan!",
                        "K'a ba le d'ayanfẹ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "325",
            Title = "A TI BI ỌMỌ ỌLỌRUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "A ti bi Ọmọ Ọlọrun,",
                "Ẹda t'Ọrun nwon kọrin l'oke:",
                "A ti bi Ọmọ Ọlọrun.",
                "K'a mura lati yin l'aiye.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nipa isọtẹlẹ Woli,",
                        "A si reti Rẹ l'aiye yi",
                        "Nipa isọtẹlẹ Woli,",
                        "O dé l'akoko t'a da fun Un.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ maa wo b'o ti dara to!",
                        "Jesu t'abi l'aiye fun wa;",
                        "Ẹ maa wo b'O ti dara to",
                        "Ọmọ yi t'a npe l'Oluwa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "L'ibuje ẹran l'itẹ Rẹ",
                        "L'ori ẹni l'a gbé 'kalẹ",
                        "L'ibuje ẹran l'itẹ Rẹ,",
                        "Ẹ wo b'Ọlọrun ti rẹlẹ!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "On pe wa, a si maa duro,",
                        "Ati pa ookun ninu wa.",
                        "On pe wa, a si maa duro;",
                        "K'a ṣe ilẹ Rẹ l'okan wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu, Ọba Olugbala",
                        "Iwọ l'Ọlọrun t'o da wa.",
                        "Jesu, Ọba Olugbala,",
                        "Jọba l'ori araiye lai.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "326",
            Title = "AWỌN OLUSỌ AGUTAN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awọn Oluso Agutan",
                        "Ehati ṣe, L'oganjo yi t'imole",
                        "Didara tan bi orun.",
                        "Ti ha si nṣe wa?",
                        "Awọn Angeli.",
                        "Ẹ ma bẹru, K'e tara lọ;",
                        "Messia t'a duro de, Ti wà s'aiye yi;",
                        "Ẹ f'ayọ lọ, K'ẹ f'oju ba",
                        "Jesu ti Maria bi, L'ibuje ẹran.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn Angeli,",
                        "Ọmọ ọwọ T'o dubule l'ibuje",
                        "L'Ọba Ọrun on aiye, L'Olodumare.",
                        "Awọn Oluso Agutan",
                        "K'a má bẹru, K'a tara lọ;",
                        "Messia t'a nduro de. To wa s'aiye yi.",
                        "K'a f'ayọ lọ. K'a foju ba",
                        "Jesu ti Maria bi. L'ibuje ẹran.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn Oluso Agutan",
                        "Sa f'etisi, B'aw'angeli ti n kọrin",
                        "Ni yinyin Jesu l'ogo. Ọrin wọn dara.",
                        "Awọn Angeli.",
                        "Ẹ má bẹru, etc.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awọn Oluso Agutan",
                        "Nwọn jumo gbe, Jesu aṣegun leke,",
                        "Ẹniti o ti bori Ọrun-apadi.",
                        "Awọn Angeli.",
                        "Ẹ má bẹru etc.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awọn Angeli",
                        "Lat'oni lọ, Gbogbo awọn enia",
                        "T'o n'ifẹ inu rere, Yio j'alafia.",
                        "Awọn Oluso Agutan.",
                        "K'a má bẹru, etc.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "327",
            Title = "GLORIA IN EXCELSIS",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Gloria in excelsis Deo. (bis)",
                "Aw'Angeli l'a gbọ loke,",
                "Ti n kọrin didun kalẹ wa.",
                "Oke gbogbo si j'ajẹgba",
                "Ni gbigberin ayọ nla wọn.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nwọn jumo fi ayọ rohin",
                        "Wiwa Olugbala aiye;",
                        "Lati fi ìmọore wọn han",
                        "Nwọn f'ohun sọ Ọpẹ soke.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa gbọ bi wọn ti ma kọ",
                        "Ibi Ọmọ Olugbala,",
                        "T'o fẹ jọba l'aiye titun;",
                        "Njẹ, k'a ma kọrin l'ogo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Wa si Bethlemu, ẹ wa wo",
                        "Ọmọ t'awọn angeli yin;",
                        "Ẹ wa jẹ k'a bọ Ọ nikunlẹ,",
                        "Kristi Jesu Oluwa wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ki gbogbo ẹda ẹlẹmi,",
                        "K'o sọpẹ f'Ọmọ Jesu;",
                        "K'o si dupẹ tinutinu,",
                        "Ni fifohun kan kọrin yin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "328",
            Title = "JẸ K'A LỌ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Nibuje ẹran talaka,",
                        "L'a nreti wa gbogbo,",
                        "Olugbala wa Jesu,",
                        "Fẹ lati gb'okan wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jẹ k'a lọ s'ibuje ẹran.",
                        "Lati bẹ Jesu wo!",
                        "Ọlọrun, Olugbala.",
                        "O ti de larin wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Messia l'oruko Rẹ.",
                        "A reti Rẹ titi:",
                        "Olugbala ti wa ni.",
                        "Woli l'o sọ tẹlẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn Ọrun kọrin kan",
                        "Mimọ l'Ọlọrun wa",
                        "Araiye kigbe soke.",
                        "Ẹlẹda pẹlu wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "O t'Ọrun, sọkalẹ wá.",
                        "Lati gb'ẹmi wa la.",
                        "Jẹ k'ifẹ Rẹ gbigbona;",
                        "K'o gbilẹ ninu wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ọlọrun mi, mo bẹ Ọ",
                        "Mo dupẹ lọwọ Rẹ;",
                        "Pelu Joseph, Maria,",
                        "Mo fẹ sin Ọ titi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "329",
            Title = "IFẸ, OGO",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Ifẹ, ogo at'iyin",
                "Fun Ọlọrun l'ibuje ẹran,",
                "K'a ba aw'Angeli kọ",
                "Orin titun fun Un.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi Ọmọ yi ba da 'mije.",
                        "Lati fa ẹlẹsẹ l'okan,",
                        "Lati f'opin s'osi wa ni.",
                        "Nipa riru ẹsẹ wa,",
                        "O mu 'binu Ọrun tutu",
                        "Aiye, nipa ibi Rẹ,",
                        "Yio jẹ alafia.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi a ba ni ibanujẹ,",
                        "Lọdo Rẹ lo tọ ki a wa",
                        "Agbara t'itunu wa",
                        "K'iyọnu, ibẹru",
                        "At'ipọnju jina si wa.",
                        "O tọ k'ijo ayọ yi",
                        "Tẹ ifẹ wa l'Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Nigbat'o ri pe a ṣegbe.",
                        "O fẹ nitori wa,",
                        "O si kú lati gba wa la:",
                        "Jẹ k'a dupẹ lọwọ Rẹ",
                        "Nitori 'fẹ nla Rẹ si wa;",
                        "K'a fẹ Ẹ tọkantọkan",
                        "Lati mu 'nu Rẹ dun.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ki a má ṣe bẹru Ẹṣu",
                        "Jesu t'a bi nitori wa,",
                        "Ti ṣi ilẹkun Ọrun fun wa",
                        "Ọba-Ọrun-apadi",
                        "Le binu si wa b'o ti wu u.",
                        "A o ṣe awọn ẹwọn,",
                        "T'o sọ wa d'ẹru Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "330",
            Title = "ỌṢẸ! AIYA KUN FUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọsẹ! aiya kun fun",
                        "Irora ni a, mo sọkun titi",
                        "Ọsẹ! aiya kun fun",
                        "Irora ni a, mo sọkun titi,",
                        "Lat'ijọ, emi ko ni bẹru",
                        "Oluwa mo ti n'irọrun,",
                        "Ọsẹ! akoko na,",
                        "Ti kọja lọ, ko si ni wa mọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ikú ti tẹle mi,",
                        "Ibanujẹ ti fẹ pa mi ku;",
                        "Ikú ti tẹle mi",
                        "Aiye nsa mi gbogbo nkan d'ofo,",
                        "Mo r'iku o nsi 'sa 'ku mi,",
                        "Ohun Rẹ pe mi mo nsubu,",
                        "Ikú, Ikú buru,",
                        "Li ọjọ yi f'ohun gbogbo sile.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bẹru, ẹlẹsẹ nla",
                        "Ọlọrun wa t'o ti tọju nyin:",
                        "Bẹru, ẹlẹsẹ nla,",
                        "Ọlọrun wa to fẹ r'okan nyin;",
                        "Ẹlẹsẹ gbọ ibinu Rẹ",
                        "T'o ba le gbọ irunu Rẹ,",
                        "Bẹru k'ẹ wa loni",
                        "Iwọ nikan l'oju agbẹsan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwọ ọmọ rere,",
                        "T'o nyọ titi, kun fun ireti",
                        "Iwọ ọmọ rere,",
                        "Emi nikan ko r'alais,",
                        "Mo to fẹ kuro lọdọ nyin;",
                        "Mo ti sọ iwa Mimọ ni",
                        "Tirẹ Ọrun rere",
                        "Ati t'emi Ọrun apadi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Bẹkọ, mo ti ṣina",
                        "T'irekoja ti mo s'igbagbe,",
                        "Bẹkọ, mo ti ṣina;",
                        "T'irekoja mo ti r'Ọlọrun,",
                        "O gbọ mi, O si fa mi mọra,",
                        "L'ẹjẹ Rẹ, mo tun gba iye;",
                        "Jọwọ mo tun fẹ si",
                        "Ikanu mi o yi mi pada.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu Olugbala",
                        "Onjẹ Mimọ, ọkan mi pè Ọ",
                        "Jesu Olugbala;",
                        "Onjẹ Mimọ wa, kun ifẹ mi;",
                        "Lat'oni k'ifẹ Mimọ Rẹ",
                        "K'o ba le m'okan mi gbona",
                        "Jesu Oluwa mi",
                        "Jẹ k'emi ri 'simi ain'opin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "331",
            Title = "A KI Ọ AGBELEBU MIMỌ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "A ki Ọ Agbelebu Mimọ",
                "Fetisi Olufẹ t'o gbadura loni",
                "Dari ẹsẹ ji wa nipa ẹjẹ Jesu",
                "Ẹjẹ na to ṣe Ọ lọsọ.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Alasia Ọba mbọ wà;",
                        "Agbelebu ko n'ẹgan mọ;",
                        "Lori Rẹ ni Jesu ti ku",
                        "K'a ba le jẹ iye tootọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Lori igi Oluwa wa,",
                        "Gbọgbẹ buburu l'iha Rẹ",
                        "O da ẹjẹ pẹlu omi",
                        "T'a ma fi wẹ ẹsẹ wa nu.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A ti mu ọrọ na ṣe tan",
                        "Ti Dafidi ti kọwe Rẹ,",
                        "Fun araiye gbogbo wipe;",
                        "\"Nipa igi, Jesu jọba.\" (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Igi na dara, o l'ẹwa,",
                        "Alasiki nin'awọn igi,",
                        "Ayanfẹ ti Ọlọrun yan",
                        "Ẹbọ Jesu li altari. (bis)",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A! o ṣeun, Agbelebu!",
                        "Itoripe l'ori Rẹ",
                        "Nitoye t'a fi r'araiye",
                        "Ti Jesu Kristi ti yan. (bis)",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Trinitati, ori iye!",
                        "Ki ẹlẹmi ẹda yin Ọ:",
                        "Fun Olufẹ Agbelebu,",
                        "K'O fun u l'aiye ainipekun. (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "332",
            Title = "O FILII ET FILIAE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Alleluia, Alleluia, Alleluia.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹnyin Kristiani ẹ yọ",
                        "Ọba Ọrun Ọba Ogo,",
                        "Jinde n'isa oku loni. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Maria oun Salome wa",
                        "Lati ba fi turari kun",
                        "Ara Jesu, Oluwa wa. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn ọmọ-ẹhin meji,",
                        "Ti Magdalena ba sọrọ,",
                        "Sare lọ sibi iboji. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ṣugbọn Johanu Apostoli",
                        "Sare ya Peteru kọja",
                        "O si tete kọ de 'boji. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Angeli alaso funfun",
                        "Joko lẹ 'boji, o al wi",
                        "F'obinrin pe: Jesu jinde. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Awọn ọmọ-ẹhin pọjọpọ",
                        "Ni yara kan, Jesu si wá",
                        "Wipe: Alafia fun nyin. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Nigbati Apostoli Tomasi",
                        "Gbọ pe Jesu Kristi jinde",
                        "On ko fẹ lati gba a gbọ. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Jesu si wi fun Tomasi pe:",
                        "Wo iha, t'ọwọ, t'ẹsẹ mi,",
                        "Ma si ṣe alaigbagbọ mọ. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Nigbati Apostoli Tomasi",
                        "Ri gbogbo ọgbẹ ti Kristi,",
                        "O wi pe: Iwọ l'Ọlọrun mi. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Alabukun fun li ẹni",
                        "Ti ko ri, ṣugbọn t'o gbagbọ",
                        "Nwọn yio jogun Ọrun rere. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Jẹ k'a yọ lọjọ Mimọ yi,",
                        "K'a si yin Ọlọrun l'ogo,",
                        "K'a si f'ogo at'ọla fun U. Alleluia.",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Jẹ k'a sọpẹ gidigidi",
                        "Fun Jesu t'o ra wa pada",
                        "T'o si ṣikùn Ọrun fun wa. Alleluia.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "333",
            Title = "ṢAWO! JESU AṢEGUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ṣawo! Jesu Aṣegun,",
                        "Olinu rirọ bẹ",
                        "Orẹ tootọ kò si mọ",
                        "Ṣawo Jesu Aṣegun,",
                        "Ẹ ma wa, iṣẹni k'a fi fun U.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "A! Jesu rere,",
                        "T'o jinde l'aiye,",
                        "Ma bori iku ati Ọrun apadi:",
                        "Awa fẹran Rẹ,",
                        "Mu wa l'agbara,",
                        "Lati duro l'ifẹ Rẹ Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Emi ko bẹru iku!",
                        "Oluwa Jesu mi",
                        "O ti lè e jade lọ:",
                        "Emi ko bẹru iku!",
                        "A dupẹ li ọwọ Ọlọrun!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ninu oku l'O jinde;",
                        "Nigbati O jiya O s'atunṣe fun awa.",
                        "Ninu oku l'O jinde",
                        "Irora kò si mọ titi lai.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu gbe Ijọ yi ga;",
                        "Akara Mimọ Rẹ,",
                        "L'onjẹ to bọ ẹmi wa,",
                        "Jesu, gbe Ijọ yi ga!",
                        "K'a jinde pẹlu Rẹ li ogo.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "334",
            Title = "IRI WO NI MO RI?",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iri wo ni mo ri loni yi?",
                        "Jesu l'o re oke Ọrun;",
                        "Aw'Angeli y'awọ sanma ka,",
                        "T'o gba a kuro l'oju enia.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "K'a ba gbogbo Angeli sọkan",
                        "Lati kọrin yin Oluwa",
                        "T'o fi Iṣegun g'oke Ọrun",
                        "Lẹhin t'o ti bori Ẹṣu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O lọ gba èrè Iṣegun Rẹ",
                        "Ati ti iṣẹ lile Rẹ",
                        "Lati ori itẹ ogo Rẹ",
                        "O n'ifẹ ki n tọpasẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo jẹ arole Ọrun rere,",
                        "Alabapin ogo Jesu;",
                        "Iṣegun Rẹ li itẹnumọ",
                        "Ti ogo ati t'ọla mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ṣugbọn k'o to fi aiye sile,",
                        "Ki On si to wọ'nu Ọrun,",
                        "O ti jiya li ọna pupo;",
                        "O kù lori Agbelebu.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ijiya Rẹ l'o de E l'ade na,",
                        "T'ẹnyin ri l'ori Rẹ l'ogo!",
                        "Bi a ba fẹ lọ si Ọrun rere,",
                        "O tọ k'a jọna ijiya.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "335",
            Title = "ẸMI ẸLẸDA SỌKALE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Ẹmi Ẹlẹda sọkalẹ, (bis)",
                "Si ọkan tutu wa",
                "K'O dana, k'o dana ifẹ Mimọ (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "L'ais'Imọ Rẹ Imọ wa l'asan.",
                        "Ko le tọ wa l'ọna Ọrun",
                        "Le okunkun kuro ninu wa, (bis)",
                        "Fi Imọlẹ Mimọ Rẹ mọ wa mọ lọkan.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹmi Ọgbọn kọ wa l'Ọgbọn Mimọ Rẹ",
                        "On nikan le mu wa d'alafia;",
                        "Ewe t'agba lọna Rẹ nrin n'irora",
                        "Fun wọn, fun wọn ko si irora. (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn agbara gbogbo Ọrun apadi,",
                        "T'ohun t'aiye lọ ṣigun pọ si wa,",
                        "K'O gba, K'O gba awọn ọmọ Rẹ la",
                        "K'O gba awọn ọmọ Rẹ la.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "336",
            Title = "A BẸ Ọ ẸMI-ẸLẸDA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "A bẹ Ọ, Ẹmi Ẹlẹda,",
                "Ẹmi Olutunu wa",
                "Jọwọ! mu ẹbun Mimọ Rẹ,",
                "Wa sinu ọkan ti wa (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mu ọgbọn wa, ẹnit'a kọ wa",
                        "L'isẹ wa si Jesu Kristi",
                        "Oluwa, si ẹnikeji wa,",
                        "Ati si ara wa paapaa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bun wa l'oye olotitọ naa",
                        "T'o nmu ni mọ dajudaju,",
                        "Bi igbagbọ wa ti dara to",
                        "Bi ẹsẹ ti n'ibẹru to!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Njẹ, k'imọran Mimọ Rẹ k'o wa",
                        "J'amọna wa lohunkohun",
                        "Ati ninu danwo Ẹṣu",
                        "Ati l'akoko irora.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Fi agbara fun 'wa otosi",
                        "Lati jẹwọ igbagbọ wa,",
                        "Nibikibi, nigbakugba,",
                        "Bi ajagun rere Kristi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹmi Mimọ, Imọlẹ ti wa",
                        "K'o mu ifọkansin, Imọ wa,",
                        "Ibẹru ati ẹbun gbogbo,",
                        "Nipa Jesu Olugbala!",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "337",
            Title = "F'OHUN KAN KỌRIN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "F'ohun kan kọrin, l'ọjọ yi.",
                        "Si ara Ọlogo pupo",
                        "Ati si ẹjẹ iyebiye",
                        "Ti Jesu ti ta sile.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "K'a tẹriba fun,",
                        "Oluwa Jesu Ninu Sakramenti Mimọ",
                        "Ki ẹbọ Kristi, dipo t'igbani,",
                        "Ki igbagbọ ran ẹni lọwọ (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi Jesu, ẹni t'a fi fun wa,",
                        "T'a si bi ninu Wundia,",
                        "Ti waasu ihin rere fun ni",
                        "O fẹ Ṣiṣe nla k'o to lọ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Li onjẹ alẹ ti ikẹhin",
                        "T'o jẹ pẹlu Apostoli,",
                        "Lẹhin t'o ti ṣe gẹgẹ b'ofin",
                        "O f'ara Rẹ paapaa fun wọn.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ọrọ t'o ti d'ennia pipe,",
                        "Nipa ọrọ sọ ara Rẹ",
                        "Di onjẹ, oti si d'ẹjẹ Rẹ:",
                        "Otitọ yi ti dara to.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Agbara, ibukun, iyayo",
                        "Igbala, ogo on ọwọ,",
                        "K'a fi fun Baba ati Ọmọ",
                        "Ati Ẹmi Mimọ pẹlu.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "338",
            Title = "SI ỌKAN JESU",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Si ọkan Jesu",
                        "T'o kun fun ifẹni si wa,",
                        "K'awa f'ohun kan kọrin,",
                        "Iyin ati ogo.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹnyin orile-ede",
                        "Titi d'opin aiye,",
                        "Sin ọkan Rẹ Mimọ",
                        "Jesu tinu tifẹtifẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu ọkan Rẹ ti da!",
                        "O fẹ wa lafẹtan!",
                        "Ẹnu wa ko le s'ọrọ",
                        "B'ọkan wa ti fẹ Ẹ to!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹsẹ wa pọ, tootọ ni;",
                        "A si gbagbe Rẹ ri;",
                        "Ṣugbọn jẹ k'anu Rẹ nla",
                        "K'o mu wa pada wa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "B'Iwọ ti ni irẹlẹ,",
                        "Ti ọkan Rẹ si mọ,",
                        "Bẹ gẹgẹ ni ki awa,",
                        "K'a le farawe Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iba jẹ pe a ti ni",
                        "Iye awọn ẹyẹ,",
                        "A ba fo lọ si Ọrun",
                        "Lati f'ifẹ wa han.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Nigbat'Ijọ wa fẹ tan",
                        "Ti iku fẹrẹ de,",
                        "Ọkan Olufẹ Jesu,",
                        "Ninu Rẹ ni k'a wo!",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "339",
            Title = "AWỌN ENIA KO MI SILE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "K'a to ọkan na t'o dara lọ",
                "Jẹ k'a ṣapamọ ninu rẹ",
                "On nikan jẹ ọrẹ wa tootọ",
                "On nikan l'o gba ifẹ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Awọn enia kọ mi sile",
                        "Afi l'Ọrun ifẹ ko si,",
                        "Lasan ni ti mo fi wa l'aiye,",
                        "Ti mo si pa ara mi mọ",
                        "Ọkan mi ti kun fun irora.",
                        "Ọmọ mi wa pin ewu mi!",
                        "Ati lati fi ifẹ Rẹ han,",
                        "Sare wa sinu ọkan mi (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi mo ti fẹran enia to:",
                        "Lati gbe 'bi t'Ọsan t'oru",
                        "Lati sọ wọn, lati dari wọn.",
                        "Ifẹ l'o ti da mi duro",
                        "Bẹni, eniyan kọ mi sile.",
                        "Nwọn sa fun mi bi fun ọta.",
                        "Ọmọ mi, wo irora mi nla,",
                        "Sare wa sinu ọkan mi (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọmọ t'o ti sa fun Baba rẹ",
                        "Ko ni ri ọrẹ kan l'aiye",
                        "Tabi ọkan t'o fẹran on ju.",
                        "Ọkan t'o jiya t'o si ku,",
                        "Lati gba ara on emi la,",
                        "On o ha le duro bẹ titi!",
                        "Sare wa sinu ọkan mi (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ma ṣe tẹle awọn buru",
                        "Ọmọ mi, duro lọdọ mi;",
                        "Wa ba mi ṣe ọrẹ titi lai;",
                        "F'ifẹ Rẹ san ifẹ nla mi,",
                        "Ọkan mi li orisun iye;",
                        "Ọmọ mi, ma ṣe da mi duro;",
                        "Sare wa sinu ọkan mi (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "340",
            Title = "PẸLU ẸDUN AT'OMIJE (STABAT MATER)",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Li omije l'ibanujẹ",
                        "Iya duro l'ẹsẹ igi,",
                        "Nibi t'Ọmọ rẹ njiya.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Lẹhin imi-ẹdun t'o pọ.",
                        "Lẹhin ainitunu rara,",
                        "Ida oro gun u l'okan.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Olubukun Iya Jesu,",
                        "Ti ni inu t'o bajẹ to,",
                        "Fun oniruru iya!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ko s'isimi, ko s'alafin,",
                        "Enia wo ki yio sọkun",
                        "T'o nri Ọmọ l'irora!",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Enia wo ki yio sọkun",
                        "Ti o ba ri Iya Kristi",
                        "Li ọwọ ipọnju yi?",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Tabi tani ki yio ṣaanu",
                        "Fun Iya t'o dara to bẹẹ,",
                        "To si ba Ọmọ npin iya?",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Ori pe Jesu nwahala,",
                        "Nkerora li ọna gbogbo,",
                        "Fun ẹsẹ ara ti Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Nwo Ọmọ Rẹ Olufẹ",
                        "T'o ndaku lọ l'ibanujẹ",
                        "To ku tan b'ẹni-egbe!",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "A! Iya mi, ori ifẹ.",
                        "Mba ti fẹ ba Ọ kannu pọ",
                        "Mba ti fẹ da omije!",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Mba ti fẹ ki inu mi kun,",
                        "Fun ifẹ Mimọ s'Ọlọrun.",
                        "Ki nle wu Ọ nidajọ.",
                    }
                },
                new Verse
                {
                    Number = "11",
                    Lines = new List<string>
                    {
                        "Iya Mimọ, emi mbẹ Ọ",
                        "Fun ọgbẹ ti Jesu Kristi",
                        "Li inu mi titi lọ.",
                    }
                },
                new Verse
                {
                    Number = "12",
                    Lines = new List<string>
                    {
                        "Pin fun mi ninu ijiya",
                        "Ti Ọmọ Rẹ Oluwa wa,",
                        "Ẹni t'o ra wa pada.",
                    }
                },
                new Verse
                {
                    Number = "13",
                    Lines = new List<string>
                    {
                        "Mu ki mba kaanu pọ",
                        "Ki nsajo ijiya Kristi",
                        "Ni'jọ aiye mi gbogbo!",
                    }
                },
                new Verse
                {
                    Number = "14",
                    Lines = new List<string>
                    {
                        "L'ẹsẹ Agbelebu Jesu,",
                        "Mo fẹ lati ba Ọ ṣe ẹgbẹ.",
                        "Lati ba Ọ kerora.",
                    }
                },
                new Verse
                {
                    Number = "15",
                    Lines = new List<string>
                    {
                        "Wundia awọn silabawon",
                        "Ṣe suru, sa gbọ t'emi,",
                        "Jẹ k'intu l'inu tan!",
                    }
                },
                new Verse
                {
                    Number = "16",
                    Lines = new List<string>
                    {
                        "Tun jẹ ki nrant'iku Jesu,",
                        "Ati ikerora gbogbo.",
                        "Lati jere t'ẹjẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "17",
                    Lines = new List<string>
                    {
                        "Ma jẹ k'ina jo mi l'ina",
                        "Wundia, ṣe alagbawi mi.",
                        "L'jọ idajọ ti mbọ!",
                    }
                },
                new Verse
                {
                    Number = "18",
                    Lines = new List<string>
                    {
                        "Nigbati ara mi ba ku,",
                        "Mu ki ọkan mi k'o wa jẹ",
                        "Ogo ti Ọrun rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "341",
            Title = "IYA MIMỌ ALAIL'ABAWỌN ẸṢE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya Mimọ alail'abawọn ẹsẹ,",
                        "B'o ba ri wa l'ẹsẹ Rẹ l'Ọjọ yi.",
                        "O jẹ nitori ọkan wa fẹran Rẹ.",
                        "Ati pe ọkan Rẹ pe wa s'ihin.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Tẹ ọwọ Rẹ lori ọmọ ayanfẹ Rẹ",
                        "Dabobo wa ninu ewu t'aiye;",
                        "Labẹ 'tọju Rẹ k'a le duro ṣinṣin,",
                        "Ninu igbagbọ wa titi d'iku wa (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Aiye ko mọ bawo ni Onigbagbọ",
                        "Ti jagun ri lati p'otitọ mọ,",
                        "Lati jere orukọ Katoliki,",
                        "Gẹgẹ bi wọn a fẹ jagun pẹlu.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ki oju ma wa nitori Jesu",
                        "Ṣugbọn k'a ri ami igbala wa",
                        "Ninu 'le wa gẹgẹ bi l'ori ọkan wa,",
                        "K'o fun wa l'agbara ninu 'danwo.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onigbagbọ Jesu l'o jẹ Ọga wa,",
                        "K'a f'okan wa fun Olugbala wa;",
                        "K'a k'ẹkọ Rẹ fun awọn ti ko mọ Un",
                        "K'a bukun fun Orukọ Rẹ Mimọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iya Jesu, Iwọ ni ireti wa",
                        "Ran wa lọwọ k'a ma ṣeṣe l'asan;",
                        "Iya ti wa fun ni iforiti,",
                        "K'a le de ọdọ Rẹ l'Ọrun rere. Amin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "342",
            Title = "BABA ALAANU",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹlẹda wa, wo! l'ẹsẹ Rẹ l'a ti de,",
                        "Ligbekele aanu Rẹ t'o tobi.",
                        "Gbogbo wa pọ tinutinu l'a kigbe:",
                        "Ṣaanu fun wa otosi ẹlẹsẹ!",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Baba alaanu, Ọlọrun wa!",
                        "Awa ọmọ ẹlẹbi, A mbẹbẹ fun aanu. (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ran wa lọwọ nitori Jesu Kristi",
                        "Eni t'o ta ẹjẹ mimọ fun wa.",
                        "Eṣu, aiye, ẹṣẹ yio ha bori wa?",
                        "Ṣaanu fun wa, otoṣi ẹlẹṣẹ!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ailera wa ti fa wa sinu ẹṣẹ;",
                        "Ṣugbon awa kaanu gidigidi;",
                        "Ti wa lẹhin. Ọlọrun alagbara,",
                        "Ṣaanu fun wa, otoṣi ẹlẹsẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "343",
            Title = "IRIN TEMI DARA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ipin t'emi dara ju!",
                        "Jesu wa l'ọkan mi.",
                        "Emi ko bẹru nkan ni",
                        "Alafia mi nla!",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ifẹ ọpẹ at'ogo,",
                        "Mo fi fun Oluwa",
                        "Ki Jesu nikan jọba",
                        "Lori ifẹ t'emi. (2)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Tal'o le sọ ire mi?",
                        "Jesu wa l'ọkan mi;",
                        "On nikan l'Oluwa mi",
                        "Ati itunu mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ki Jesu nikan jọba",
                        "Aiye ẹlẹtan yi;",
                        "Sisin Jesu Ọlọrun",
                        "Ni gbogbo ogo mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Aiye mo kọ Ọ sile",
                        "Ayọ rẹ jẹ asan;",
                        "Mo l'ohun ti ko ṣe nu",
                        "Jesu wa l'ọkan mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu nikan mo fẹ ni;",
                        "On naa jẹ Baba mi.",
                        "On naa l'emi gbẹkẹle",
                        "Loni ati lailai.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "344",
            Title = "NIFORIBALE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Adoremus in aeternum",
                "Sanctissimum sacramentum. (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Niforibalẹ k'a f'ohun kan,",
                        "Kọrin si Jesu Oluwa",
                        "T'o sọkalẹ lati Ọrun wa,",
                        "Li altari nitori wa. (bis)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Adoremus in aeternum",
                        "Sanctissimum sacramentum. (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Mo gbagbọ pe ko si akara",
                        "Nihin, ṣugbọn Ọlọrun ni",
                        "Ẹlẹda Ọrun on aiye ni",
                        "Oluwa ni, Baba wa ni. (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ninu Sakramenti Mimọ yi",
                        "Jesu fẹ di onjẹ fun wa;",
                        "Awa mbẹ Ọ, Jesu Oluwa;",
                        "Bu onjẹ yi fun wa pọ. (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Gba adura irẹlẹ tiwa,",
                        "Ọlọrun, Iwọ t'o fẹ wa;",
                        "Baba Mimọ, K'O bukun fun wa",
                        "Pa ọkan wa mọ l'ifẹ Rẹ. (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "345",
            Title = "ANGELI KAN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Angeli kan sọ f'ọkan mi n'Ijọ kan",
                        "Ibẹrẹpe Iwọ mọ Ọrun mi;",
                        "Ibi ti a mu wa jẹ alafia nla",
                        "Ti a ko mọ iru rẹ l'aiye yi!",
                        "Ọkan mi da angeli l'ohun wipe:",
                        "Otitọ ni, Iwọ ri Ọlọrun;",
                        "Ṣugbọn Iwọ ko mọ ifẹ Ọlọrun",
                        "T'o nfi ara sin l'or'altari. (bis)",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Awo l'Ọmọ Olugbala Kristi",
                        "K'a jumo yin iṣẹun Ọlọrun.",
                        "Mo ni Ọrun t'emi ni Ukaristi,",
                        "Ipin ti wa o dara ju. (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Angeli naa si da mi l'ohun wipe:",
                        "Iwọ ha mọ ayọ nla t'emi ni",
                        "Lati f'ojuba Ọlọrun l'ogo Rẹ?",
                        "Lojojumo Ọrun di dara",
                        "Mo si wipe: O mọ kini Hostia",
                        "Iwọ t'ẹsẹ ko ba ọkan Rẹ jẹ",
                        "Iwọ ha ti sọkun l'ẹsẹ Oluwa",
                        "T'o nfi ara rubọ fun wa? (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Angeli naa si tun fẹ sọrọ miran",
                        "O wi fun mi pe: Iwọ mọ onjẹ",
                        "Ti emi njẹ? F'ifẹ, si sin Ọlọrun",
                        "Ni onjẹ mi, t'o mu mi y'ayọ nla.",
                        "Mo dahun, wipe: Iwọ angeli mi,",
                        "Tooto, Iwọ wa pẹlu Ọlọrun;",
                        "Ṣugbọn Hostia ti mo foribalẹ fun",
                        "Ti mo si jẹ, Iwọ ti tọwo? (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Angeli, jẹ k'a jumo yin Ọlọrun",
                        "T'o dara tobẹẹ f'awa mejeji,",
                        "Ọrun Tirẹ; Hostia Mimọ t'emi.",
                        "Iwọ l'ipin t'o dara bi tiwa?",
                        "Mo naga si Ọrun, ile Baba mi",
                        "Li aiye yi ayọ mi l'altari;",
                        "Alafia rẹ, mo nfi suru reti;",
                        "Ṣugbọn t'emi o dara ju. (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "346",
            Title = "JESU KRISTI, IWỌ T'O ṢE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Jesu Kristi Iwọ t'o ṣe iṣẹ",
                "Iyanu akọṣe Rẹ",
                "Nibi iyawo ni Kana",
                "T'o sọ igbeyawo di Mimọ.",
                "Bukun fun awọn enia meji yi",
                "Ti a sọpọ ni igbeyawo",
                "Ki wọn le gbe pọ l'alafia",
                "Ki wọn ṣe iṣẹ igbala wọn.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Bi Oluwa Jesu ti wa",
                        "Pelu Eklesia Rẹ titi lai,",
                        "Bẹ lo tọ ki ọkọ t'aya",
                        "Gbe pọ titi iku yio fi ya wọn.",
                        "O tọ ki wọn gbe pọ n'ifẹ",
                        "L'irẹpọ on laiya ara wọn.",
                        "Ki wọn ran ara wọn lọwọ,",
                        "Ki awọn mejeji si huwa rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "O tọ ki wọn tọ ọmọ wọn",
                        "L'iwa rere on bi Kristiani,",
                        "Ki wọn gb'ara wọn n'iyanju",
                        "Lati sin Ọlọrun b'o ti yẹ.",
                        "B'Eklesia ti teriba",
                        "Fun Oluwa Jesu, Ọkọ Rẹ,",
                        "Bẹ gẹgẹ lo tọ ki aya",
                        "Teriba fun ọkọ Rẹ Olufẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "O tọ ki ọkọ f'ifẹ lo",
                        "Aṣẹ t'on ni l'ori aya Rẹ.",
                        "Paulu Mimọ sa wi fun un pe",
                        "\"Iwọ ọkọ ma fẹ aya Rẹ\".",
                        "Fẹ ẹ bi Jesu Kristi ti fẹ",
                        "Eklesia Rẹ ti On ku fun u.",
                        "Ma ṣe aya Rẹ l'ara,",
                        "Bẹni ma ṣe huwa buburu si i. (bis)",
                        "O tọ k'ẹyin fi suru gba",
                        "Iwa abuku ti ara nyin.",
                        "Ki ẹyin si pa ipinnu mọ",
                        "Ti ẹ ti leri fun ara nyin.",
                        "B'Eklesia ti l'Ọkọ kan,",
                        "T'o jẹ Kristi, ti Kristi si ni.",
                        "Aya kan t'o jẹ Eklesia,",
                        "Bẹ lo tọ ki ọkọ li aya kan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ki Ọlọrun wa pẹlu nyin",
                        "K'o ma si ya nyin sọtọ lailai,",
                        "Ki ẹ wa ni irẹpọ pipe.",
                        "Ki ẹ si ma bi si i, ki ẹ si ma rẹ si i.",
                        "Ki Ọlọrun bukun fun yin",
                        "Titi de iran ẹkẹrin;",
                        "Ki ẹ si le ni iye ainipẹkun. (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "347",
            Title = "ỌKAN MI YIN ỌLỌRUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ọkan mi yin Ọlọrun.",
                        "O yin Jesu Oluwa;",
                        "Jesu t'ẹsẹ wa nbukun (bis)",
                        "Lat'ijọ t'o ku fun wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A bẹ Jesu l'idanwo",
                        "K'o feti s'adura wa:",
                        "L'akoko t'a kepe Ọ (bis)",
                        "A ṣegbe, Jesu gba wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Mo bẹ Ọ Jesu, fun mi,",
                        "Mo bẹ Ọ, fun Ẹgbẹ mi",
                        "Mo bẹ Ọ fun ọta mi (bis)",
                        "Mo bẹ Ọ, dariji mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ni ọjọ t'igba wa yio tan,",
                        "T'a maa pe wa s'idajọ:",
                        "Gbana l'a nreti ifẹ (bis)",
                        "Ṣe suru fun ẹlẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu, f'ona han fun wa,",
                        "Lati jogun ifẹ Rẹ;",
                        "O duro, O si npe wa (bis)",
                        "Ka 'bọ sinu ayọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ogo l'a fi fun Baba",
                        "A si maa fi fun Ọmọ",
                        "Ati fun Ẹmi Mimọ.",
                        "Aiye ainipẹkun. Amin.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "348",
            Title = "JESU IWỌ BABA MI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu, Iwọ Baba mi,",
                        "Iwọ ti n tọju mi,",
                        "Iwọ ni t'o mu mi lọ",
                        "Ninu ọna rere.",
                        "Duet: Jesu, Iwọ Baba mi;",
                        "Emi jẹ ọmọ Rẹ",
                        "Iwọ n tọju mi l'aiye;",
                        "Iwọ ran mi lọwọ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Jesu Iwọ Baba mi.",
                        "Emi jẹ ọmọ Rẹ",
                        "Iwọ n tọju mi l'aiye",
                        "Iwọ ran mi lọwọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jesu, Iwọ Baba mi",
                        "Iwọ ti n ṣaanu mi,",
                        "Iwọ gbọ adura mi.",
                        "Lati ṣipẹ fun mi.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Jesu, Iwọ Baba mi.",
                        "Iwọ dariji mi,",
                        "Iwọ ti ri ẹsẹ mi.",
                        "Iwọ ti ṣaanu mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Jesu Iwọ Baba mi",
                        "Emi si fẹran Rẹ,",
                        "Ninu ọkan Rẹ l'aiye",
                        "Ni mo fẹ gbe titi.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "349",
            Title = "AVE JESU",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ave Jesu iranti Rẹ dun pupọ;",
                        "Ave Jesu Ọlorisun ayọ",
                        "Ṣugbọn adun t'o rekọja gbogbo lọ,",
                        "Li iwa Tirẹ paapaa li ọkan wa.",
                        "Ave Jesu! (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ave Jesu! ẹnu tiwa ko le sọ,",
                        "Ani eti wa ko si le gbọ,",
                        "Tabi ọkan enia ko ronu",
                        "Nkan t'o da bi Jesu Ọmọ Ọlọrun,",
                        "Ave Jesu! (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ave Jesu! Ireti apiwada,",
                        "O ti ṣeun to fun abẹbẹ Rẹ!",
                        "O ti dara to fun awọn iwa Rẹ!",
                        "O ju bẹ lọ fun awari Rẹ paapaa!",
                        "Ave Jesu! (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ave Jesu – Oluwa ti ọkan wa.",
                        "Ti yio si jẹ ẹsan wa t'o tobi",
                        "Iṣogo wa, k'a ṣe ninu Rẹ nikan",
                        "Nisisiyi ati nin'aiyeraiye.",
                        "Ave Jesu! (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "350",
            Title = "JESU L'ORI AGBELEBU",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Jesu l'ori Agbelebu",
                        "Ti jẹ Olurapada",
                        "Ẹjẹ Mimọ t'o ta sile,",
                        "L'o fi wẹ ẹsẹ wa nu.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "A! Ẹgbẹ mi ẹ wa sọpẹ",
                        "Ti Jesu k'a ma duro",
                        "A ti ṣegbe, O gba wa la,",
                        "Ẹ wo b'o ti fẹ wa to (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Lati jere igbala wa,",
                        "K'awa gb'okanle Jesu,",
                        "K'a mu oju kuro l'aiye",
                        "Ti o kun fun idanwo.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Lati ri Jesu li Ọrun",
                        "O tọ k'a rin lọna Rẹ,",
                        "K'a pa awọn ofin Rẹ mọ",
                        "Fun ewu ni k'a si sa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Kristi ṣaanu fun ẹlẹsẹ,",
                        "Ki keferi wa mọ Ọ!",
                        "Ki wọn kuro lọwọ ẹtan",
                        "Lati jẹwọ ẹkọ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "351",
            Title = "K'A DIDE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "K'a dide, k'a tun hamọra!",
                "Ohun Ọlọrun pe wa s'ija;",
                "Ẹ sa wa, wa wo b'o ti dara.",
                "Èrè t'a fi fun aṣegun!",
                "B'o ti dara to b'o ti lọla to (bis)",
                "Èrè t'a fi fun aṣegun! (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iṣẹ wa gbogbo li aiye yi",
                        "Jẹ ija t'o le, t'o si pọ;",
                        "Ẹni t'o jẹ olotitọ,",
                        "L'a ta li ọrẹ sọsọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ifẹ 'ra t'o burujulo,",
                        "Fẹ lati tan oye wa jẹ,",
                        "Ṣugbọn okudun l'afẹ Rẹ",
                        "Ikú si tẹle itọnwo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aiye f'ogo asan Rẹ han wa",
                        "Lati sọ wa di buburu;",
                        "K'a gan ohun itanjẹ yi,",
                        "K'a le ri ohun t'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹṣu, ọta wa, t'o nrin kiri,",
                        "Nwa ẹni ti o le pa jẹ;",
                        "Ṣugbọn Onigbagbọ tootọ,",
                        "Ko bẹru ibinu ọta yi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awa t'o jẹ ologun Jesu",
                        "K'a gb'Agbelebu bi aṣẹ;",
                        "Ewo l'ewu t'a le foiya",
                        "L'abẹ abo Alagbara yi?",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ajagun Kristi jẹ ogboiya",
                        "Jẹ ogboiya titi iku",
                        "Ma ṣe bẹru 'wọ de Ọrun",
                        "Wo Ọrun rere, wo ilu Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "352",
            Title = "IṢE WA L'AIYE YI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iṣe wa l'aiye yi ni",
                        "Lati gb'ẹmi wa la;",
                        "Eyi ni opin wa,",
                        "Eyi ni kiki iṣẹ wa.",
                        "Eyi ni opin wa,",
                        "Eyi ni kiki iṣẹ wa,",
                        "Alafia, Alafia, Alafia wa lati w'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹmi wa alaiku",
                        "L'a ti da f'Ọlọrun,",
                        "Aiye ko to fun on (bis)",
                        "Gbogbo ogo t'aiye d'asan",
                        "Alafia, Alafia, Alafia wa lati w'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Bi a padanu Jesu,",
                        "A padanu gbogbo",
                        "Irọrun isimi (bis)",
                        "Fun igbala ti ko ni ipẹkun",
                        "Alafia, Alafia, Alafia wa lati w'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹnyin awon ki ẹ gba",
                        "Fun 'ra nyin aiye yi",
                        "Nitori 'iṣura Rẹ (bis)",
                        "Ẹyin ṣ'aiṣotọ s'Ọlọrun",
                        "Alafia, Alafia, Alafia wa lati w'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awa nwa ore-ọfẹ",
                        "Ẹbun kan ṣoṣo ni",
                        "Gbogbo eyi t'o ku",
                        "Dabi ojiji t'o n kọja",
                        "Alafia, Alafia, Alafia wa lati w'Ọrun rere.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Awa nwa iye tootọ",
                        "Ogo t'Ọrun rere",
                        "Ti o wa titi lai;",
                        "Ẹnyin ko ha fẹ pẹlu?",
                        "Ẹ wa. Ẹ wa tẹle wa a o si ode (bis) Ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "353",
            Title = "LASAN L'AIYE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Lasan l'aiye fi ogo at'afẹ Rẹ,",
                        "Fa mi mọra, ki nle jẹ ọmọ Rẹ,",
                        "Ohun wọnyi ko to lati bori mi.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Kil'a foiya, kil'a foiya (bis)",
                        "Wo! Jesu l'inu mi!",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ẹ wa ẹyin ọmọ irera t'aiye,",
                        "K'e si binu lati pa mi l'aiye;",
                        "Bi ẹnyin ba sọkan lati ba mi ja.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ Ẹṣu ọta nla mi k'o binu",
                        "Ki ẹgbẹ iṣẹ gbogbo ba o dimo;",
                        "Ọwọ Rẹ ko to lati ba mi l'ẹru.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ikú ti o l'oro ju ko l'agbara",
                        "Lati mu mi kọ Jesu mi sile;",
                        "Ma pa ẹkọ Rẹ mọ titi d'iku mi.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ki aiye on gbogbo Ọrun apadi,",
                        "Jumọ ṣiṣẹ lati dẹruba mi;",
                        "Bi mo ba ri pe aiye ṣubu lu mi.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Jesu Kristi, to o jẹ ireti mi,",
                        "Mo gbagbọ pe 'wọ le ṣe nkan gbogbo,",
                        "Njẹ; fun ọkan mi l'igbekele lile.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "354",
            Title = "ASAN NI NKAN GBOGBO",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Asan ni nkan gbogbo",
                        "Eke ati ailera,",
                        "Ni gbogbo ohun wọnyi,",
                        "T'aiye gbẹkẹle l'oju wa,",
                        "Ohun ọsọ wọnyi,",
                        "T'o jọ dara,",
                        "Ohun ini yi,",
                        "L'o tan ni jẹ.",
                        "Nwọn fo wa l'oju,",
                        "Ṣugbọn nkan n kọja lọ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Lasan ni ajaiye.",
                        "Lati jẹ alafia.",
                        "Nfi ara fẹ fun afẹ",
                        "T'aiye ẹlẹtan yi fihan;",
                        "B'o ti nwa afẹ to,",
                        "T'o wu 'ra Rẹ,",
                        "Bẹni inu Rẹ,",
                        "Yio bajẹ to;",
                        "Alafia nsa",
                        "Niwọn bi a ti n lepa Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Kini ohun ini,",
                        "Owo ati iṣura,",
                        "Ti a nkojo l'ọpọ da",
                        "Fun ẹni t'o ni lati ku?",
                        "B'on nikan ba jọba",
                        "Gbogbo aiye",
                        "Nkan gbogbo d'opin fun u",
                        "L'Ọjọ iku Rẹ",
                        "L'Ọjọ iku Rẹ",
                        "Posi nikan ni ini Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Kini gbogbo ọla",
                        "Ati orukọ nla da?",
                        "Kil'iro ati ifẹ",
                        "Enia t'o ngberaga da?",
                        "Ohun asan ni wọn",
                        "Ojiji nikan",
                        "Ojiji tootọ",
                        "Ati eke",
                        "Niwọn t'o d'asan",
                        "Lẹhin ti wọn tan wa jẹ tan.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Mo ti ri enia",
                        "T'o n d'ẹsẹ si Ọlọrun",
                        "To si ngbe ara Rẹ ga",
                        "Ju bi igi tutu nla lọ:",
                        "A si n teriba fun",
                        "Agbara Rẹ",
                        "A si n'ibẹru",
                        "Orukọ Rẹ;",
                        "Ṣugbọn kiyesi!",
                        "Mo nwa a lasan, on ko si mọ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ikú, l'ibinu Rẹ.",
                        "Yio lu ẹnikẹni pa",
                        "On ko da ẹnikan si,",
                        "B'o ti wu ki ipo Rẹ ri",
                        "Ibase Ọba ni.",
                        "Ọmọ-ọdọ, tabi talaka",
                        "Tabi ọlọrọ:",
                        "Nwọn nilati ku",
                        "Iboji ti duro de wọn.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "B'a ti n ṣ'otọṣi to!",
                        "A gbagbọ pe a le ri",
                        "Alafia ọkan wa.",
                        "L'aiye yi t'o kun fun osi",
                        "Ọlọrun nikan ni",
                        "Aiyeraiye",
                        "Alaiku, pipe.",
                        "Alaiku, pipe.",
                        "At'Olufẹ",
                        "Pelu ipa Rẹ,",
                        "Ẹ jẹ k'a ṣe Tirẹ nikan.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "355",
            Title = "L'AKOKO TIKU DE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "L'akoko t'iku de.",
                "Ni nkan gbogbo yio d'opin:",
                "Nigbana Ọlọrun yio dajọ wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Dajudaju a o si ku,",
                        "A o fi aiye yi sile",
                        "A ti pinnu Rẹ t'ẹlẹ bẹ;",
                        "O tọ k'a mu aṣẹ naa ṣe.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi itanna t'o rẹ l'ale,",
                        "Bẹẹni opin enia ri",
                        "Nijọkan iku t'o l'ẹru",
                        "Yio f'opin s'ọjọ aiye wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹlẹsẹ, wa sunmọ 'boji",
                        "Rẹ igberaga Rẹ sile;",
                        "Nibo l'ohunkohun t'a n fẹ",
                        "Di ohun asan nikẹhin.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Ẹyin, ọmọ igberaga,",
                        "Kini ẹwa yio da fun nyin?",
                        "Oju nyin t'o pawo rẹ da,",
                        "Yio sọ nyin d'ohun irira.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ẹyin t'o n fẹ afẹ aiye,",
                        "T'o si fetisi ifẹ nyin",
                        "B'ayida naa ti l'ẹru to.",
                        "T'iku yio ṣe fun gbogbo nyin.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Bi a ba pe nyin s'idajọ,",
                        "Tal'o ti mura ninu nyin!",
                        "Ipin ti ọpọ ninu nyin",
                        "Yio jẹ iku ainipẹkun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "356",
            Title = "AIYE RERE FẸ DE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Aiye rere fẹ de",
                        "Ọrọ wọnyi ti dara",
                        "O ti ni isoji to",
                        "Fun itara eni.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Mura mura aiye rere fẹ de (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Aiye rere fẹ de!",
                        "Mo kọ irera asan,",
                        "Ẹṣu on eke sile",
                        "Mo gbe Agbelebu!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aiye rere fẹ de!",
                        "Atẹle Jesu l'emi,",
                        "Mo jẹwọ igbagbọ Rẹ",
                        "L'iye ati l'iku!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Aiye rere fẹ de!",
                        "Nigbati mo kerora",
                        "Bi inu mi fẹ bajẹ",
                        "Mo kigbe pe Jesu!",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Aiye rere fẹ de!",
                        "Nibi ire ain'opin",
                        "A! bi a ti simi to",
                        "Imi ẹdun ko si!",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "357",
            Title = "ỌDUN MARIA TI DE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Ọdun Maria ti de,",
                "K'a ma ṣa itanna;",
                "Ọkan wa l'otọ mura,",
                "Lati yin Iya wa.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "L'ori enia Mimọ",
                        "Maria ti duro.",
                        "Iwa Tirẹ da ṣaka.",
                        "Ọkan Rẹ ti tunu.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ti Jesu Maria mbẹ",
                        "On gbadura fun wa;",
                        "O si bẹ Ọmọ Rẹ",
                        "K'o ṣe suru fun wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ọmọ alai l'obi",
                        "Ikaanu Rẹ kan mi;",
                        "L'aiye yi l'Iya Rẹ ku",
                        "Maria ropo Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Lat'Ọrun Maria",
                        "L'o ṣ'apẹrẹ fun wa;",
                        "Irẹlẹ ọkan Rẹ",
                        "L'akoko yi n kọ wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Aanu ṣe Maria",
                        "B'ewu de laarin wa;",
                        "O si ma bẹ Ọmọ Rẹ",
                        "K'o ba yi wa l'okan.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "L'ọdo Jesu l'Ọrun",
                        "K'a de l'alafia",
                        "L'arin Maria, Josefu,",
                        "K'a gbe titi lailai.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "358",
            Title = "FI OGO FUN MARIA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Fi ogo fun Maria,",
                        "Olori Angeli;",
                        "O fẹ ọmọde t'o da",
                        "T'o si ni inu Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Gbadura wa Maria",
                        "Tẹwọgba ifẹ wa!",
                        "Iwọ li Iya rere (bis)",
                        "Ti Jesu fi fun wa.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Orukọ Rẹ ti ga to",
                        "Nibikibi l'aiye!",
                        "Ọrun rere bọwọ fun U,",
                        "Ẹṣu onibẹru!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awa fẹ gba lọwọ oun",
                        "Ẹbun Iyebiye:",
                        "O daju pe Ọlọrun",
                        "Ko le du on ni nkan.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Awa, t'a tu de nihin",
                        "L'ẹsẹ altari on",
                        "Awa, tinu wa, pinnu",
                        "Lati maa fẹ On lai.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iwa Mimọ Maria",
                        "K'a tẹle l'agbara",
                        "Bi apere alãye",
                        "T'Ọlọrun ti fun wa.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A! Iya alagbara",
                        "Jọ yé ran mi lọwọ!",
                        "Pa wa mọ titi aiye,",
                        "K'a le yin Ọ l'Ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "359",
            Title = "MO FẸ GBA IFẸ RẸ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Mo bẹ Ọ nigbakugba",
                        "Pelu igbẹkẹle",
                        "Wundia ireti mi!",
                        "Mo fẹ gba ifẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Mo fẹ (bis) gba ifẹ Rẹ (bis)",
                        "Mo fẹ gba ifẹ Rẹ (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Jọwọ, gba adura mi",
                        "Lati Ọrun rere",
                        "Iya mi daradara",
                        "Mo fẹ gba ifẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awọn ọta ba mi ja",
                        "Lojojumo l'aiye,",
                        "Ran mi lọwọ, Maria.",
                        "Mo fẹ gba ifẹ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Feti si ẹbẹ t'emi",
                        "Wa gba mi, Maria",
                        "Fun Ọ ni mo tun wipe:",
                        "Mo fẹ gba ifẹ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "360",
            Title = "O MARIA, IYA T'EMI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ave! Ave ogo Ọrun",
                        "Ayaba ti Angeli;",
                        "Iya ti wa alagbara,",
                        "Aṣegun ẹlẹgbara.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "O Maria, Iya t'emi,",
                        "Iwọ ni igbẹkẹle mi",
                        "Ran mi lọwọ f'ona han mi",
                        "S'ile Baba mi l'Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Awọn ọmọ Rẹ olotọ",
                        "Lọdo Rẹ jẹ isimi",
                        "Orukọ Rẹ nikan ṣoṣo",
                        "F'itara si ọkan wọn.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ ni, Maria Mimọ",
                        "Igbala, ogo Israeli",
                        "Iwọ ti nwo wa lat'Ọrun",
                        "Nigbati ti a wa l'ẹsẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Nibigbogbo orukọ Rẹ",
                        "Ọmọ Rẹ gbogbo akorin",
                        "Nwọn mọ bawo ni Maria",
                        "L'aṣẹ, l'agbara fun wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "A bẹ Ọ Maria Mimọ",
                        "Nipa Ọmọ Rẹ, Jesu:",
                        "Bi awa ti kunlẹ nihin",
                        "Mu wa k'a le jẹ Tirẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "361",
            Title = "IYA JESU, IRAWỌ OKUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya Jesu, irawọ okun,",
                        "Ṣe amọna fun aṣina",
                        "L'igbi aiye ran ni lọwọ",
                        "K'o gba wa la ninu ewu.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iya Kristi, irawọ okun",
                        "Bẹbẹ fun wa, fun aṣina.(bis)",
                        "Iya Kristi, irawọ okun",
                        "Bẹbẹ fun mi, fun ẹlẹsẹ (bis)",
                        "Iya Kristi, 'rawọ okun",
                        "Bẹbẹ fun mi, f'olupọnju (bis)",
                        "lya Kristi, 'rawọ okun",
                        "Bẹbẹ fun wa, fun ọmọde (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A! Wundia ti ko n'ẹgan!",
                        "Awa mbẹ Ọ ran Ọmọ Rẹ",
                        "Jesu, leti pe O jiya,",
                        "O s'atunṣe fun ẹsẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iya Kristi, irawọ okun",
                        "Bẹbẹ fun mi, fun ẹlẹsẹ (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "L'imi ẹdun, l'ibanujẹ",
                        "Si Rẹ, Iya, awa nkepe.",
                        "Wo omije on'rora wa",
                        "K'o yara wa tu wa l'inu.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iya Kristi, 'rawọ okun",
                        "Bẹbẹ fun mi, f'olupọnju (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iwọ ti o jọba l'Ọrun,",
                        "Ọlọrun kan l'ẹni mẹta,",
                        "Isun iye ati ifẹ,",
                        "Awa sin Rẹ l'ikunlẹ wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "lya Kristi, 'rawọ okun",
                        "Bẹbẹ fun wa, fun ọmọde (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "362",
            Title = "IYA ỌLỌRUN, BẸBẸ FUN WA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹwa lati fi irẹlẹ tọro aanu",
                        "Lọdo Iya Oluwa wa Jesu.",
                        "K'a sile fa Iya wa Mimọ l'okan,",
                        "Jẹ k'a sọkan lati kigbe pe Ẹ.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun, bẹbẹ fun wa,",
                        "K'o wa gba wa la, Iwọ ireti wa (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bẹbẹ fun wa, Iwọ Iya wa Mimọ",
                        "Wo! a ṣegbe l'ais'iranlọwọ Rẹ.",
                        "Ọlọrun wa fẹ lati jẹ wa niya,",
                        "Ibinu Rẹ pọsi, wa! gba wa la.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "B'otile jẹ pe awa jẹ ẹlẹsẹ",
                        "Sibẹsibẹ O f'ifẹ Rẹ han wa.",
                        "Wo! ipọnju at'osi mbo wa mọ'lẹ",
                        "Wa! gba wa la, Iya wa Olufẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya Mimọ, nipa kikigbe pe Ọ,",
                        "A bẹrẹ si n'ireti l'okan wa,",
                        "Nitori pe Iwọ yio wa gba wa la;",
                        "Jesu Kristi yio ṣaanu fun wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "363",
            Title = "AVE MARIA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Ave, Ave, Ave Maria",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Angeli li Ọrun,",
                        "Ni yiyin Rẹ ka.",
                        "Nkọrin iyin si Ọ,",
                        "Ayaba Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "B'oju wo li aiye,",
                        "Awọn Ọmọ Rẹ;",
                        "K'o f'eti, Maria,",
                        "Si adura wọn.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Iwọ li ireti",
                        "Ti Olupọnju",
                        "Ti o ngbekele",
                        "Inu rere Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "K'o ranti Kalfari",
                        "On iku Jesu.",
                        "Tọju, Iya Ọwọn,",
                        "Tọju Ọmọ Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Ṣaanu fun ẹlẹsẹ",
                        "K'o mu gbogbo ẹgan",
                        "Ti o ti jẹbi",
                        "Kuro l'ọkan Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "A! Iya Ọlọrun",
                        "Jọba lori wa",
                        "Iwọ l'agbara wa",
                        "Alafia wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "L'akoko ikẹhin",
                        "Wa! gba ẹmi wa",
                        "K'a ba le ri Jesu",
                        "Ati Iya wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "364",
            Title = "JẸ K’EMI FI AIYE YI SILE",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Jẹ k’emi fi aiye yi sile.",
                "Mo fẹ ba Rẹ lọ si Ọrun;",
                "Emi fẹ tẹle Rẹ, Iya mi,",
                "Maria mu mi lọ. (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "S'Ọrun larin awọn Angeli",
                        "Iwọ nlọ Wundia Mimọ",
                        "L'oni gbadura mi",
                        "K'awa le tọ Rẹ lọ s'Ọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "L'Ọrun, bi Olori Angeli,",
                        "Iwọ wa lori itẹ giga,",
                        "Ninu awọn enia Mimọ",
                        "Ọlọrun nikan bori Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Nitori kil'emi ko le lọ",
                        "Pelu Iya mi si Ọrun?",
                        "Bi akoko iku mi ba de",
                        "Wundia Mimọ, wa pe mi.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Aiye yi k'ìṣe ilu t'emi,",
                        "Ẹru iku ko si ba mi,",
                        "Bi Iwọ ba fẹ ran mi lọwọ",
                        "Ọlọrun yio gba mi s'Ọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "365",
            Title = "IYA JESU FI OJU SI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Iya Jesu fi oju si",
                        "Awọn ọmọ t'o fẹran Rẹ;",
                        "Tọju ọkan ti ẹlẹsẹ,",
                        "Fi ara Rẹ han bi Iya. (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Fi eti si adura wa.",
                        "Mu alafia wa fun wa,",
                        "Titi lailai, sọ ranti",
                        "Ifẹ ati oore-ọfẹ Rẹ. (bis)",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Fi s'ọkan wa iwa rere",
                        "F'iwa Mimọ at'aileṣẹ,",
                        "Pa mọ fun wa awọn oore",
                        "T'igbagbọ t'ireti, t'ifẹ. (bis)",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya ma jẹ k'iku ba wa",
                        "Bi a ba wa ninu ẹsẹ",
                        "Iwọ ko fẹ, k'Ọmọ Rẹ ku",
                        "Lati lọ s'Ọrun apadi. (bis)",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "K'awa gbogbo tọkantọkan",
                        "Fẹran Rẹ li Ọrun rere",
                        "K'a maa kọrin titi lailai",
                        "Orukọ Maria Mimọ. (bis)",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "366",
            Title = "IYA RERE, BUKUN FUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A fẹ Jesu, Iya Wundia!",
                        "Jẹ! f'eti si adura wa",
                        "A kepe Ọ Iya Olufẹ,",
                        "Gba adura ti gbogbo wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iya rere bukun fun,",
                        "Igbe t'igbagbọ wa,",
                        "A fẹ Jesu t'o jẹ Baba wa.",
                        "A fẹ Jesu Ọba wa ni! (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A fẹ Jesu, ninu ile wa,",
                        "Ati l'ọkan ọmọde wa;",
                        "Ki Ọlọrun f'oore-ọfẹ Rẹ",
                        "On agbara fun dede wọn!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "A fẹ Jesu l'aiye wa gbogbo",
                        "K'o wa tọju awọn iṣẹ",
                        "Ti ọwọ wa, ati iye wa,",
                        "K'a ba le sọ di ayanfẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Onigbagbọ, t'ifẹ t'inu wa",
                        "K'a jumo ṣe ileri loni",
                        "Pe Maria yio jẹ Iya wa;",
                        "Jesu Baba on Ọba wa.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "367",
            Title = "IYA GIGA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Iya giga ninu obirin gbogbo",
                "Ran mi lọwọ l'akoko idanwo (bis)",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ave, ave Wundia Mimọ",
                        "Ave irawọ titan owurọ!",
                        "Eniti ẹda on'ẹmi,",
                        "K'o ti ṣe bẹbẹ ri lasan.",
                        "Gbadura wa, gbadura wa ọmọ Rẹ.",
                        "Ṣọwa ti wa lẹhin lat'Ọrun wa!",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Nigbati a fẹ kuro n'ile",
                        "Ibi t'alafia gbe wa,",
                        "Ibi ti, li iranlọwọ Rẹ",
                        "Iṣọ wa s'Oluwa rọrun,",
                        "Nigbanaa gan, ọta yio ṣe kọlu wa",
                        "A si mu wa lọra l'ọna ofin.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Kuro ninu wa lọra yi,",
                        "Wo!, bi ẹmi wa ti sinmi!",
                        "Ṣugbọn ẹfufu nla t'o ndide",
                        "O nderuba a ni pupọ",
                        "A! gbọ ti wa, Maria Olubukun!",
                        "Niwọn bi a ti gbẹkẹle Ọ!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya awa bẹ Ọ, ṣe suru,",
                        "Wa tọju wa nigbakẹhin,",
                        "Ba ṣe l'ọdo Onidajọ",
                        "N'ijo ti a ba wa w'ijo!",
                        "Mu k'o gba wa lọwọ",
                        "Iṣẹun Rẹ nla",
                        "Lọ sinu ẹgbẹ rere Ọlọrun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "368",
            Title = "IRAWỌ MIMỌ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
                "Irawọ Mimọ",
                "L'otọju ọkọ",
                "Ti atuko larin okun.",
                "Njẹ k'a maa fo'iya.",
                "Li ijikiji,",
                "Laibẹru iku,",
                "Ka lọ d'ebute.",
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Imọlẹ Mimọ",
                        "Pelu itan tẹ Rẹ",
                        "A o tuko lọ s'ebute.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ara si san wa",
                        "Irunu omi,",
                        "At'ẹfufu",
                        "Nf'ọn ni l'aiya.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Maria Mimọ",
                        "Ẹni t'o mbẹ Ọ,",
                        "T'o bukun fun",
                        "Le ṣegbe bi?",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Iya wa rere",
                        "Awa ọmọ Rẹ",
                        "Nf'ẹbẹ bẹ Ọ",
                        "K'O gbọ ti wa.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Iya Ọlọrun",
                        "Jẹ k'awọn ọmọ Rẹ",
                        "Le ri Jesu",
                        "L'Ọrun rere.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "369",
            Title = "A KI Ọ AYABA ỌRUN",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "A ki Ọ Ayaba Ọrun",
                        "O Maria!",
                        "Iranlọwọ wa at'oore wa",
                        "O Maria!",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Ẹyọ Angeli at'ẹnyin enia Mimọ",
                        "Ẹnyin I ninu ayọ nyin",
                        "Salve, Salve, Salve Regina.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Iwọ ni Iya alanu",
                        "O Maria!",
                        "Ayọ t'iye at'ire wa",
                        "O Maria!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Awa ọmọ Ẹfa nkepe Ọ,",
                        "O Maria!",
                        "Bẹ Jesu Ọmọ Rẹ fun wa,",
                        "O Maria!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Wo, Maria omije wa",
                        "O Maria!",
                        "K'o si f'oju rere wo wọn,",
                        "O Maria!",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Wo awọn ọmọ Rẹ l'ẹsẹ Rẹ,",
                        "O Maria!",
                        "Ki o si rẹ wa li ẹkun,",
                        "O Maria!",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "N'waju itẹ idajọ Ọlọrun",
                        "O Maria!",
                        "Iya nigbana bẹ fun wa",
                        "O Maria!",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "370",
            Title = "JOSEFU ỌKỌ MARIA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Josefu ọkọ Maria,",
                        "Ati Baba Jesu,",
                        "Tinu a kigbe si Ọ;",
                        "Iwọ, jẹ Baba wa.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "Iwọ, Iwọ jẹ Baba wa (leemeta)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "L'aiye Iwọ f'amọra",
                        "Olugbala Kristi",
                        "T'a ma pe Ọ ni Baba.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Ẹlẹri ibi Jesu",
                        "Ati Olutọju",
                        "Iwọ fun On li onjẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "N'ijo ibinu, Iwọ",
                        "L'ọwọ Ọba buru",
                        "Gba Ọmọ on Iya la.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Nipa igbọran Tirẹ",
                        "Iwọ mu wọn jade,",
                        "Kuro ninu iṣegbe.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "O ti ṣiṣẹ fun Jesu",
                        "Ati fun Maria,",
                        "Ṣe suru, ma tọju wa.",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Nigbati iku ba de",
                        "Ki Jesu, Maria,",
                        "Wa gba awọn ọmọ Rẹ.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "371",
            Title = "K'A Ṣ'ỌPẸ FUN JESU",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹyin Angeli Mimọ,",
                        "Ẹnyin Oluwa; wa!",
                        "K'ẹ si dupẹ fun U",
                        "Nitoriti O ṣeun.",
                    }
                },
                new Verse
                {
                    Number = "Egbe:",
                    Lines = new List<string>
                    {
                        "K'a ṣ'Ọpẹ fun Jesu",
                        "Nitori oore nla Rẹ. (bis)",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "A ko ri Baba kan ri",
                        "T'o fẹran ọmọ Rẹ,",
                        "T'o ṣe itọju wọn,",
                        "Bi Jesu ti ṣe fun wa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "B'Olus'agutan rere,",
                        "Ọlọrun tọju wa,",
                        "O si gbe agutan",
                        "T'o ṣina, l'Ọrun Rẹ.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "Anu Rẹ nti wa lẹhin,",
                        "Imọlẹ Rẹ n tọ wa;",
                        "Ẹkọ Rẹ si n kọ wa,",
                        "Ifẹ Rẹ si mu wa yọ.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu nikan l'iye wa,",
                        "On nikan si l'aabo",
                        "Ati iṣura wa,",
                        "Lai sinmi k'a ṣ'Ọpẹ fun U.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "372",
            Title = "WA, JẸK'A YIN SAKRAMENTI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Wa, jẹk'a yin Sakramenti",
                        "Mimọ julo titi lailai,",
                        "T'o jẹ ohun 'ranti Jesu,",
                        "T'o fifun wa k'o to ku!",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ara Jesu, ẹjẹ Jesu,",
                        "Ẹmi, iwa-Ọlọrun Rẹ,",
                        "L'o wa nibẹ dajudaju",
                        "K'abẹ awọn aworan!",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Aworan jẹ nkan t'a le ri,",
                        "Bi aworan at'apere",
                        "Nikan t'a gborun, t'a le ọwọ",
                        "A ko ri Jesu papa!",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "A ko ri I, ṣugbọn a mọ pe",
                        "Jesu papa l'O wa nibẹ;",
                        "Jesu kanna t'o ti rin ri",
                        "L'ojuna Galili!",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Jesu ti ibuje-ẹran,",
                        "Jesu t'o ku l'Agbelebu",
                        "Jesu kanna t'O si joko",
                        "L'ọwọ-ọtun Baba Rẹ!",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "Ṣugbọn b'O ti fẹran wa to,",
                        "T'O si jẹ Olodumare,",
                        "O ṣe iṣẹ 'yanu nla yi,",
                        "K'O le duro larin wa!",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "Awọn kan wa ti ko gbagbọ;",
                        "Nwọn si nsọ bi awọn Ju pe:",
                        "\"Nkan na ṣoro gidigidi,",
                        "\"Tal'o wa to le gba a gbọ?\"",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Awa dahun bi Johanu",
                        "Pe: \"A mọ, a si gba ifẹ",
                        "\"Ti Ọlọrun ni si wa gbọ;",
                        "Ifẹ ni Ọlọrun jẹ.\"",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Njẹ, k'a yin Sakramenti yi,",
                        "T'o jẹ ami ifẹ Jesu,",
                        "T'a si jẹri pelu-pelu",
                        "T'iye ti ko nipẹkun.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "373",
            Title = "ONJẸ ALẸ OLUWA",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ni yara t'a ti pese",
                        "Fun ase ti ikẹhin,",
                        "Jesu joko ti onjẹ",
                        "Nigbati alẹ lẹ.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Bi O ti mọ daju pe",
                        "Opin Rẹ fẹrẹ de,",
                        "O nba awọn ọmọ-ẹhin Rẹ",
                        "Sọrọ pẹlu ifẹ:",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Tinutinu l'Emi n fẹ",
                        "Ba yin jẹ onjẹ yi;",
                        "\"Eyiyi l'akoko na",
                        "Ti Mo ti nduro de.\"",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "\"Ẹnyin ọmọ ayanfẹ!",
                        "\"Ṣiwaju iku Mi,",
                        "\"Mo fẹ fun yin li ẹbun",
                        "\"T'e o ma fi ranti Mi.\"",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Bi wọn ti njẹun lọwọ,",
                        "Jesu daraduro;",
                        "O gbadura si Baba,",
                        "O si mu akara.",
                    }
                },
                new Verse
                {
                    Number = "6",
                    Lines = new List<string>
                    {
                        "O sure si i, O si bu u",
                        "O fun wọn wipe:",
                        "\"Ẹ gba, ẹ jẹ, gbogbo yin.",
                        "\"Ẹyin li Ara Mi!\"",
                    }
                },
                new Verse
                {
                    Number = "7",
                    Lines = new List<string>
                    {
                        "O si mu Ago Waini,",
                        "O dupẹ. O dide,",
                        "O si fifun gbogbo wọn",
                        "Ki wọn mu ninu rẹ.",
                    }
                },
                new Verse
                {
                    Number = "8",
                    Lines = new List<string>
                    {
                        "Lẹhinnan ni O wipe:",
                        "\"Eyi li Ẹjẹ Mi,",
                        "Eyi ti a o ta sile",
                        "Fun ẹsẹ araiye!",
                    }
                },
                new Verse
                {
                    Number = "9",
                    Lines = new List<string>
                    {
                        "Ẹnyin r'ohun ti Mo ṣe,",
                        "\"Mo pa a l'aṣẹ fun yin,",
                        "\"K'ẹ ma ṣe e l'iranti Mi,",
                        "\"Ẹnyin l'aropo Mi.\"",
                    }
                },
                new Verse
                {
                    Number = "10",
                    Lines = new List<string>
                    {
                        "Torina, lojojumo",
                        "Ninu Misa, l'a nṣe",
                        "Bi Jesu papa ti ṣe",
                        "L'oru na t'On yio ku.",
                    }
                },
            }
        },
        new Hymn
        {
            Number = "374",
            Title = "ANGELI GABRIELI MIMỌ",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Angeli Gabrieli Mimọ",
                        "Tọ Maria Wundia lọ",
                        "O si ni Alafia",
                        "O si bi ọmọ kan",
                        "Ti o jẹ Ọmọ Ọlọrun.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Maria si dahun wipe",
                        "Ṣewọ Ọmọ Ọdọ Oluwa",
                        "Ki o ri fun mi",
                        "Gẹgẹ bi ọrọ Rẹ",
                        "O si ṣe bẹ, o si loyun.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Li oṣu mẹsan lẹhinnan",
                        "Maria bi ọmọ kekere kan",
                        "T'a npe ni Emmanuel",
                        "Tabi Jesu, eyi ni",
                        "Ọmọ Ọlọrun t'o wa ba wa gbe.",
                    }
                },
            }
        },
      new Hymn
{
    Number = "375",
    Title = "JESU LA ṢEṢE BI",
    Category = "ORIN IFIKUN",
    Author = "Unknown",
    Chorus = new List<string>
    {
    },
    Verses = new List<Verse>
    {
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "Jesu la ṣẹṣẹ bi sibujẹran Bethlehem",
                "Ẹ jẹ k'a yọ k'a si fi iyin fun U",
                "O pe t'a nreti Rẹ, o ju ẹgbaji ọdun",
                "Ta sọ tẹlẹ fun gbogbo araiye.",
            }
        },
        new Verse
        {
            Number = "Bass:",
            Lines = new List<string>
            {
                "Jesu la ṣẹṣẹ bi",
            }
        },
        new Verse
        {
            Number = "Base + Soprano:",
            Lines = new List<string>
            {
                "L'oganjo yi",
            }
        },
        new Verse
        {
            Number = "Bass:",
            Lines = new List<string>
            {
                "O t'Ọrun wa",
            }
        },
        new Verse
        {
            Number = "Base + Soprano:",
            Lines = new List<string>
            {
                "Si aiye yi",
            }
        },
        new Verse
        {
            Number = "Bass:",
            Lines = new List<string>
            {
                "Lati ba wa la'ja",
            }
        },
        new Verse
        {
            Number = "Base + Soprano:",
            Lines = new List<string>
            {
                "Pẹlu Baba Tirẹ (2ce)",
            }
        },
        new Verse
        {
            Number = "Bass:",
            Lines = new List<string>
            {
                "O si wa gba wa la",
            }
        },
        
        new Verse
        {
            Number = "Soprano:",
            Lines = new List<string>
            {
		" i. Kuro lọwọ Ẹṣu",
                " ii. Kuro lọwọ Ẹṣu, o si mu",
                "\t\talafia wa fun gbogbo wa.",
            }
        },
        new Verse
        {
            Number = "",
            Lines = new List<string>
            {
                "L'oru na ta bi Jesu",
                "Oluso agutan ti nse aisun ni papa",
                "Nwọn nṣọ agutan wọn",
                "Lori oke nla kan l'agbegbe Betlehem",
                "Lojiji l'imọlẹ han li oju Ọrun",
                "Ẹru nla si ba wọn",
                "Nwọn si gbọ orin didun",
                "T'awọn Angeli nkọ fun ogo Ọlọrun.",
            }
        },
	new Verse
        {
            Number = "Soprano:",
            Lines = new List<string>
            {
                "(Gloria gloria in excelsis Deo)",
                
            }
        },
        new Verse
        {
            Number = "Alto + Bass:",
            Lines = new List<string>
            {

                "(Gloria gloria in excelsis Deo)",
            }
        },
        new Verse
        {
            Number = "Soprano:",
            Lines = new List<string>
            {
                "(Et in terra pax)",
            }
        },
        new Verse
        {
            Number = "Alto + Bass:",
            Lines = new List<string>
            {

                "(Excelsis Deo Et in terra)",
            }
        },
        new Verse
        {
            Number = "Gbogbo:",
            Lines = new List<string>
            {
                "Pax hominibus gloria Deo pax hominibus bonae voluntatis.",
            }
        },
new Verse
        {
            Number = "Soprano:",
            Lines = new List<string>
            {
                "(Gbohungbohun si j'ajẹgba)",
                "(Gbohungbohun si j'ajẹgba)",
            }
        },
        new Verse
        {
            Number = "Gbogbo:",
            Lines = new List<string>
            {
                "Gloria Gloria Deo",
            }
        },
        new Verse
        {
            Number = "Soprano:",
            Lines = new List<string>
            {
                "Ati gbigbe'rin…...................",
            }
        },
        new Verse
        {
            Number = "Alto:",
            Lines = new List<string>
            {
                "Ati gbigbe'rin",
            }
        },
        new Verse
        {
            Number = "Bass:",
            Lines = new List<string>
            {
                "j'akẹgba orin wọn",
            }
        },
        new Verse
        {
            Number = "Gbogbo:",
            Lines = new List<string>
            {
                "Pax hominibus hominibus",
            }
        },
        new Verse
        {
            Number = "Solo 1:",
            Lines = new List<string>
            {
                "L'ogan Angeli kan yọ si wọn o si wipe:",
                "Ki ẹru ma ba nyin oluso agutan",
                "Mo mu ihin ayọ wa fun nyin",
                "Li oru yi ni'lu Dafidi, a bi Olugbala",
                "T'a ṣe'leri fun nyin",
                "Ẹnyin yio ri ọmọ na ti a fi ọja we",
                "Lojiji l'awọn Angeli dapọ m'Angeli na",
                "Nwọn si fi orin didun yin Ọlọrun l'ogo.",
                "Yin Ọlọrun l'ogo (2ce)",
                "Gbohungbohun etc...",
            }
        },
        new Verse
        {
            Number = "Solo 2:",
            Lines = new List<string>
            {
                "Awọn okunrin na si fi ẹran wọn sile",
                "Lati lọ wo Jesu ni'lu Betlehem",
                "Nwọn si ri Maria, Josefu, ati ọmọ ọwọ na",
                "Nwọn si bọ, wọn si fun fere fun Un",
                "K'a si lọ pẹlu wọn sibẹ Kristiani",
                "K'a si wolẹ pẹlu k'a si bọ ọmọ ọwọ na",
                "T'o jẹ Olugbala k'a si dupẹ lọwọ Rẹ",
                "K'a kọrin ogo si; On l'Olugbala wa.",
                "Gbohungbohun etc...",
            }
        },
    }
},
        new Hymn
        {
            Number = "376",
            Title = "ẸNYIN KRISTIANI",
            Category = "ORIN IFIKUN",
            Author = "Unknown",
            Chorus = new List<string>
            {
            },
            Verses = new List<Verse>
            {
                new Verse
                {
                    Number = "1",
                    Lines = new List<string>
                    {
                        "Ẹnyin Kristiani t'o wa gbọ",
                        "Itan t'ijiya Jesu,",
                        "Ẹ da omije nyin pọ mọ,",
                        "Ẹjẹ ti On ta sile,",
                        "Bi Jesu Kristi ti jiya,",
                        "Nitori ẹsẹ nla nyin",
                        "L'apere ti ijiya Rẹ,",
                        "K'ẹ jiya, k'ẹ si kun fun U.",
                    }
                },
                new Verse
                {
                    Number = "2",
                    Lines = new List<string>
                    {
                        "Ninu ọgba Getsemani,",
                        "Jesu ti kaanu tobẹẹ,",
                        "Ti On laagun ẹjẹ pupọ",
                        "Ẹru mba A, On gbadura:",
                        "\"Baba, ṣe bi Iwọ ti fẹ,",
                        "K'nsẹ bi emi ti fẹ,\"",
                        "Nigbat' ipọnju de si wa,",
                        "K'a tẹle apere naa.",
                    }
                },
                new Verse
                {
                    Number = "3",
                    Lines = new List<string>
                    {
                        "Juda tọ Oluwa Rẹ wa,",
                        "O fi ẹnu kọ Ọ l'ẹnu",
                        "Bi ẹnipe o fẹran Rẹ.",
                        "Ṣugbọn lati fi I han ni.",
                        "Awọn enia buburu",
                        "Di Oluwa wa lọwọ;",
                        "Nwọn si mu U lọ, O dakẹ",
                        "B'agutan t'a mu lọ pa.",
                    }
                },
                new Verse
                {
                    Number = "4",
                    Lines = new List<string>
                    {
                        "A mu Jesu tọ Ọba lọ,",
                        "Lati da A l'ẹbi iku",
                        "Lẹhinnan, a gba A l'oju,",
                        "Jesu ko si sọrọ kan!",
                        "A nlu U, a si nrẹrin Rẹ,",
                        "Ani a yan Baraba,",
                        "A da Olododo l'ẹbi,",
                        "A dare fun adaran.",
                    }
                },
                new Verse
                {
                    Number = "5",
                    Lines = new List<string>
                    {
                        "Awọn enia buburu",
                        "Wa ọrọ t'a ko mọ ri.",
                        "A si wun",
                    }
                },
            }
        },
    };
        // Categories are derived dynamically from hymns
        public static List<string> AllCategories
        {
            get
            {
                var categories = new HashSet<string>();
                foreach (var hymn in Hymns)
                {
                    if (!string.IsNullOrWhiteSpace(hymn.Category))
                        categories.Add(hymn.Category);
                }
                return new List<string>(categories);
            }
        }

    }
}