/*
 * Created by SharpDevelop.
 * User: FrancoNT
 * Date: 31/01/2018
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Grafo_Generico_Febrero
{
	
	public class Aristas
	{
		ArrayList peso = new ArrayList();
		Vertice verD;
		Vertice verO;

		
		public Aristas(Vertice verorigen, Vertice verdestino, object p)
		{
			peso.Add(p);
			verO = verorigen;
			verD = verdestino;
		}
		
		public void agregarPeso(object p)
		{
			peso.Add(p);
		}
		
		public ArrayList getPeso()
		{
			return peso;
		}
		
		public Vertice getVerOri()
		{
			return verO;
		}
		
		public Vertice getVerDes()
		{
			return verD;
		}
	}
}
