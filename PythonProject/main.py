# dobasok = [] #[random.randint(1, 6) for _ in range(10)]
#
# for i in range(10):
#     dobas = random.randint(1,6)
#     dobasok.append(dobas)
#
# print(dobasok)
#
# osszeg = 0
# for elem in dobasok:
#     osszeg = osszeg + elem
#
# print(osszeg)
#
# hatosok = 0
# for i in range(6000):
#     dobas = random.randint(1,6)
#     if dobas==6:
#         hatosok+=1
# print(f"Ennyiszer volt hatos: {hatosok}")
#
# darabok = {1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0}
#
# for i in range(6000):
#     dobas = random.randint(1,6)
#     darabok[dobas]+=1
#
# print(darabok)
# darabok2 = {1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0}
# dobas_eddig = 0
#
# def osztok(osztando):
#     osztokTomb = []
#     kezdoertek = 1
#     while True:
#         if szam % kezdoertek == 0:
#             osztokTomb.append(kezdoertek)
#         kezdoertek += 1
#         if kezdoertek == szam:
#             osztokTomb.append(osztando)
#             print(osztokTomb)
#             break
#
# # while dobas_eddig < 6000000:
# #     dobas = random.randint(1,6)
# #     darabok2[dobas] += 1
# #     dobas_eddig+=1
# # print(darabok2)
# # print("gondoltam egy számra 1 és 100 között")
# # gepszam = random.randint(1,100)
# # while True:
# #     tipp = int(input("Add meg a számod: "))
# #     if tipp > gepszam:
# #         print("fölé tippeltél")
# #     elif tipp < gepszam:
# #         print("alá tippeltél")
# #     elif tipp == gepszam:
# #         break
# # print("nyertél")
# print("------------")
# print("----TOTO----")
# for i in range(14):
#     x = random.randint(1,3)
#     if x == 1:
#         print("| (1) 2 X  |")
#     elif x == 2:
#         print("| 1 (2) X  |")
#     else:
#         print("| 1 2 (X)  |")
# print("------------")
# # eredmeny = 0
# # while True:
# #     szam = int(input("Adj meg egy számot: "))
# #     eredmeny = eredmeny + szam
# #     if szam == 0:
# #         print(eredmeny)
# #         break
#
# szam = int(input("Adj meg egy számot és megmondom az osztóit: "))
#
# osztok(szam)
#
# def karakterSor(n: int, ca: str):
#     return int(n) * ca
#
# print(karakterSor(12, "gde"))
#
# def korTeruletTerulet(r: float):
#     return 2 * r * math.pi ,math.sqrt(r) * math.pi
#
# print(korTeruletTerulet(2.5))
#
# # def maximum(n1:int, n2:int, n3:int):
# #     lista = [n1,n2,n3]
# #     temp = 0
# #     for i in len(lista):
# #         if temp < lista[i]:
# #             temp = lista[i]
# #     return temp
# # print(maximum(1,6,2))
#
# def eszperente(szoveg:str):
#     maganhangzok = ["a","á","o","ó","u","ú","i","í","ö","ő","ü","ű","é"]
#     eddigi_szoveg=""
#     for betu in szoveg:
#         if betu in maganhangzok:
#             eddigi_szoveg+="e"
#         else:
#             eddigi_szoveg+= betu
#
#     return eddigi_szoveg
#
# print(eszperente("árvíztűrő tükörfúrógép"))
import math
# lista1= [4, 3, 2, 5, 9, 8, 1, 7]
# lista2 = [5,2,8,12,7,1,0]
# def osszeg(listaa):
#     szum = 0
#     for elem in listaa:
#         szum += elem
#
#     return szum
#
# def atlag(listaa):
#     atlagg=0
#     for elem in listaa:
#         atlagg += elem
#
#     return atlagg / len(listaa)
#
#
# print(osszeg(lista1))
# print(osszeg(lista2))
# def van_e(lista, mitKeresek):
#     for elem in lista:
#         if elem == mitKeresek:
#             return True
#
# def paros_e(szam):
#     if szam % 2 == 0:
#         return True
#     return False
#
# def listaban_van_e_paros_szam(lista):
#     for elem in lista:
#         if paros_e(elem):
#             return True
#     return False
# print("geci\ngeci")
## print(3/1.5)
#
#szam = 42
#lista =[1,2,3]
#
#def noveld(n):
#    n = n + 1
#    return n
#
#def add_hozza(list,szam):
#    return list.append(szam)
#
#print(f"Előtte: {szam}")
#noveld(szam)
#print(f"Utána: {noveld(szam)}")
#
#print(f"Előtte: {lista}")
#add_hozza(lista,4)
#print(f"Utána: {lista}")
#
#szoveg = "indul a görög aludni"
#
#def mennyi_szobol_all(szoweg):
#    szamlalo = 1
#    for betu in szoweg:
#        if betu == " ":
#            szamlalo += 1
#    return szamlalo
#
#szavak_szama = mennyi_szobol_all(szoveg)
#print(f"{szoveg}: {szavak_szama} szó")
#
#
#def szetvalaszt(szoveg):
#    szavak = []
#    szo = ""
#
#    for karakter in szoveg:
#        if karakter == " ":
#            if szo != "":
#                szavak.append(szo)
#                szo = ""
#        else:
#            szo += karakter
#
#    if szo != "":
#        szavak.append(szo)
#
#    return szavak
#
#print(f"{szetvalaszt(szoveg)}")
#
#pontszamok = [
#    [5,5,5,5,5],
#    [5,8,6,7,5],
#    [6,9,6,6,6],
#    [4,6,5,5,4]
#]
#
#nyert_versenyzo = 0
#aktualis_pont=0
#for matrixsor in pontszamok:
#    for elem in matrixsor:
#        aktualis_pont += elem
#
#    if aktualis_pont > nyert_versenyzo:
#        nyert_versenyzo = aktualis_pont
#    aktualis_pont = 0
#print(f"A nyertes versenyző pontszáma: {nyert_versenyzo}")
#for matrix in pontszamok:
#    for elem in matrix:
#

