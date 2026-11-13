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
# print(3/1.5)

szam = 42
lista =[1,2,3]

def noveld(n):
    n = n + 1
    return n

def add_hozza(list,szam):
    return list.append(szam)

print(f"Előtte: {szam}")
noveld(szam)
print(f"Utána: {noveld(szam)}")

print(f"Előtte: {lista}")
add_hozza(lista,4)
print(f"Utána: {lista}")

szoveg = "indul a görög aludni"

def mennyi_szobol_all(szoweg):
    szamlalo = 1
    for betu in szoweg:
        if betu == " ":
            szamlalo += 1
    return szamlalo

szavak_szama = mennyi_szobol_all(szoveg)
print(f"{szoveg}: {szavak_szama} szó")


def szetvalaszt(szoveg):
    szavak = []
    szo = ""

    for karakter in szoveg:
        if karakter == " ":
            if szo != "":
                szavak.append(szo)
                szo = ""
        else:
            szo += karakter

    if szo != "":
        szavak.append(szo)

    return szavak

print(f"{szetvalaszt(szoveg)}")

pontszamok = [
    [5,5,5,5,5],
    [5,8,6,7,5],
    [6,9,6,6,6],
    [4,6,5,5,4]
]

nyert_versenyzo = 0
aktualis_pont=0
for matrixsor in pontszamok:
    for elem in matrixsor:
        aktualis_pont += elem

    if aktualis_pont > nyert_versenyzo:
        nyert_versenyzo = aktualis_pont
    aktualis_pont = 0
print(f"A nyertes versenyző pontszáma: {nyert_versenyzo}")
for matrix in pontszamok:
    for elem in matrix:




