using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    class Skeleton : Monster
    {

        // ~ Andrew J. O'Connor ~

        // ~ ATTACK & MISS MESSAGES (Narration) ~
        string[] missMessages =
        {
            // 0
            "With a great deal of effort, the skeleton tries to swing its rusted sword at you, but with the weight of the heavy weapon, its arm falls to the floor.  It uses its free hand to reattach the arm, shaking its head with frustration.",
            // 1
            "The skeleton's attack is lazy and clumsy; you are able to anticipate it easily as you step casually to the side, dodging the sword with ease.",
            // 2
            "Trying to kick you with its skinless leg, the skeleton throws itself off balance.  You suppress a laugh as you watch it slip and fall to the floor.",
            // 3
            "A viscious punch was prepared by the skeleton, but its fist ended up nowhere near you... maybe because it has no eyes?  I don't know, why do I have to explain this?"
        };

        string[] slashMessages =
        {
            // 0
            "The skeleton relies on his trusty (and rusty) iron sword to attack, slashing at you visciously.",
            // 1
            "You underestimated the speed and force at which a skeleton without muscles can swing a heavy sword at you.  Nice job.",
            // 2
            "A slash of the skeleton's sword takes its toll on you.",
            // 3
            "The skeleton swings with fury, slicing you with the old sword it wields."
        };

        string[] kickMessages =
        {
            // 0
            "Although you wouldn't have expected it, the skeleton strikes you with a mighty kick.",
            // 1
            "The skeleton kicked you.  Just like how Leonidas kicked that one dude in 300!",
            // 2
            "Struck by a well-executed kick from your opponent, you are quickly overcome by the feeling that you are fighting a human.  Although, a skeleton might technically be considered a human in some way or another, but would be more accurately described as something that used to be human.  Or perhaps the framework of a human?  The point is, the skeleton kicked you, and it sucks.",
            // 3
            "You feel the wind suddenly knocked out of you.  Relying on your addreneline to pull yourself together, you realize the skeleton landed a kick straight to your gut."
        };

        string[] punchMessages =
        {
            // 0
            "The skeleton launches its bony fist against your fleshy face.  POW!",
            // 1
            "You watch as the skeleton draws back a closed fist.  Then it occurs to you: why is a skeleton holding a sword trying to punch you?  You're so caught up in the strange logic behind it that you forget to dodge!",
            // 2
            "A sudden blast of force carried by the skeleton's fist lands on the side of your face, almost knocking you unconcious.",
            // 3
            "SMACK!  The supernaturally undead creature rams its fist against you, knocking you to the floor.  Filled with sportsmanship, however, the skeleton decided to let you get back up and fight."
        };



        // ~ CONSTRUCTORS ~
        //
        //   Customizable Constructor
        public Skeleton
            ( int monsterMaxHealth,
              int monsterAttack,
              int monsterLevel,
              int monsterMinGold,
              int monsterMaxGold,
              int monsterGoldDropped,
              string monsterDescription,
              string monsterName )
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
        public Skeleton()
        {
            // Stats
            MaxHealth = 105;
            Health = 105;
            Attack = 15;
            Level = 4;
            // Gold
            MinGold = 2;
            MaxGold = 6;
            GoldDropped = DropGold(MinGold, MaxGold);
            // Misc.
            Description = "The skeleton of a human, held together by supernatural forces.  It wields a rusty iron sword.";
            Name = "";
        }



        // ~ ATTACKS ~
        //
        // Attack 1 -- SLASH Attack -- Skeleton's strong attack.
        private int Slash()
        {
            Random random = new Random();
            int damage = random.Next(1, Attack);
            return damage;
        }
        // Attack 2 -- KICK Attack -- Skeleton's moderate attack.
        private int Kick()
        {
            Random random = new Random();
            int damage = random.Next(1, 5);
            return damage;
        }
        // Attack 3 -- PUNCH Attack -- Skeleton's weak attack.
        private int Punch()
        {
            Random random = new Random();
            int damage = random.Next(1, 3);
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

            // Punch
            }
            else if (attack < 4)
            {
                damage = Punch();
                Message = punchMessages[msgNumber];

            // Kick
            }
            else if (attack < 6)
            {
                damage = Kick();
                Message = kickMessages[msgNumber];

            // Slash
            }
            else
            {
                damage = Slash();
                Message = slashMessages[msgNumber];
            }
            return damage;
        }
    }
}
