
using UnityEngine;

namespace GameParametr
{
    public static class GameParametrs
    {
        [Tooltip("�������� ������")]
        public static int hp = 99; 
        [Tooltip("�������� �������� ������")]
        public static float speed = 0.05f; 

        [Tooltip("������ ����")]
        public static float curScore;
        [Tooltip("������ ����")]
        public static float bestScore;
        [Tooltip("�������� �� ������")]
        public static bool record = false;

        [Tooltip("��������� �������")]
        public static int coins = 0;
        [Tooltip("��������� ������� ��� ����")]
        public static int coinsToProtects = 0;
        [Tooltip("���������, ���� �� ���")]
        public static bool hasProtect = false;

    }
}
