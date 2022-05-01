using System;
using System.Collections.Generic;
using MusoeunEngine;

class Player : MusoeunBehavior
{
    private string name;
    public Player(string p_name)
    {
        name = p_name;
    }
    public void Awake() { }
    public void Start()
    {
        Console.SetCursorPosition(0, 2);
        Console.WriteLine(name + " : 내 이름은 "+name+"!!!");
    }
    public void Update() { }
    public void Render()
    {
        Console.SetCursorPosition(0, 4);
        Console.WriteLine(name + " : 너네 3대만 맞자.");
    }
}

class Enemy : MusoeunBehavior
{
    int x, y;
    private string name;
    public Enemy(string e_name, int PosX, int PosY)
    {
        x = PosX;
        y = PosY;
        name = e_name;
        Awake();
    }
        public void Awake() { }
        public void Start() { }
        public void Update() { }
        public void Render()
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(name + " : 우리는 무시무시한 적이다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        List<MusoeunBehavior> GameObjects = new List<MusoeunBehavior>();

        Player player = new Player("원소은");
        Enemy e1 = new Enemy("이슬희", 0, 7);
        Enemy e2 = new Enemy("최연우", 0, 8);
        Enemy e3 = new Enemy("최성원", 0, 9);

        GameObjects.Add(player);
        GameObjects.Add(e1);
        GameObjects.Add(e2);
        GameObjects.Add(e3);

        foreach(MusoeunBehavior item in GameObjects)
        {
            item.Start();
        }

        while (true)
        {
            foreach (MusoeunBehavior item in GameObjects)
            {
                item.Update();
            }
            foreach (MusoeunBehavior item in GameObjects)
            {
                item.Render();
            }
        }
    }
}
