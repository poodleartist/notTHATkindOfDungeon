using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    public class IntroSection : Models.Sections.Section
    {
        // Declare empty array of scenes.
        public Scene[] introScenes = { };


        // Returns a specific scene.
        public Scene getIntroScene(int sceneNumber)
        {
            return introScenes[sceneNumber];
        }


        // Constructor
        public IntroSection()
        {
            SectionName = "In the Beginning...";
            SectionNumber = 0;


            Scene intro0 = new Scene();
            intro0.SceneNumber = 0;
            intro0.Heading = "Late one night...";
            intro0.MainParagraph = "The air around you is chilled, riddled with mist, and perhaps a hint of magic. Your shoes are on the brink of slipping on the rain coated sidewalk. The view around you painted by neon lights of the shops and bars. Surrounded by an array of establishments closed early (due to reduced hours), you stumble your way along, your mind weak from sleep deprivation and caffeine withdrawl. In the darkness, a faint red light emerges in the distance. You find yourself intrigued. You've walked this path every night for months, yet this blood red glow has no place in your memory.";
            intro0.Prompt = "The next two steps allow you to see that the glow originates from a neon sign";
            introScenes[0] = intro0;
            CurrentSceneNumber = 0;



            Scene intro1 = new Scene();
            intro1.SceneNumber = 1;
            intro1.Heading = "You turn to leave...";
            intro1.MainParagraph = "For a long moment, you stand with your back to the sign, urging yourself to walk away. What does it matter, you question, if there's a new place you've never seen before? It's late, cold, wet, and you should hurry home.";
            intro1.Prompt = "But still you stand there—unable to leave. Finally you turn around and inspect the sign.";
            introScenes[1] = intro1;
            CurrentSceneNumber = 1;



            Scene intro2 = new Scene();
            intro2.SceneNumber = 2;
            intro2.Heading = "Your interest is stimulated, but not enough.";
            intro2.MainParagraph = "Though your mind has been sent into a flurry of curiosity, the rain and hour reminds you of its power to influence your decisions.  You find that your interest in going home and settling in for the night outweighs your interest in discovering more about this new place.  You start walking home again to indulge in your warm living room and the relaxing environment your house offers.";
            intro2.Prompt = "";
            introScenes[2] = intro2;
            CurrentSceneNumber = 2;



            Scene intro3 = new Scene();
            intro3.SceneNumber = 3;
            intro3.Heading = "The Dungeon";
            intro3.MainParagraph = "The medieval style lettering simply reads 'The Dungeon'. Beneath these words there shines an arrow directing your attention to a stairway leading to underground cafes and shops. You peer down the stairs and find a similar sign, though bigger, perhaps redundant and pointless, indicating the entrance to the Dungeon is the first door at the bottom of the stairs. It now appears to be a nightclub... could it really be THAT kind of dungeon?";
            intro3.Prompt = "You stand there motionless, gazing down the stairs, entangled in fascination.";
            introScenes[3] = intro3;
            CurrentSceneNumber = 3;



            Scene intro4 = new Scene();
            intro4.SceneNumber = 4;
            intro4.Heading = "The Dungeon";
            intro4.MainParagraph = "You peer down the stairs, Despite the five cups of tea you just drank at the cafe you were departing from, your endless thirst beckons you to the door of The Dungeon.  Furthermore, the very thought of thumping club music has you feeling less drowsy.  Although, something might also be said about the fact that this place appeared from nothingness.  Or maybe you're just drunk.";
            intro4.Prompt = "The ornate door matches the medieval style of The Dungeon's logo; it is ornate and embelished, like a door to be found in a gothic cathedral.";
            introScenes[4] = intro4;
            CurrentSceneNumber = 4;



            Scene intro5 = new Scene();
            intro5.SceneNumber = 5;
            intro5.Heading = "You open the door... crreeeeeeeeeeeeaaaaak...";
            intro5.MainParagraph = "The door creaks as you pull it open.  Entering The Dungeon, you lay eyes upon a gothic foyer, applying your hand sanitizer as you venture deeper into the building (which, by the way, is much larger on the inside).  A brief whiff of smoke finally causes you to notice the torches on the walls.  ''How very atmospheric,'' you think, ''though, perhaps a bit of a fire hazard.''  As you venture deeper into the foyer, you discover a man, covered in knight's armor, battling a creature unlike anything you've seen before, except for in video games—red with horns upon the head, demonlike in appearance.\n" +
                                   "With his shield, the knight bashes the creature towards you, and as you move to dodge, it trips over your foot, lunging its demonic head against the stone floor.";
            intro5.Prompt = "''Behold!'' the knight shouts, startling you lightly.  ''The beast is slain!  With naught but a twitch of thy foot, thou hast claimed victory!  Greetings, stranger—hast thou come to grant us aid in our quest to vanquish the wicked Valmor?''";
            introScenes[5] = intro5;
            CurrentSceneNumber = 5;



            Scene intro6 = new Scene();
            intro6.SceneNumber = 6;
            intro6.Heading = "Nope.";
            intro6.MainParagraph = "''Not really, I just—''\n\n" +
                                   "''FOOL!'' the knight interrupts.\n\n" +
                                   "''Wha... I w—''\n\n" +
                                   "''FOOL!'' he repeats.  ''Unless slain, the demon Valmor will unleash the chaos of hell upon our world; we are all that stands between him and the unsuspecting world above.''\n\n" +
                                   "''But that's none of my business,'' you insist.\n\n" +
                                   "''Wait, what?  Seriously?''  The knight's old English speech evaporates into thin air.\n\n" +
                                   "''It's out of my hands; I'm just a man—I'm not a hero.''\n\n" +
                                   "''Dang, that's messed up,'' says the knight with honesty. ''Well, if you really want to leave, then okay—can't stop you...''\n\n" +
                                   "''Okay, have a nice night,'' you answer casually, turning and walking toward the door.\n\n" +
                                   "As you leave, you overhear the knight utter but one final word to himself: ''...fool...''";
            intro6.Prompt = "";
            introScenes[6] = intro6;
            CurrentSceneNumber = 6;



            Scene intro7 = new Scene();
            intro7.SceneNumber = 7;
            intro7.Heading = "You ask the Knight about Valmor...";
            intro7.MainParagraph = "''Who's Valmor?  And what parent came up with that stupid name?''\n\n" +
                                   "''Valmor is the lord of darkness, the father of wickedness, the prince of evil, and many other unsavory things.  He is of the underworld, and he holds an army of creatures at his disposal.  Beware him, for he is the demon responsible for some of earth's greatest evils.  He even created the Coronavirus, methinks.''";
            intro7.Prompt = "";
            introScenes[7] = intro7;
            CurrentSceneNumber = 7;



            Scene intro8 = new Scene();
            intro8.SceneNumber = 8;
            intro8.Heading = "You ask the knight who he is...";
            intro8.MainParagraph = "''Who the heck are you?''\n\n" +
                                   "''Hark!'' the knight yells.  ''Submit thy interest to the words that follow, for thy life shalt rest upon these things that I reveal unto you.  Long ago, peace befell upon the land of Elandiir, resting on the balance that we, the Knights of Seven, hath kept.  Forgotten to the world is the ongoing and eternal battle against the unknown wickedness of Valmor and the minions he does cast unto the forces of good!  Thou hath heard well of the Seven Runes of Elandiir, is it not so?''\nn" +
                                   "The knight's ''long and eternal'' monologue leaves you speechless as you shake your head from side to side.\n\n" +
                                   "''Forsooth!'' the knight exclaims. ''For the fruit of this dark lord is deception.  May thy mind and spirit fare with wisdom as thou hearken to this tale.  Ere the Age of Giliam the Brave, the host of Valmor scattered the seven runes across the world, on the skirt of even the farthest reaches of mankind.  The runes kept the dark lord Valmor restricted to the halls of the underworld.  We knights swore an oath to safeguard the runes, for the mage Alsius the Wise didst open portals to the seven dungeons hiding the ancient runes.  We erected this outpost to fortify the place where the portals lie.  Since that time, the Knights of Seven have battled the host of Valmor, that his demonic hands might never grasp nor even rest upon the runes.  For these things, unto God, I pray; Summon thy mighty sword against the usurper Valmor, and vanquish with righteous severity the billow of wickedness spawning from the wretched demon king himself!''" +
                                   "You are stunned and cannot find a reply to this.  For multiple seconds you stare.  ''...Wow... and I just thought this was a club...''\n\n" +
                                   "''Nay!  'Tis not THAT kind of dungeon!  Now, will thou take up arms and do battle against the forces of Valmor to help us reclaim the runes?''";
            intro8.Prompt = "";
            introScenes[8] = intro8;
            CurrentSceneNumber = 8;



            Scene intro9 = new Scene();
            intro9.SceneNumber = 9;
            intro9.Heading = "You nod your head with determination.";
            intro9.MainParagraph = "''Fetch me a sword, and you shall see it in Valmor's evil heart!'', you shout with the confidence of a god.  Such confidence earned you recognition in many clubs, bars, and cafes—all the babes were eager to have a drink with you.  On this night, your dauntless spirit would serve a more glorious purpose.\n\n" +
                                   "''Thy valor shall be honored in songs through the ages!  I am Dave, son of Ted.''  Dave reaches over his shoulder, and a small wooden sword appears in his hand, though you see no scabbard in which the weapon might have rested.  You think nothing of this as Dave hands you the weapon. ''I regret this is all that is available for a time.  Trust it not to slay Valmor.''\n\n" +
                                   "Looking at the sword, you are overwhelmed with skepticism.  ''Can I trust it to slay anything at all?''\n\n" +
                                   "''Nay—'Tis but a toy.  Had thou not arrived a lanspresado, thou wouldst bear gold to trade for a proper blade.''\n\n" +
                                   "''Um... Lanspr—''\n\n" +
                                   "''Fear not!'' Dave interrupted, ''for the goblins lurking within the halls of the dungeon possess gold, and they keep it in great store.  If thou wouldst slay a goblin, thou shalt procure treasure, or perhaps a key to unlock one of their treasure chests.  When thou art carrying 20 gold pieces, seeketh Glenn, the merchant, and he shalt grant thee an iron sword.''\n\n" +
                                   "''Slay goblins and take treasure... why not?''";
            intro9.Prompt = "";
            introScenes[9] = intro9;
            CurrentSceneNumber = 9;


            /* TEMPLATE
             * 
            Scene introX = new Scene();
            introX.SceneNumber = X;
            introX.Heading = "";
            introX.MainParagraph = "";
            introX.Prompt = "";
            introScenes[X] = introX;
            */
        }
    }
}
