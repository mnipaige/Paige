local gameObject = CS.UnityEngine.GameObject()
gameObject.name = "Paige"
gameObject.transform.position = CS.UnityEngine.Vector3(100, 100, 100)

local paige = CS.UnityEngine.GameObject.Find("Paige")
print("position", paige.transform.position)

local dogClass = CS.Dog
local dog = dogClass()
dog:Call("wwww~")
dog:Call()
dog:PFunc1()
local preP2
local preP3
local val, p2, p3 = dog:ComplexFunc({"xiaoma", 24}, function()
    print("paige nb~~~")
end, preP2, preP3)

print("call, ComplexFunc", val, p2, p3)
