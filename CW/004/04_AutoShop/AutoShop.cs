using System;

namespace _04_AutoShop
{
	class AutoShop : IComparable<AutoShop>
	{
		public string CarName { set; get; }
		public int MaxSpeed { get; set; }
		public double Cost { get; set; }
		public byte Discount { get; set; }
		public int Id { get; set; }

		public AutoShop() { }
		public AutoShop(string carName, int maxSpeed, double cost, byte discount, int id)
		{
			CarName = carName;
			MaxSpeed = maxSpeed;
			Cost = cost;
			Discount = discount;
			Id = id;
		}

		/// <summary>
		/// Реализуем интерфейс IComparable<T>
		/// </summary>
		public int CompareTo(AutoShop obj)
		{
			if (Cost > obj.Cost)
				return 1;
			if (Cost < obj.Cost)
				return -1;
			return 0;
		}

		public override string ToString()
		{
			return $"{Id}\tМарка: {CarName}\tМакс. скорость: {MaxSpeed}\tЦена: {Cost:C}\tСкидка: {Discount}%";
		}
	}
}