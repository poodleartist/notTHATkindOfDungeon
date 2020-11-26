using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace notTHATkindOfDungeon.Models
{
    class Goblin : Monster
    {
        // ~ ATTACK & MISS MESSAGES (Narration) ~
        string[] missMessages =
        {
            // 0
            "The goblin lunges at you with its sharp teeth, hoping to bite you, but it fails miserably, stumbling and falling to the floor.  It then gets back up and brushes itself off, ready to keep fighting.",
            // 1
            "The goblin tries to slap you, but slaps itself instead... what an idiot...",
            // 2
            "The goblin prepares to slash you with its claws, but it misses, its hand just inches away from you!",
            // 3
            "The goblin felt ready to attack, but it got nervous, so it decided to wait... sitting there... staring at you, blankly..."
        };

        string[] slashMessages =
        {
            // 0
            "With sharp claws, the goblin swings his scaly arm with violent force.  You feel the air brush against your skin as you try to dodge.",
            // 1
            "The creature swings his arm furiously, bearing wicked claws like that of an animal.",
            // 2
            "A frightening (and somewhat irritating) screech harolds the goblin's attack as he flais his arm ferociously, trying to slash you with its claws.",
            // 3
            "The vicious claws of the wicked goblin make themselves known as it tries to attack."
        };

        string[] slapMessages =
        {
            // 0
            "Like a foolish peasant, the goblin swings the palm of its clawed hand towards your face.",
            // 1
            "In the heat of the moment, the goblin tries desperately to think of some powerful, masculine attack to use against you.  All it managed was a wimpy slap.",
            // 2
            "Goblin used\nSLAP!",
            // 3
            "With a swing as fast as lightning, the goblin tries to smack you right in your face!"
        };

        string[] biteMessages =
        {
            // 0
            "Plunging its face toward you, the creature exposes a set of fangs prepared to dig deep into you.",
            // 1
            "The goblin throws its face towards you, trying to bite you with its razor sharp teeth... but at lease it didn't try to kiss you.",
            // 2
            "The greenskin's mouth drooling, it lunges toward you with deranged determination, trying to bite you.",
            // 3
            "Ew, that thing actually wants to put its mouth on you!  It's going for a bite!"
        };



        // ~ CONSTRUCTORS ~
        //
        //   Customizable Constructor
        public Goblin
            ( int     goblinMaxHealth,
              int     goblinAttack,
              int     goblinLevel,
              int     goblinMinGold,
              int     goblinMaxGold,
              int     goblinGoldDropped,
              string  goblinDescription,
              string  goblinName )
            {
              // Stats
              MaxHealth    =  goblinMaxHealth;
              Health       =  MaxHealth;
              Attack       =  goblinAttack;
              Level        =  goblinLevel;
              // Gold
              MinGold      =  goblinMinGold;
              MaxGold      =  goblinMaxGold;
              GoldDropped  =  goblinGoldDropped;
              // Misc.
              Description  =  goblinDescription;
              Name         =  goblinName;
            }
        //
        //   Default Value Constructor
        public Goblin()
        {
            // Stats
            MaxHealth    =  100;
            Health       =  100;
            Attack       =  10;
            Level        =  1;
            // Gold
            MinGold = 2;
            MaxGold = 8;
            GoldDropped = dropGold(MinGold, MaxGold);
            // Misc.
            Description  =  "A crafty, mischevious creature known for its avarice—very green.";
            Name         =  "";
        }



        // ~ ATTACKS ~
        //
        // Attack 1 -- SLASH Attack -- Goblin's strong attack.
        private int Slash()
        {
            Random random = new Random();
            int damage = random.Next(1, Attack);
            return damage;
        } 
        // Attack 2 -- SLAP Attack -- Goblin's moderate attack.
        private int Slap()
        {
            Random random = new Random();
            int damage = random.Next(1, 5);
            return damage;
        }
        // Attack 3 -- BITE Attack -- Goblin's weak attack.
        private int Bite()
        {
            Random random = new Random();
            int damage = random.Next(1, 3);
            return damage;
        }
        


        // ~ ATTACK FUNCTION ~
        //   This randomly selects an attack for a Goblin to use & returns the damage.
        public int UseAttack()
        {
            Random random = new Random();
            int damage = 0;
            int attack = random.Next(0,3);
            int msgNumber = random.Next(0, 3); 


            // ~ Select Attack or Miss ~
            //
            // Miss
            if (attack == 0) {
                damage = 0;
                Message = missMessages[msgNumber];

            // Bite
            } else if (attack < 4) {
                damage = Bite();
                Message = biteMessages[msgNumber];

            // Slap
            } else if (attack < 6) {
                damage = Slap();
                Message = slapMessages[msgNumber];

            // Slash
            } else {
                damage = Slash();
                Message = slashMessages[msgNumber];
            }
            return damage;
        }




    }

    
    
}
