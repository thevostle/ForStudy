import random 
 
stats = [] 
attributes = 5 
 
print('Stats: ', end='') 
for i in range(attributes): 
    r = random.randint(60, 80) 
    stats.append(r) 
    print(stats[i], end=' ') 
 
print('\n\t[1] - Strength\ \n\t[2] - Dexterity\ \n\t[3] - Intelligence\ \n\t[4] - Wisdom\ \n\t[5] - Charisma') 
select = int(input('Select: ')) 
select -= 1 
 
stats[select] = stats[select] + random.randint(5, 15) 
for i in range(len(stats)): 
    if i == select: 
        continue 
    stats[i] = stats[i] - random.randint(5, 15) 
print("Stats: ", end=" ") 
for i in range(attributes): 
    print(stats[i], end=" ") 
 
print("\n\tYour character has special skills!") 
print("\n\tYou can choose one!") 
 
fireball = [12, 15, 28, 10, 5] 
lightning = [7, 13, 15, 30, 10] 
silence = [23, 10, 12, 7, 18] 
fire_ward = [20, 23, 14, 6,17] 
skills = [fireball, lightning, silence, fire_ward] 
controls = ['f', 'l', 's', 'w']

def use_skill(skill):
    over = False
    for i in range(0, 4):
        if (stats[i] >= skills[skill][i]):
            stats[i] -= skills[skill][i]
        else:
            over = True
            break
    if (over == False):
        print(stats)
    else:
        print("\nYou lost all power")
    return over

overflow = False
while (overflow == False):
    select = str(input("f - fireball\nl - lightning\ns - silence\nw - fire ward\n>>> "))
    if (select in controls):
        overflow = use_skill(controls.index(select))
    else:
        print("You can't use this skill")
        continue

input()
