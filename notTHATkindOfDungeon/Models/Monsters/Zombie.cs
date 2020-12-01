using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models.Monsters
{
    public class Zombie : Monster
    {

        // ~ Andrew J. O'Connor ~

        // ~ ATTACK & MISS MESSAGES (Narration) ~
        string[] missMessages =
        {
            // 0
            "With a gurgling, nonhuman growl, the zombie lunges at you.  No, no, wait... no, he's going for the wall.  Oh wait, no, he's coming back!  No, nevermind, he's at the wall again.  Looks like he has no idea what he's doing...",
            // 1
            "The zombie throws a punch, but your attacker is sluggish—you dodge with ease.",
            // 2
            "Your opponent had the perfect opportunity to land the best hit ever, but he just stood there.  Zombies don't have brains, you know.",
            // 3
            "After starting a sprint for you, the undead creature sees you preparing a counter attack, stopping it DEAD in its tracks (ha)."
        };

        string[] weakSlapMessages =
        {
            // 0
            "You just got hit with the weakest and lamest slap in the history of slaps.  You are a true hero.",
            // 1
            "A strong attack it is not, but it is unexpected nonetheless.  You take a sloppy hit.",
            // 2
            "Your enemy slaps you... smack...",
            // 3
            "After feeling a slightly painful impact on the side of your face, you are struck with a bolt of sudden revelation: the worst part about being slapped by a zombie is not the attack itself, but the realization that the decayed and rotting hand of a corpse touched your face.  Understanding this with bitter revolt, you feel determined to slay the creature first, and to wash your face clean with a gentle cleanser later."
        };

        string[] punchMessages =
        {
            // 0
            "The zombie throws a punch, catching you off-guard.  It was beautifully executed with proper form.  Maybe the guy was a boxer when he was alive.",
            // 1
            "A punch strikes your face, but the real sting is knowing that a brainless creature actually managed to land a hit on you.",
            // 2
            "With lazy and unbalanced posture and form, the zombie attempts to strike you with an uppercut.  Surely it only worked because you never imagiend a zombie trying an uppercut of all things.  Most people fail to expect this from a living person.",
            // 3
            "A blast of force and pain overwhelms your face, starting at the nose.  Realizing the zombie punched you, you spit onto the dungeon floor—undaunted, ready to continue the fight like the tough person you are,"
        };

        string[] scratchMessages =
        {
            // 0
            "The zombie scratched you with its sharp and brittle fingernails.  Better get some Neosporin on that as soon as you can.",
            // 1
            "Fiercely swinging its arm, the monster tears at your flesh.",
            // 2
            "The zombie attacks you with its sharp fingernails.  'Tis but a scratch!",
            // Fun-Fact: The "'Tis but a scratch!" part is a reference to Monty Python and the Holy Grail.
            // 3
            "You feel a quick wave of agonizing pain as the zombie scratches you.  If the zombie doesn't kill you, untreated cellulitis might."
            // Fun-Fact: This line was inspired by my (Andrew's) experience with cellulitis—My leg got extremely swollen, and a red discoloration
            //           spread down my leg entire leg in half an hour.  I went to the hospital and was sent home with two kinds of medication.
            //           To this day, I still don't know what scratched my leg and gave me the infection.
        };



        // ~ CONSTRUCTORS ~
        //
        //   Customizable Constructor
        public Zombie
            (int monsterMaxHealth,
              int monsterAttack,
              int monsterLevel,
              int monsterMinGold,
              int monsterMaxGold,
              int monsterGoldDropped,
              string monsterDescription,
              string monsterName)
        {
            // Stats
            MaxHealth = monsterMaxHealth;
            Health = MaxHealth;
            Attack = monsterAttack;
            Level = monsterLevel;
            // Gold
            MinGold = monsterMinGold;
            MaxGold = monsterMaxGold;
            GoldDropped = monsterGoldDropped;
            // Misc.
            Description = monsterDescription;
            Name = monsterName;
        }
        //
        //   Default Value Constructor
        public Zombie()
        {
            // Stats
            MaxHealth = 110;
            Health = 110;
            Attack = 12;
            Level = 4;
            // Gold
            MinGold = 8;
            MaxGold = 12;
            GoldDropped = DropGold(MinGold, MaxGold);
            // Misc.
            Description = "A creature of the living dead—a walking, ever-decaying corpse with a taste for human flesh.";
            Name = "";
        }



        // ~ ATTACKS ~
        //
        // Attack 1 -- SCRATCH Attack -- Zombie's strong attack.
        private int Scratch()
        {
            Random random = new Random();
            int damage = random.Next(3, Attack);
            return damage;
        }
        // Attack 2 -- PUNCH Attack -- Zombie's moderate attack.
        private int Punch()
        {
            Random random = new Random();
            int damage = random.Next(2, 6);
            return damage;
        }
        // Attack 3 -- WEAK SLAP Attack -- Zombie's weak attack.
        private int WeakSlap()
        {
            Random random = new Random();
            int damage = random.Next(1, 5);
            return damage;
        }



        // ~ ATTACK FUNCTION ~
        //   This randomly selects an attack for a monster to use & returns the damage.
        public int UseAttack()
        {
            Random random = new Random();
            int damage = 0;
            int attack = random.Next(0, 3);
            int msgNumber = random.Next(0, 3);


            // ~ Select Attack or Miss ~
            //
            // Miss
            if (attack == 0)
            {
                damage = 0;
                Message = missMessages[msgNumber];

            // Bite
            }
            else if (attack == 1)
            {
                damage = WeakSlap();
                Message = weakSlapMessages[msgNumber];

            // Slap
            }
            else if (attack == 2)
            {
                damage = Punch();
                Message = punchMessages[msgNumber];

            // Slash
            }
            else
            {
                damage = Scratch();
                Message = scratchMessages[msgNumber];
            }
            return damage;
        }
    }
}
