    class Service{
    storage=new Map();
    idCounter="1";
    
    add(object){
        this.storage.set(this.idCounter,object);
        this.idCounter++;
        this.idCounter=JSON.stringify(this.idCounter);
    }
    getById(id){
        if(typeof(id)=="string" && this.storage.has(id)){
            return this.storage.get(id);
        }
        else{
            return null;
        }
    }
    getAll(){
        return Array.from(this.storage);
    }
    
    deleteById(id){
        if(typeof(id)=="string"&&this.storage.has(id)){
            this.storage.delete(id);
            return true;
        }
        else{
            return false;
        }
    }
    updateById(id,object){
        if(typeof(id)=="string"&&this.storage.has(id)){
            let existingProperty=this.storage.get(id)
            for( let elem in object){
                if(existingProperty.hasOwnProperty(elem)){
                    existingProperty[elem]=object[elem];
                }                   
            }
            return true;
        }  
        else {
            return false;
        }
    }
    replaceById(id,object){
        if(typeof(id)=="string"&&this.storage.has(id)){
            this.storage.set(id,object);
            return true;
        }
        else{
            return false;
        }
    }
}


function test(){
    let library=new Service();
    let obj1={ 
        name: "Victor",
        age: "22"
    }
    let obj2={ 
        name: "Vasilii",
        age: "25"
    }
    library.add(obj1);
    library.add(obj2);
    library.add({name: "Ignat", age:"24"});
    console.log(library.getAll());
    console.log(library.getById("1"));
    console.log(library.deleteById("2"));
    console.log(library.updateById("1",{name:"Jija"}));
    console.log(library.getAll());
    console.log(library.replaceById("3",{cat:"Mars"}));
    console.log(library.getAll());
}