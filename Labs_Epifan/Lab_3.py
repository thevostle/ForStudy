class Sort:
    nums = []
    nums_origin = []

    def __init__(self, array):
        self.nums = array
        for i in range(len(array)):
            self.nums_origin.append(i)
        
    def SortBubble(self):
        self.swapped = True
        while self.swapped:
            self.swapped = False
            for i in range(len(self.nums) - 1):
                if (self.nums[i] < self.nums[i + 1]):
                    self.nums[i], self.nums[i + 1] = self.nums[i + 1], self.nums[i]
                    self.nums_origin[i], self.nums_origin[i + 1] = self.nums_origin[i + 1], self.nums_origin[i]
                    self.swapped = True

class Note:
    name = ""
    company = ""
    cost = 0
    guarantee = 0
    
    def __init__ (self, name, company, cost, guarantee):
        self.name = name
        self.company = company
        self.cost = cost
        self.guarantee = guarantee


notes = []

def AddNote():
    print("\nДобавить товар")
    new_name = input("Имя: ")
    new_company = input("Производитель: ")
    new_cost = int(input("Стоимость: "))
    new_guarantee = int(input("Гарантия: "))
    newNote = Note(new_name, new_company, new_cost, new_guarantee)
    
    notes.append(newNote)

def WriteToFile():
    f = open('text.txt', 'w')
    for index in notes:
        f.write(str(index.name) + '@' + str(index.company) + '@' + str(index.cost) + '@' + str(index.guarantee) + '@')
    f.close()

def ReadNotes():
    read_notes = []

    file_name = "text.txt"
    file = open(file_name, 'r')
    data = file.read().split('@')

    queue = 0
    for i in range(len(data) - 1):
        if queue == 0:
            new_name = data[i]
        elif queue == 1:
            new_company = data[i]
        elif queue == 2:
            new_cost = data[i]
        elif queue == 3:
            new_guarantee = data[i]
            new_note = Note(new_name, new_company, new_cost, new_guarantee)
            read_notes.append(new_note)

        queue += 1
        if queue > 3:
            queue = 0

    file.close()

    for n in read_notes:
        notes.append(n)


def GenerateTable():
    ReadNotes()
    guaranties = []
    for i in notes:
        guaranties.append(int(i.guarantee))

    sort = Sort(guaranties)
    sort.SortBubble()

    print('\nИмя\t\tПроизводитель\tСтоимость\tГарантия')
    for x in range(len(guaranties)):
        idx = sort.nums_origin[x]
        n = notes[idx]
        print(n.name + '\t\t' + n.company + '\t\t' + str(n.cost) + '\t\t' + str(n.guarantee))
    print('\n')


def main():
    task = int(input('Вы собираетесь читать файл (0) или создать новый (1)? '))

    if task == 0:
        GenerateTable()
    if task == 1:
        list_len = int(input('Введите кол-во товаров: '))
        for i in range(list_len):
            AddNote()
        WriteToFile()

if __name__ == '__main__':
    main()
    input()
