namespace exercise_36;

class Program{
    static void Main(){
        Score s = new ScoreNatural(5.6, 7.7, 9, 4.5, 7.6, 8);
        ScoreNatural sn =  new ScoreNatural(5.6, 7.7, 9, 4.5, 7.6, 8);
        Console.WriteLine(s.avgPoint() + " " + s.PointA() + " " + s.PointB() + " " + sn.pointNatural());

        s = new ScoreSocial(7.8, 8, 9, 8.8, 9.5, 7);

        ScoreSocial ss = new ScoreSocial(7.8, 8, 9, 8.8, 9.5, 7);
        Console.WriteLine(s.avgPoint() + " " + s.PointC() + " " + s.PointD() + " " + ss.pointSocial());
    }
}