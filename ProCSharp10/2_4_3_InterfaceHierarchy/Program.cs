using _2_4_3_InterfaceHierarchy;

Console.WriteLine("simeple interface hierarchy");
BitmapImage bitmap = new BitmapImage();
if(bitmap is IAdvancedDraw iAdvDraw)
{
    iAdvDraw.DrawUpsideDown();
    Console.WriteLine($"time to draw is {iAdvDraw.TimeToDraw()}");
}