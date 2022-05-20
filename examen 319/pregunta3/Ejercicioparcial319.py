# -*- coding: utf-8 -*-
"""
Created on Fri May 20 12:21:17 2022

@author: jonah
"""

from pyswip import Prolog
prolog = Prolog()


prolog.assertz("padre(antonio,iris)")
prolog.assertz("padre(antonio,belinda)")
prolog.assertz("padre(antonio,jhonatan)")
prolog.assertz("abuelo(walter,iris)")
prolog.assertz("abuelo(walter,belinda)")
prolog.assertz("abuelo(walter,jhonatan)")

#prolog.assertz("padre(Julieta,Iris)"),("padre(Julieta,Belinda)"),("padre(Julieta,Jhonatan)")
                #,("Walter","Antonio"),("Walter","Virginia"),("Walter","WalterII"),("Graciela","Antonio"),("Graciela","Virginia"),("Graciela","WalterII"),("Modesto","Julieta"),("Modesto","Aida"),("Modesto","Samuel"),("Flora","Julieta"),("Flora","Aida"),("Flora","Samuel"),("Virginia","Denisse"),("Samuel","Roger")


list(prolog.query("padre(antonio,X)"))==[{"X":"iris"},{"Y":"belinda"},{"Z":"jhonatan"}]
list(prolog.query("padre(walter,X)"))==[{"X":"antonio"}]

for elemento in prolog.query("padre(X,Y)"):
    print(elemento["X"], " es padre de ", elemento["Y"])
    
print()
    
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], " es abuelo de ", elemento["Y"])
    