# import turtle
import random
# import math
#
# screen = turtle.Screen()
# screen.title("Programozás Gyakorlat")
# screen.bgcolor("grey")
#
# t = turtle.Turtle()
# t.pensize(2)
# t.color = "white"
# t.speed(2)

def rajzoljHaromszoget(t,n):
    for i in range(3):
        t.forward(n)
        t.left(120)

def rajzoljNegyzetet(t, n):
    szinek = ["blue", "red", "green", "yellow", "orange",
              "purple", "pink", "magenta", "brown", "cyan"]

    for j in range(4):
        for i in range(4):
            szin = random.choice(szinek)
            t.pencolor(szin)
            t.forward(n)
            t.left(90)

        n = n - 45

# rajzoljNegyzetet(t, 200)

def rajzoljDerekSzoget(t,a,b):
    t.forward(a)
    t.left(90)
    t.forward(b)
    c = math.sqrt((a*a)+(b*b))
    tg = math.atan(a/b)
    alpha = math.degrees(tg)
    t.right(180 + alpha)
    t.forward(c)



# rajzoljDerekSzoget(t,120,200)
def szaggatott_vonalas_negyzet(t,n):
    for j in range(4):
        for i in range(5):
            t.forward(n/10)
            t.penup()
            t.forward(n/10)
            t.pendown()
        t.left(90)

# szaggatott_vonalas_negyzet(t,200)


# screen.mainloop()

import json
from pathlib import Path

FAJL = Path(__file__).with_name("telefonkonyv.json")

telefonkonyv = [
    {
        "nev": "Gábor",
        "telefon": "+36302121241",
        "komment": ""
    },
    {
        "nev": "Ákos",
        "telefon": "+36306023654",
        "komment": "Saját számom"
    },
    {
        "nev": "Sándor",
        "telefon": "+365052661652",
        "komment": "Kucsi"
    },
    {
        "nev": "József",
        "telefon": "+36205125123",
        "komment": "Baszdmeg"
    }
]


# Telefonkönyv mentése
def mentes():
    try:
        with open(FAJL, "w", encoding="utf-8") as fajl:
            json.dump(telefonkonyv, fajl, ensure_ascii=False, indent=4)
    except OSError as hiba:
        print("Mentési hiba:", hiba)


# Telefonkönyv betöltése
def betoltes():
    global telefonkonyv

    if FAJL.exists():
        try:
            with open(FAJL, "r", encoding="utf-8") as fajl:
                adatok = json.load(fajl)

            if not isinstance(adatok, list):
                raise ValueError("Hibás fájlformátum!")

            for kontakt in adatok:
                if not isinstance(kontakt, dict):
                    raise ValueError("Hibás kontakt!")

                if "nev" not in kontakt or "telefon" not in kontakt:
                    raise ValueError("Hiányzó kontaktadat!")

                # Régi mentések támogatása
                if "komment" not in kontakt:
                    kontakt["komment"] = kontakt.get("megjegyzes", "")

                kontakt.pop("megjegyzes", None)

            telefonkonyv = adatok

        except (OSError, ValueError, json.JSONDecodeError) as hiba:
            print("Betöltési hiba:", hiba)
            print("A program az alapértelmezett kontaktokkal indul.")


