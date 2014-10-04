using System;

namespace Application
{
	public class Event // déclare t'on la class publique ?
	{
		public Event (int id, string content)
		{
			Date = DateTime.Now;
			Id = id;
			Content = content;
		}
		public Event (): this(0, "") {}

		public DateTime Date { get; set; }
		public int Id { get; set; }
		public string Content { get; set; }
	}
	public class Backend
	{
		// On implémente : get (n), put (event), get (n1, n2), rand() 
		// On suppose que le string renvoyé est codé en JSON
		public Event Get(int n) { return new Event ();}
		public Event[] Get(int n1, int n2) {
			Event[] ret = new Event[n2-n1];
			return ret;
		}
		public Event rand() {return new Event(); }
		public void Put (Event e) {}
	}
}
