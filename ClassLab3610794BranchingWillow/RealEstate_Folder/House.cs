namespace ClassLab3610794BranchingWillow.RealEstate_Folder {
    // That : is the "inherits from" syntax. I'm saying that House inherits from Real Estate. 
    // By doing so, everywhere a "RealEstate" type is required, a "House" type will also work 
    // House IS a real estate, but not all real estates are houses, etc. 
    // House also gains access to anything that isnt Private in Realestate
    // so for example an instance of house has a property house.Address even without me declaring it here because
    // its exposed on the parent
    public class House : RealEstate {

    }
}