namespace RoomLib
{
    public class Room
    {
        double _roomLength;
        double _roomWidth;
        public double RoomLength
        {
            get { return _roomLength; }
            set { _roomLength = value; }
        }
        public double RoomWidth
        {
            get { return _roomWidth; }
            set { _roomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет преиметр комнаты
        /// </summary>
        /// <returns>возвращает значения периметра</returns>
        public double RoomPerimeter()
        { return 2 * (_roomLength + _roomWidth); }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>возвращает значения площади</returns>
        public double RoomArea()
        { return _roomLength * _roomWidth; }
        /// <summary>
        /// метод вычисляет площадь на одного человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>число квадратных метров на одного человека</returns>
        public double PersonArea(int np)
        { return RoomArea() / np; }
        public virtual string Info()
        {
            return "Комната площадью " + RoomArea() + "кв.м";
        }
    }
    public class LivingRoom : Room
    {
        int numWin;// число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }
        public override string Info()
        {
            return "Жилая комната площадью" + RoomArea() + "кв.м, с " + numWin + " окнами";

        }
    }
    public class Office : Room
    {
        int numSocets; // число розеток
        public int NumSocets
        { get { return numSocets; } set { numSocets = value; } }
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(num, numSocets);
        }
        public override string Info()
        {
            return "Офис на " + NumWorkplaces() + " рабочих мест";
        }
    }
}