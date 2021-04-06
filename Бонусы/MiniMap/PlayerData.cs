using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerData
    {
        public int level1;
        public int health1;
        public float[] position;


        public PlayerData(Player player)
        {
            level1 = player.level;
            health1 = player.health;

            position = new float[3];
            position[0] = player.transform.position.x;
            position[1] = player.transform.position.y;
            position[2] = player.transform.position.z;


        }
    }
}