
using UnityEngine;

namespace GameParametr
{
    public static class GameParametrs
    {
        [Tooltip("здоровье игрока")]
        public static int hp = 99; 
        [Tooltip("скорость движения машины")]
        public static float speed = 0.05f; 

        [Tooltip("текущи счет")]
        public static float curScore;
        [Tooltip("лучший счет")]
        public static float bestScore;
        [Tooltip("проверка на рекорд")]
        public static bool record = false;

        [Tooltip("собранные монетки")]
        public static int coins = 0;
        [Tooltip("собранные монетки для щита")]
        public static int coinsToProtects = 0;
        [Tooltip("проверяем, есть ли щит")]
        public static bool hasProtect = false;

    }
}
