def mergeTwoLists(l1,l2):
    return sorted(l1+l2)

if __name__ == "__main__":
    l1 = [1,2,4]
    l2 = [1,3,4]

    result = mergeTwoLists(l1,l2)
    
    if result == [1,1,2,3,4,4]:
        print(True,result)
    else:
        print(False,result)
