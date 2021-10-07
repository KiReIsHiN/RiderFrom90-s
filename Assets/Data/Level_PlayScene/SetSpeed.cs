using GameParametr;

class SetSpeed
{
    void SetSpeedLevel()
    {
        if (GameParametrs.curScore > 0 && GameParametrs.curScore < 30)
            GameParametrs.speed = 0.05f;
        if (GameParametrs.curScore > 30 && GameParametrs.curScore < 60)
            GameParametrs.speed = 0.1f;
        if (GameParametrs.curScore > 60 && GameParametrs.curScore < 90)
            GameParametrs.speed = 0.2f;
        if (GameParametrs.curScore > 90 && GameParametrs.curScore < 120)
            GameParametrs.speed = 0.3f;
        if (GameParametrs.curScore > 120 && GameParametrs.curScore < 150)
            GameParametrs.speed = 0.4f;
        if (GameParametrs.curScore > 150 && GameParametrs.curScore < 180)
            GameParametrs.speed = 0.30f;
        if (GameParametrs.curScore > 180 && GameParametrs.curScore < 210)
            GameParametrs.speed = 0.5f;
        if (GameParametrs.curScore > 210 && GameParametrs.curScore < 240)
            GameParametrs.speed = 0.6f;
        if (GameParametrs.curScore > 240 && GameParametrs.curScore < 270)
            GameParametrs.speed = 0.7f;
        if (GameParametrs.curScore > 300 && GameParametrs.curScore < 330)
            GameParametrs.speed = 0.8f;
        if (GameParametrs.curScore > 330 && GameParametrs.curScore < 360)
            GameParametrs.speed = 0.9f;
        if (GameParametrs.curScore > 360)
            GameParametrs.speed = 1.0f;
    }

}
