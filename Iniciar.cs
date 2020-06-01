/*
 * Created by SharpDevelop.
 * User: FrancoNT
 * Date: 07/02/2018
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Grafo_Generico_Febrero
{
	/// <summary>
	/// Description of Iniciar.
	/// </summary>
	public class Iniciar
	{
		Grafo grafoCatedra = new Grafo();
		Grafo newGrafo = new Grafo();
		public Iniciar()
		{
			//CREAMOS LOS VERTICES
			Vertice vAlfa = new Vertice("Alfa");
			Vertice vBeta = new Vertice("Beta");
			Vertice vGamma = new Vertice("Gamma");
			Vertice vDelta = new Vertice("Delta");
			Vertice vEpsilon = new Vertice("Epsilon");
			Vertice vZeta = new Vertice("Zeta");
			Vertice vEta = new Vertice("Eta");
			Vertice vTheta = new Vertice("Theta");
			Vertice vIota = new Vertice("Iota");
			Vertice vKappa = new Vertice("Kappa");
			
			//Agregamos los datos que contienen los vertices...
			
			vAlfa.agregarDato(5000);
			vAlfa.agregarDato(11.11F);
			vBeta.agregarDato(10000);
			vBeta.agregarDato(5.55F);
			vGamma.agregarDato(20000);
			vGamma.agregarDato(6.55F);
			vDelta.agregarDato(13000);
			vDelta.agregarDato(4.80F);
			vEpsilon.agregarDato(10000);
			vEpsilon.agregarDato(10.55F);
			vZeta.agregarDato(5000);
			vZeta.agregarDato(3.55F);
			vEta.agregarDato(8000);
			vEta.agregarDato(3.55F);
			vTheta.agregarDato(8000);
			vTheta.agregarDato(7.50F);
			vIota.agregarDato(4000);
			vIota.agregarDato(9.55F);
			vKappa.agregarDato(2000);
			vKappa.agregarDato(3.20F);
			
			
			//Agregamos los vertices al grafo
			
			grafoCatedra.agregarVertice(vAlfa);
			grafoCatedra.agregarVertice(vBeta);
			grafoCatedra.agregarVertice(vGamma);
			grafoCatedra.agregarVertice(vDelta);
			grafoCatedra.agregarVertice(vEpsilon);
			grafoCatedra.agregarVertice(vZeta);
			grafoCatedra.agregarVertice(vEta);
			grafoCatedra.agregarVertice(vTheta);
			grafoCatedra.agregarVertice(vIota);
			grafoCatedra.agregarVertice(vKappa);
			
			//Conectamos los vertices entre sí...
			
			grafoCatedra.conectarVertices(vAlfa, vBeta, 76000);
			grafoCatedra.conectarVertices(vAlfa, vDelta, 20000);
			grafoCatedra.conectarVertices(vBeta, vAlfa, 76000);
			grafoCatedra.conectarVertices(vBeta, vEpsilon, 240000);
			grafoCatedra.conectarVertices(vBeta, vIota, 360000);
			grafoCatedra.conectarVertices(vGamma, vDelta, 10000);
			grafoCatedra.conectarVertices(vGamma, vTheta, 120000);
			grafoCatedra.conectarVertices(vGamma, vKappa, 360000);
			grafoCatedra.conectarVertices(vDelta, vAlfa, 20000);
			grafoCatedra.conectarVertices(vDelta, vGamma, 10000);
			grafoCatedra.conectarVertices(vEpsilon, vBeta, 240000);
			grafoCatedra.conectarVertices(vEpsilon, vEta, 60000);
			grafoCatedra.conectarVertices(vZeta, vEta, 30000);
			grafoCatedra.conectarVertices(vZeta, vIota, 120000);
			grafoCatedra.conectarVertices(vEta, vEpsilon, 60000);
			grafoCatedra.conectarVertices(vEta, vZeta, 30000);
			grafoCatedra.conectarVertices(vTheta, vGamma, 120000);
			grafoCatedra.conectarVertices(vTheta, vKappa, 180000);
			grafoCatedra.conectarVertices(vIota, vBeta, 360000);
			grafoCatedra.conectarVertices(vIota, vZeta, 120000);
			grafoCatedra.conectarVertices(vKappa, vGamma, 360000);
			grafoCatedra.conectarVertices(vKappa, vTheta, 180000);
			
			//Ahora agregamos el segundo dato que tienen las aristas
			
			grafoCatedra.agregarNuevoPeso(vAlfa, vBeta, 27.77F);
			grafoCatedra.agregarNuevoPeso(vAlfa, vDelta, 13.88F);
			grafoCatedra.agregarNuevoPeso(vBeta, vAlfa, 27.77F);
			grafoCatedra.agregarNuevoPeso(vBeta, vEpsilon, 38.88F);
			grafoCatedra.agregarNuevoPeso(vBeta, vIota, 13.88F);
			grafoCatedra.agregarNuevoPeso(vGamma, vDelta, 13.88F);
			grafoCatedra.agregarNuevoPeso(vGamma, vTheta, 38.88F);
			grafoCatedra.agregarNuevoPeso(vGamma, vKappa, 33.33F);
			grafoCatedra.agregarNuevoPeso(vDelta, vAlfa, 13.88F);
			grafoCatedra.agregarNuevoPeso(vDelta, vGamma, 13.88F);
			grafoCatedra.agregarNuevoPeso(vEpsilon, vBeta, 38.88F);
			grafoCatedra.agregarNuevoPeso(vEpsilon, vEta, 13.88F);
			grafoCatedra.agregarNuevoPeso(vZeta, vEta, 16.66F);
			grafoCatedra.agregarNuevoPeso(vZeta, vIota, 16.66F);
			grafoCatedra.agregarNuevoPeso(vEta, vEpsilon, 13.88F);
			grafoCatedra.agregarNuevoPeso(vEta, vZeta, 16.66F);
			grafoCatedra.agregarNuevoPeso(vTheta, vGamma, 38.88F);
			grafoCatedra.agregarNuevoPeso(vTheta, vKappa, 33.33F);
			grafoCatedra.agregarNuevoPeso(vIota, vBeta, 13.88F);
			grafoCatedra.agregarNuevoPeso(vIota, vZeta, 16.66F);
			grafoCatedra.agregarNuevoPeso(vKappa, vGamma, 33.33F);
			grafoCatedra.agregarNuevoPeso(vKappa, vTheta, 33.33F);
			
		}
		
		public void ini()
		{
			Console.Clear();
			Console.WriteLine("             MENU                   ");
			Console.WriteLine("1 - Grafo precargado");
			Console.WriteLine("2 - Nuevo Grafo");
			Console.WriteLine("3 - Para cerrar la aplicación");
			String e = Console.ReadLine();
			int E = int.Parse(e);
			
			switch (E) {
				case 1:
					grafoPre();
					break;
				case 2:
					nuevoGrafo();
					break;
				case 3:
					Environment.Exit(0);
					break;
			//aca tenemos que encontrar la forma de hacer que el programa se cierre
			}
		}
		
		public void grafoPre()
		{
			ArrayList lista = grafoCatedra.getListaDeVertices();			
			Console.Clear();
			Console.WriteLine("           GRAFOS            ");
			Console.WriteLine("1 - para agregar vértice (No funciona)");
			Console.WriteLine("2 - para eliminar un vértice");
			Console.WriteLine("3 - para conectar o desconectar aristas de los vértices");
			Console.WriteLine("4 - para imprimir la matriz de adyacencias");
			Console.WriteLine("5 - para imprimir la lista de vertices del grafo");
			Console.WriteLine("6 - para encontrar un vértice");
			Console.WriteLine("7 - para buscar todos los caminos posibles entre dos vértices");
			Console.WriteLine("8 - para buscar todos los vértices mediante un origen y una distancia");
			Console.WriteLine("9 - para volver");
			String a = Console.ReadLine();
			int A = int.Parse(a);
			
			switch (A) {
				case 1:
					Console.Clear();
					Console.Write("Ingresa el nombre del nuevo vértice: ");
					String nombre = Console.ReadLine();
					Vertice vertice = new Vertice(nombre);
					Console.WriteLine();
					Console.Write("Ingresa el dato que contiene el vértice: ");
					object dato = Console.ReadLine();
					vertice.agregarDato(dato);
					grafoCatedra.agregarVertice(vertice);
					Console.WriteLine();
					Console.Write("Agregar nuevo dato al vértice? y/n: ");
					String dec = Console.ReadLine();
					if (dec == "y") {
						Console.WriteLine();
						Console.Write("Ingresa el dato a agregar en el vértice: ");
						object datnew = Console.ReadLine();
						vertice.agregarDato(datnew);
						Console.WriteLine("Nuevo dato agregado. Presiona cualquier tecla para continuar.");
						Console.ReadKey(true);
						grafoPre();
						break;
					} else
						Console.WriteLine();
					Console.WriteLine("Vértice agregado al grafo. Presiona cualquier tecla para continuar...");
					Console.ReadKey(true);
					grafoPre();
					break;
				
				case 2:
					Console.Clear();
					Console.Write("Ingresa la posicion del vértice a eliminar: ");
					String b = Console.ReadLine();
					int B = int.Parse(b);
					B--;
					Vertice v = (Vertice)lista[B];
					Console.WriteLine("El vertice seleccionado es: " + v.getNombre() + ". Estas seguro de eliminarlo? (si/no)");
					String c = Console.ReadLine();
					if (c == "si") {
						grafoCatedra.eliminarVertice(v);
						Console.WriteLine();
						Console.WriteLine("El vértice ha sido eliminado del grafo. Presiona cualquier tecla para continuar. ");
					}
					if (c == "no") {
						Console.WriteLine();
						Console.WriteLine("El vértice no ha sido eliminado del grafo. Presiona cualquier tecla para continuar. ");
					}
					Console.ReadKey(true);
					grafoPre();
					break;
					
				case 3:
					Console.Clear();
					Console.Write("Ingresa la posicion del primer vértice: ");
					String primero = Console.ReadLine();
					Console.Write("Ingresa la posición del segundo vértice: ");
					String segundo = Console.ReadLine();
					int pr = int.Parse(primero);
					int sg = int.Parse(segundo);
					pr--;
					sg--;
					Vertice pv = (Vertice)lista[pr];
					Vertice sv = (Vertice)lista[sg];
					int pos1 = lista.IndexOf(pv);
					int pos2 = lista.IndexOf(sg);
					Console.Clear();
					Console.WriteLine("Los vértices seleccionados son: " + pv.getNombre() + " y " + sv.getNombre());
					Console.WriteLine("Ingresa 1 para conectar los vértices");
					Console.WriteLine("Ingresa 2 para desconectar los vértices");
					Console.WriteLine("Ingresa 3 para volver");
					String op = Console.ReadLine();
					int opcion = int.Parse(op);
					switch (opcion) {
						case 1:
							Console.Clear();
							Console.Write("Ingresa su peso: ");
							object peso = Console.ReadLine();
							grafoCatedra.conectarVertices(pv, sv, peso);
							Console.WriteLine();
							Console.WriteLine("Los vértices " + pv.getNombre() + " y " + sv.getNombre() + " fueron conectados");
							Console.WriteLine();
							Console.WriteLine("Presiona cualquier tecla para continuar.");
							Console.ReadKey(true);
							grafoPre();
							break;
						
						case 2:
							Console.Clear();
							grafoCatedra.desconectarVertices(pv, sv);
							Console.WriteLine("Los vértices " + pv.getNombre() + " y " + sv.getNombre() + " fueron desconectados.");
							Console.WriteLine();
							Console.WriteLine("Presiona cualquier tecla para continuar.");
							Console.ReadKey(true);
							grafoPre();
							break;
							
						case 3:
							grafoPre();
							break;
					}
					Console.ReadKey(true);
					grafoPre();
					break;
				
				case 4:
					Console.Clear();
					grafoCatedra.imprimirMatriz();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar.");
					Console.ReadKey(true);
					grafoPre();
					break;
					
				case 5:
					Console.Clear();
					Console.WriteLine("La lista de vértices del grafo es: ");
					foreach (Vertice element in lista) {
						Console.Write("[" + element.getNombre() + "]");
					}
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar.");
					Console.ReadKey(true);
					grafoPre();
					break;
					
				case 6:
					Console.Clear();
					Console.WriteLine("Para buscar por posicion ingresa 1");
					Console.WriteLine("Para buscar por nombre ingresa 2");
					String d = Console.ReadLine();
					int D = int.Parse(d);
					switch (D) {
						case 1:
							Console.Clear();
							Console.Write("Ingresa la posicion del vértice a buscar: ");
							String e = Console.ReadLine();
							int E = int.Parse(e);
							E--;
							Vertice v1 = (Vertice)lista[E];
							ArrayList datos = new ArrayList();
							datos = v1.getDatos();
							Console.WriteLine();
							Console.WriteLine("El vértice seleccionado es: " + v1.getNombre());
							Console.WriteLine("Y sus datos son: ");
							foreach (var element in datos) {
								Console.Write("[" + element.ToString() + "]");
							}
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine("Presiona una tecla para continuar.");
							Console.ReadKey(true);
							grafoPre();
							break;
							
						case 2:
							Console.Clear();
							Console.Write("Ingresa el nombre del vértice a buscar: ");
							String vert = Console.ReadLine();
							foreach (Vertice element in lista) {
								if (element.getNombre() == vert) {
									ArrayList dat = new ArrayList();
									dat = element.getDatos();
									Console.WriteLine();
									Console.WriteLine("Los datos de " + element.getNombre() + " son: ");
									foreach (var data in dat) {
										Console.Write("[" + data.ToString() + "]");
									}
									int pos = lista.IndexOf(element);
									pos++;
									Console.WriteLine();
									Console.WriteLine("POSICION en la lista de vértices: " + pos);
									Console.WriteLine();
								}
							}
							
							Console.WriteLine("Presiona cualquier tecla para continuar.");
							Console.ReadKey(true);
							grafoPre();
							break;
					}
					
					break;
					
				case 7:
					Console.Clear();
					Console.Write("Ingresa la posición del vértice origen: ");
					String f = Console.ReadLine();
					Console.Write("Ingresa la posición del vértice destino: ");
					String g = Console.ReadLine();
					int F = int.Parse(f);
					int G = int.Parse(g);
					F--;
					G--;
					Vertice verO = (Vertice)lista[F];
					Vertice verD = (Vertice)lista[G];
					ArrayList camactual = new ArrayList();
					ArrayList todos = new ArrayList();
					ArrayList ady= new ArrayList();
					ArrayList aux = new ArrayList();
					Console.WriteLine();
					Console.WriteLine("Los vértices seleccionados son: " + verO.getNombre() + " y " + verD.getNombre());
					Console.WriteLine("Los caminos posibles entre estos dos vértices son: ");
					aux = grafoCatedra.buscarTodosLosCaminos(verO, verD, camactual, todos,ady);
					foreach (ArrayList l in aux) {
						
						foreach (Vertice ver in l) {
							Console.Write("[" + ver.getNombre() + "]");
						}
						Console.WriteLine();
						Console.WriteLine();
					}
					Console.WriteLine("Presiona cualquier tecla para continuar.");
					Console.ReadKey(true);
					grafoPre();
					break;
					
				case 8:
					Console.Clear();
					Console.Write("Ingresa la posicion del vértice: ");
					String h = Console.ReadLine();
					Console.Write("Ingresa la distancia: ");
					String i = Console.ReadLine();
					int H = int.Parse(h);
					int I = int.Parse(i);
					int cont = 0;
					H--;
					Vertice v2 = (Vertice)lista[H];
					ArrayList vertices = new ArrayList();
					ArrayList aux1 = new ArrayList();
					ArrayList aux2 = new ArrayList();
					Console.WriteLine();
					Console.WriteLine("Todos los vértices alcanzables desde " + v2.getNombre() + " ,con distancia " + I + ", son:");
					Console.WriteLine();
					aux1 = grafoCatedra.buscarCaminosPorDistancia(v2, vertices, I, cont);
					foreach (Vertice v3 in aux1) {
						Boolean ver = aux2.Contains(v3);
						if (v2.getNombre() != v3.getNombre()) {
							if (ver != true) {
								aux2.Add(v3);
							}
					
						}
					}
					foreach (Vertice vert in aux2) {
						Console.Write("[" + vert.getNombre() + "]");
					}
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar.");
					Console.ReadKey(true);
					grafoPre();
					break;
					
				case 9:
					ini();
					break;
			}
		}
		
		public void nuevoGrafo()
		{
			
			ArrayList listanueva = new ArrayList();
			listanueva = newGrafo.getListaDeVertices();
			Console.Clear();
			Console.WriteLine("            NUEVO GRAFO         ");
			Console.WriteLine("1 - VERTICES");
			Console.WriteLine("2 - ARISTAS");
			Console.WriteLine("3 - Imprimir matriz de adyacencias");
			Console.WriteLine("4 - Imprimir lista de vértices del grafo");
			Console.WriteLine("5 - Encontrar un vértice en el grafo");
			Console.WriteLine("6 - Buscar todos los caminos posibles entre dos vértices");
			Console.WriteLine("7 - Buscar todos los vértices mediante un origen y una distancia");
			Console.WriteLine("8 - Volver al menú principal");
			String a = Console.ReadLine();
			int A = int.Parse(a);
			
			switch (A) {
				case 1:
					Console.Clear();
					Console.WriteLine("1 - Agregar vértice al grafo");
					Console.WriteLine("2 - Agregar nuevo dato a un vértice");
					Console.WriteLine("3 - Eliminar un vértice");
					Console.WriteLine("4 - Volver");
					String b = Console.ReadLine();
					int B = int.Parse(b);
					
					switch (B) {
						case 1:
							Console.Clear();
							Console.Write("Ingresa el nombre del vértice: ");
							String nombre = Console.ReadLine();
							Console.WriteLine();
							Console.Write("Ingresa el dato que contiene el vértice: ");
							String data = Console.ReadLine();
							Vertice nvoVer = new Vertice(nombre);
							nvoVer.agregarDato(data);
							newGrafo.agregarVertice(nvoVer);
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine("El vértice ha sido agregado al grafo. Presiona cualquier tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
						case 2:
							Console.Clear();
							Console.Write("Ingresa la posicion del vértice: ");
							String p = Console.ReadLine();
							int P = int.Parse(p);
							P--;
							Console.WriteLine();
							Console.Write("Ingresa el dato a agregar: ");
							String datonuevo = Console.ReadLine();
							Vertice v = (Vertice)listanueva[P];
							v.agregarDato(datonuevo);
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine("El dato ha sido agregado al vértice " + v.getNombre() + ". Presiona cualquier tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
						case 3:
							Console.Clear();
							Console.Write("Ingresa la posicion del vértice a eliminar: ");
							String o = Console.ReadLine();
							int O = int.Parse(o);
							O--;
							Vertice vert = (Vertice)listanueva[O];
							Console.WriteLine("El vertice seleccionado es: " + vert.getNombre() + ". Estas seguro de eliminarlo? (si/no)");
							String c = Console.ReadLine();
							if (c == "si") {
								newGrafo.eliminarVertice(vert);
								Console.WriteLine();
								Console.WriteLine("El vértice ha sido eliminado del grafo. Presiona cualquier tecla para continuar. ");
							}
							if (c == "no") {
								Console.WriteLine();
								Console.WriteLine("El vértice no ha sido eliminado del grafo. Presiona cualquier tecla para continuar. ");
							}
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
						case 4:
							nuevoGrafo();
							break;
					}
					break;
										
				case 2:
					Console.Clear();
					Console.WriteLine("1 - Conectar vertices");
					Console.WriteLine("2 - Desconectar vértices");
					Console.WriteLine("3 - Ver el peso entre dos vértices");
					String d = Console.ReadLine();
					int D = int.Parse(d);
					
					switch (D) {
						case 1:
							Console.Clear();
							Console.Write("Ingresa la posicion del primer vértice: ");
							String primero = Console.ReadLine();
							Console.Write("Ingresa la posición del segundo vértice: ");
							String segundo = Console.ReadLine();
							int pr = int.Parse(primero);
							int sg = int.Parse(segundo);
							pr--;
							sg--;
							Vertice pv = (Vertice)listanueva[pr];
							Vertice sv = (Vertice)listanueva[sg];
							Console.Write("Ingresa el peso que contiene la arista: ");
							String peso = Console.ReadLine();
							newGrafo.conectarVertices(pv, sv, peso);
							Console.WriteLine();
							Console.Write("Los vértices han sido conectados. Presiona cualquier tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
						
						case 2:
							Console.Clear();
							Console.Write("Ingresa la posicion del primer vértice: ");
							String primervertice = Console.ReadLine();
							Console.Write("Ingresa la posición del segundo vértice: ");
							String segundovertice = Console.ReadLine();
							int pr2 = int.Parse(primervertice);
							int sg2 = int.Parse(segundovertice);
							pr2--;
							sg2--;
							Vertice pv2 = (Vertice)listanueva[pr2];
							Vertice sv2 = (Vertice)listanueva[sg2];
							newGrafo.desconectarVertices(pv2, sv2);
							Console.WriteLine();
							Console.WriteLine("Los vértices " + pv2.getNombre() + " y " + sv2.getNombre() + " han sido desconectados.");
							Console.WriteLine("Presiona cualquier tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
						case 3:
							Console.Clear();
							Console.Write("Ingresa la posicion del primer vértice: ");
							String pvp = Console.ReadLine();
							Console.Write("Ingresa la posición del segundo vértice: ");
							String svp = Console.ReadLine();
							int pr3 = int.Parse(pvp);
							int sg3 = int.Parse(svp);
							pr3--;
							sg3--;
							Vertice pv3 = (Vertice)listanueva[pr3];
							Vertice sv3 = (Vertice)listanueva[sg3];
							ArrayList ady = new ArrayList();
							ady = pv3.getAristas();
							ArrayList dato = new ArrayList();
							foreach (Aristas element in ady) {
								if (element.getVerDes() == sv3) {
									dato = element.getPeso();
								}
							}
							Console.WriteLine();
							Console.Write("El peso entre " + pv3.getNombre() + " y " + sv3.getNombre() + " es: ");
							foreach (var element in dato) {
								Console.WriteLine("[" + element + "]");
							}
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine("Presiona cualquier tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
					}
					break;
					
				case 3:
					Console.Clear();
					newGrafo.imprimirMatriz();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar...");
					Console.ReadKey(true);
					nuevoGrafo();
					break;
							
				case 4:
					Console.Clear();
					Console.WriteLine("La lista de vértices del grafo es: ");
					foreach (Vertice element in listanueva) {
						Console.Write("[" + element.getNombre() + "]");
					}
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar.");
					Console.ReadKey(true);
					nuevoGrafo();
					break;
					
				case 5:
					Console.Clear();
					Console.WriteLine("Para buscar por posicion ingresa 1");
					Console.WriteLine("Para buscar por nombre ingresa 2");
					String f = Console.ReadLine();
					int F = int.Parse(f);
					switch (F) {
						case 1:
							Console.Clear();
							Console.Write("Ingresa la posicion del vértice a buscar: ");
							String e = Console.ReadLine();
							int E = int.Parse(e);
							E--;
							Vertice v1 = (Vertice)listanueva[E];
							ArrayList datos = new ArrayList();
							datos = v1.getDatos();
							Console.WriteLine();
							Console.WriteLine("El vértice seleccionado es: " + v1.getNombre());
							Console.WriteLine("Y sus datos son: ");
							foreach (var element in datos) {
								Console.Write("[" + element.ToString() + "]");
							}
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine("Presiona una tecla para continuar...");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
						case 2:
							Console.Clear();
							Console.Write("Ingresa el nombre del vértice a buscar: ");
							String vert = Console.ReadLine();
							foreach (Vertice element in listanueva) {
								if (element.getNombre() == vert) {
									ArrayList dat = new ArrayList();
									dat = element.getDatos();
									Console.WriteLine();
									Console.WriteLine("Los datos de " + element.getNombre() + " son: ");
									foreach (var data in dat) {
										Console.Write("[" + data.ToString() + "]");
									}
									int pos = listanueva.IndexOf(element);
									pos++;
									Console.WriteLine();
									Console.WriteLine("POSICION en la lista de vértices: " + pos);
									Console.WriteLine();
								}
							}
							
							Console.WriteLine("Presiona cualquier tecla para continuar.");
							Console.ReadKey(true);
							nuevoGrafo();
							break;
							
					}
					break;
					
				case 6:
					Console.Clear();
					Console.Write("Ingresa la posición del vértice origen: ");
					String h = Console.ReadLine();
					Console.Write("Ingresa la posición del vértice destino: ");
					String g = Console.ReadLine();
					int H = int.Parse(h);
					int G = int.Parse(g);
					H--;
					G--;
					Vertice verO = (Vertice)listanueva[H];
					Vertice verD = (Vertice)listanueva[G];
					ArrayList camactual = new ArrayList();
					ArrayList todos = new ArrayList();
					ArrayList adyacentes=new ArrayList();
					ArrayList aux = new ArrayList();
					Console.WriteLine();
					Console.WriteLine("Los vértices seleccionados son: " + verO.getNombre() + " y " + verD.getNombre());
					Console.WriteLine("Los caminos posibles entre estos dos vértices son: ");
					aux = grafoCatedra.buscarTodosLosCaminos(verO, verD, camactual, todos,adyacentes);
					foreach (ArrayList l in aux) {
						foreach (Vertice ver in l) {
							Console.Write("[" + ver.getNombre() + "]");
						}
						Console.WriteLine();
						Console.WriteLine();
					}
					Console.WriteLine("Presiona cualquier tecla para continuar...");
					Console.ReadKey(true);
					nuevoGrafo();
					break;
					
				case 7:
					Console.Clear();
					Console.Write("Ingresa la posicion del vértice: ");
					String j = Console.ReadLine();
					Console.Write("Ingresa la distancia: ");
					String i = Console.ReadLine();
					int J = int.Parse(j);
					int I = int.Parse(i);
					int cont = 0;
					J--;
					Vertice v2 = (Vertice)listanueva[J];
					ArrayList vertices = new ArrayList();
					ArrayList aux1 = new ArrayList();
					ArrayList aux2 = new ArrayList();
					Console.WriteLine();
					Console.WriteLine("Todos los vértices alcanzables desde " + v2.getNombre() + " ,con distancia " + I + ", son:");
					Console.WriteLine();
					aux1 = grafoCatedra.buscarCaminosPorDistancia(v2, vertices, I, cont);
					foreach (Vertice v3 in aux1) {
						Boolean ver = aux2.Contains(v3);
						if (v2.getNombre() != v3.getNombre()) {
							if (ver != true) {
								aux2.Add(v3);
							}
					
						}
					}
					foreach (Vertice vert in aux2) {
						Console.Write("[" + vert.getNombre() + "]");
					}
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("Presiona cualquier tecla para continuar...");
					Console.ReadKey(true);
					nuevoGrafo();
					break;
					
				case 8:
					ini();
					break;
			}
		}
	}
}
		

