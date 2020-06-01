/*
 * Created by SharpDevelop.
 * User: FrancoNT
 * Date: 31/01/2018
 * Time: 16:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Grafo_Generico_Febrero
{
	
	public class Grafo
	{
		ArrayList vertices = new ArrayList();
		int[,] matriz;
		
		public void agregarVertice(Vertice v)
		{
			vertices.Add(v);
			int cant = vertices.Count;
			matriz = new int[cant, cant];
		}
		
		public void agregarNuevoPeso(Vertice vO, Vertice vD, object p)
		{
			foreach (Vertice element in vertices) {
				if (element == vO) {
					element.agregarNuevoPeso(vD, p);
				}
			}
		}
		
		public void eliminarVertice(Vertice v)
		{
			foreach (Vertice element in vertices) {
				if (v == element) {
					int n = vertices.IndexOf(v);
					v.setNombre("ElementoBorrado");
					for (int i = 0; i < matriz.GetLength(0); i++) {
						matriz[i, n] = -1;
						matriz[n, i] = -1;
					}
					break;
				}	
			}
			Console.WriteLine();
			
		}
		
		public ArrayList getListaDeVertices()
		{
			return vertices;
		}
		
		public void conectarVertices(Vertice vOrigen, Vertice vDestino, object peso)
		{
			int origen = vertices.IndexOf(vOrigen);
			int destino = vertices.IndexOf(vDestino);
			matriz[origen, destino] = 1;
			vOrigen.agregarAdyacente(vDestino, peso);
			
		}
		
		public void desconectarVertices(Vertice vO, Vertice vD)
		{
			int origen = vertices.IndexOf(vO);
			int destino = vertices.IndexOf(vD);
			matriz[origen, destino] = 0;
			vO.eliminarAdyacente(vD);

		}
		
		public int[,] getMatriz()
		{
			return matriz;
		}
		
		public void imprimirMatriz()
		{
			Console.WriteLine();
			Console.WriteLine("La matriz es: ");
			for (int i = 0; i < matriz.GetLength(1); i++) {
				for (int j = 0; j < matriz.GetLength(1); j++) {
					
					Console.Write("[" + matriz[i, j] + "]");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("ACLARACION: El valor -1 especifica que un vertice fue eliminado del grafo. ");
		}
		
		public ArrayList listaDeAdyacentes(Vertice v)
		{
			ArrayList adyacentes = new ArrayList();
			adyacentes = v.getAdyacentes();
			return adyacentes;
		}
		
		public void vertice()
		{
			Console.WriteLine();
			Console.Write("Ingresa una posicion para encontrar un vertice: ");
			String l = Console.ReadLine();
			int posicion = int.Parse(l);
			posicion = posicion - 1;
			Vertice verti = (Vertice)vertices[posicion];
			Console.WriteLine();
			Console.WriteLine("El nombre del vertice seleccionado es: " + verti.getNombre());
			Console.Write("Y sus datos son: ");
			ArrayList datos = new ArrayList();
			datos = verti.getDatos();
			foreach (var element in datos) {
				Console.Write("[" + element + "]");
			}
			
			
		}
		
		public ArrayList buscarCaminosPorDistancia(Vertice verO, ArrayList vertices, int distancia, int cont)
		{
			ArrayList adyacentes = new ArrayList();
			adyacentes = listaDeAdyacentes(verO);
			if (cont == distancia) {
				vertices.Add(verO);
			} else {
				cont++;
				foreach (Vertice v in adyacentes) {
					buscarCaminosPorDistancia(v, vertices, distancia, cont);
					
				}
			}
				
			return vertices;
			
		}
		
		
		public ArrayList buscarTodosLosCaminos(Vertice verO, Vertice VerD, ArrayList caminoActual, ArrayList todosLosCaminos, ArrayList adyacentes)
		{

			adyacentes = listaDeAdyacentes(verO);
			caminoActual.Add(verO);
			verO.marcarVisitado();
			
			if (verO == VerD) {
				todosLosCaminos.Add(caminoActual.Clone());
			} else {
				foreach (Vertice v in adyacentes) {
					if (v.getVisitado() == false) {
						buscarTodosLosCaminos(v, VerD, caminoActual, todosLosCaminos, adyacentes);
						//v.desmarcar();
						//caminoActual.Remove(v);
					}

				}
			}
			verO.desmarcar();
			caminoActual.Remove(verO);
			return todosLosCaminos;
		}
	}
}
