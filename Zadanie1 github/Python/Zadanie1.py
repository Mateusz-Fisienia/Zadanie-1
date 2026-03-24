a = float(input("Pierwsza liczba: "))
znak = input("Co robimy (+, -, *, /): ")
b = float(input("Druga liczba: "))


if znak == "+":
    print(a + b)
elif znak == "-":
    print(a - b)
elif znak == "*":
    print(a * b)
elif znak == "/":
    print(a / b)
else:
    print("Zły znak!")