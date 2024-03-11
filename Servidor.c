#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

int main(int argc, char *argv[]) 
{
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	memset(&serv_adr, 0, sizeof(serv_adr));
	serv_adr.sin_family = AF_INET;
	
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	
	serv_adr.sin_port = htons(9050);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf ("Error en la escucha");
	
	int i;
	for (i=0;i<100;i++){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf("Conexi￳n recibida\n");
		
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf("Recibido\n");
		
		peticion[ret]='\0';
		
		printf("Peticion: %s\n",peticion);
		
		char *p = strtok(peticion, "/");
		int codigo = atoi(p);
		p = strtok(NULL, "/");
		char nombre[20];
		int gradosc = atof (p);
		
		if (codigo == 1)
			int longitud = strlen(nombre);
			for (int j=0; j<longitud; j++){
				if(nombre[j] = nombre[longitud-j])
					printf("SI");
				else
					printf("NO");
			}
			
		else if (codigo == 2)
			for (int j=0; j<longitud; j++){
				nombre [j] = toupper(nombre[j]);
				printf ("%s\n", nombre);
			}
			
			
		else if (codigo == 3)
			float gradosf = (gradosc * 9/5) + 32;
			printf("%d ﾺC son %d ﾺF", gradosc, gradosf);
	}
	
	close (sock_conn);
		
}