Console. Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
int xa = 40, ya = 1,     //координаты вершины 1
    xb = 1,  yb = 20,    //координаты вершины 2
    xc = 80, yc = 20;   //координаты вершины 3
Console.SetCursorPosition (xa,ya);    //позиция курсора
Console.WriteLine("+");               //рисуем плюсик

Console.SetCursorPosition (xb,yb);
Console.WriteLine("+");

Console.SetCursorPosition (xc,yc);
Console.WriteLine("+");

int x = xa, y = xb; //может ya?
int count = 0;
while(count < 1000)
{
   int what = new Random().Next(0,3);  //числа в интервале 0,1,2
   if (what == 0)
   {
    x = (x+xa)/2;
    y = (y+ya)/2;
   }
   if (what == 1)
   {
    x = (x+xb)/2;
    y = (y+yb)/2;
   }
   if (what == 2)
   {
    x = (x+xc)/2;
    y = (y+yc)/2;
   }
   Console.SetCursorPosition (x,y);
   Console.WriteLine("+");
   count = count + 1;  // или можно еще  count++;
}