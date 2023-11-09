using Singleton;

var scenes = new List<Scene>() {new Scene(5), new Scene(3), new Scene(7)};

var iScene = 1;
foreach (var scene in scenes)
{
    Console.WriteLine( "In Scene " + iScene.ToString() + " Chuck Norris defeated:" );
    foreach (var guy in scene.BadGuys)
    {
        Console.WriteLine( guy.Name + ", strength " + guy.Strength.ToString() );
    }
    Console.WriteLine();
    iScene++;
}
