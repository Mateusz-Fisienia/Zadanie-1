
opcja = input("Wybierz jednostkę wejściową (C lub F): ").upper()
temp = float(input("Podaj wartość temperatury: "))

if opcja == "C":
    wynik = temp * 1.8 + 32
    print(f"{temp}°C to {wynik:.2f}°F")
elif opcja == "F":
    wynik = (temp - 32) / 1.8
    print(f"{temp}°F to {wynik:.2f}°C")
else:
    print("Nieprawidłowy wybór. Wybierz C lub F.")