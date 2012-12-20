using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCDelta_Plus
{
    public enum LevelTypes
    {
        Flat,
    }
    class Level
    {
        public Point3 Size;

        public Level(Point3 size) {

        }

        public static Level CreateFlatLevel(Point3 size, LevelTypes type) 
        {
            Level newLevel = new Level(size);

            switch(type)
            {
                case LevelTypes.Flat:
                    newLevel.CreateFlatLevel();
                    break;
                    
            }
            
            return newLevel;
        }
        void CreateFlatLevel()
        {

        }
    }
}

