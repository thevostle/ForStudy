class BinaryTree:
    tree = []

    def __init__ (self, tree):
        if (tree != None):
            self.tree = tree
        else:
            self.tree.append(0)

    # кол-во уровней в данном дереве
    def _levelMax (self):
        i = len(self.tree)-1
        level = 0
        while i != 0:
            level += 1
            i = (i - 2) / 2
        return level
    
    # на каком уровне находится данный элемент
    def _level (self, element):
        i = len(self.tree)-1
        level = self._levelMax()
        while i != 0:
            if (element <= i and element >= i/2):
                return level
            level -= 1
            i = (i - 2) / 2
        return level

    # переводим массив, например '0,0,1' в координаты 'лево,лево,право' и получаем индекс 8
    def _translateCoordToIndex(self, coords):
        result = 0
        for i in range(len(coords)):
            result = 2*result + 1 + coords[i]
        return result

    # наоборот переводим индекс в координаты
    #def _translateIndexToCoords(self, index):
    #    result = []
    #
    #    return result

    # получаем индекс родительской ветки
    def _getParentIndex(self, index):
        if (index > 0):
            return int((index-2+(index%2))/2)

    # получаем индексы дочерних элементов
    def _getChildIndexes(self, index):
        return [2*index+1, 2*index+2]

    # проверка есть ли перед этим индексом родительские элементы
    #def _hasParent(self, index):
    #    while ...
    #       if (... != None): # нам надо проверить только предыдущего родителя, ведь если он существует, то мы уже проверяли его родительскую ветвь
    #           return True    
    #    return False

    def FindElementIndex(self, element):
        for i in range(len(self.tree)):
            if self.tree[i] == element:
                return i
        return None

    #def AddElement(self, element, index):
    #    if self._hasParent(index):
    #       if index <= len(self.tree):
    #           self.tree[index] = element
    #       else:
    #           for i in range(len(self.tree)+1, 2*(len(self.tree)+1)):
    #                if i == index:
    #                    self.tree.append(element)
    #                else:
    #                    self.tree.append(None)



tree = BinaryTree([0, 1, 2, 3, 4, None, 6, None, 8, None, None, None, None, 13, 14])
print(tree._level(13)) # 3
print(tree._translateCoordToIndex([0,0,1])) # 8
print(tree._getParentIndex(10)) # 4
print(tree._getChildIndexes(4)) # 9 10

treeNew = BinaryTree(['Maria', 1, 2, 'Julia', 4, None, 6, None, 8, None, None, None, None, 13, 14])
print(treeNew.FindElementIndex('Julia')) # 3