# Kontaktok kilistázása
def kilistaz(kontaktok):
    if len(kontaktok) == 0:
        print("A telefonkönyv üres!")
        return

    print("\n--- Telefonkönyv ---")

    for i, kontakt in enumerate(kontaktok, start=1):
        print(f"\n{i}. kontakt")
        print("Név:", kontakt["nev"])
        print("Telefonszám:", kontakt["telefon"])
        print("Komment:", kontakt.get("komment", ""))

    print("--------------------")


# Új kontakt hozzáadása
def hozzaad():
    print("\n--- Kontakt hozzáadása ---")

    nev = input("Add meg a nevet: ").strip()

    if nev == "":
        print("A név nem lehet üres!")
        return

    telszam = input("Add meg a telefonszámot: ").strip()

    if not telszam.startswith("+"):
        print("A telefonszámot + előhívóval add meg!")
        return

    if not telszam[1:].isdigit():
        print("Hibás telefonszám!")
        return

    if not 7 <= len(telszam[1:]) <= 15:
        print("A telefonszám hossza érvénytelen!")
        return

    for kontakt in telefonkonyv:
        if kontakt["telefon"] == telszam:
            print("Ez a telefonszám már szerepel a telefonkönyvben!")
            return

    komment = input("Megjegyzés, ha van: ").strip()

    kontakt = {
        "nev": nev,
        "telefon": telszam,
        "komment": komment
    }

    telefonkonyv.append(kontakt)
    mentes()

    print(f"{nev} sikeresen hozzáadva!")


# Kontakt törlése
def torles():
    print("\n--- Kontakt törlése ---")

    if len(telefonkonyv) == 0:
        print("Nincs törölhető kontakt!")
        return

    kilistaz(telefonkonyv)

    try:
        sorszam = int(input("\nAdd meg a törlendő kontakt sorszámát: "))

        if sorszam < 1 or sorszam > len(telefonkonyv):
            print("Nincs ilyen sorszám!")
            return

        kontakt = telefonkonyv[sorszam - 1]

        valasz = input(
            f"Biztosan törlöd ezt a kontaktot: {kontakt['nev']}? (i/n): "
        ).strip().lower()

        if valasz == "i":
            telefonkonyv.pop(sorszam - 1)
            mentes()
            print("Kontakt sikeresen törölve!")
        else:
            print("Törlés megszakítva.")

    except ValueError:
        print("Érvényes sorszámot adj meg!")


# Kontakt keresése
def kereses():
    print("\n--- Kontakt keresése ---")

    keresett = input(
        "Add meg a keresett nevet, telefonszámot vagy kommentet: "
    ).strip().lower()

    if keresett == "":
        print("Nem adtál meg keresési feltételt!")
        return

    talalatok = []

    for kontakt in telefonkonyv:
        nev = kontakt["nev"].lower()
        telefon = kontakt["telefon"]
        komment = kontakt.get("komment", "").lower()

        if keresett in nev or keresett in telefon or keresett in komment:
            talalatok.append(kontakt)

    if len(talalatok) > 0:
        print(f"\n{len(talalatok)} találat:")
        kilistaz(talalatok)
    else:
        print("Nem található ilyen kontakt!")


# Főprogram
betoltes()

while True:
    print("\n========== TELEFONKÖNYV ==========")
    print("1. Kontaktok kilistázása")
    print("2. Kontakt hozzáadása")
    print("3. Kontakt törlése")
    print("4. Kontakt keresése")
    print("5. Kilépés")
    print("==================================")

    menu = input("Válassz menüpontot (1-5): ").strip()

    if menu == "1":
        kilistaz(telefonkonyv)

    elif menu == "2":
        hozzaad()

    elif menu == "3":
        torles()

    elif menu == "4":
        kereses()

    elif menu == "5":
        print("Kilépés a telefonkönyvből.")
        break

    else:
        print("Nincs ezen a gombon funkció!")

# try:
#     file = open("test.txt", "r")
#     for line in file.readlines():
#         print(line)
#
#     file.close()
# except FileNotFoundError:
#     print("nem sikerült megnyitni")
# except ZeroDivisionError:
#     print("nullával nem lehet osztani")
# except:
#     print("valami egyéb hiba történt")
# finally:
#     print("Lefutott a finally blokk")

