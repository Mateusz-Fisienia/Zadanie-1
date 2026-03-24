ile = int(input("Ile masz ocen? "))
suma = 0


for i in range(ile):
    ocena = float(input("Podaj ocenę: "))
    suma = suma + ocena  


wynik = suma / ile
print("Twoja średnia to:", wynik)


if wynik >= 3.0:
    print("Zdałeś!")
else:
    print("Niestety, nie zdałeś.")