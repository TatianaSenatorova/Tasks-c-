/*Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y*/

void CheckLogic()
{
    bool X = true;
    bool Y = true;
    if (!(X || Y) == !X && !Y)
    Console.Write($"true");
    else Console.Write($"false");
    
}
CheckLogic();