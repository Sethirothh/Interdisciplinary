'strict';


function ProductCategory(e) {
    var cat_id = 'id-' + e.getAttribute('data-category');
    e.classList.add(cat_id);
}

function toggleParentClass(e) {
    let id = 'id-';
    let cat_id = id + e;
    let element = document.querySelector(`.${cat_id}`);
    let parent = element.closest('.food-section');

    if (cat_id == 'id-0') {
        parent.classList.remove('id-2');
        parent.classList.remove('id-1');
    }

    if (cat_id == 'id-1') {
        if (parent.classList.contains('id-2')) {
            parent.classList.remove('id-2');
            parent.classList.add(cat_id);
        } else {
            parent.classList.add(cat_id);
        }
        
    } else if(cat_id == 'id-2') {

        if (parent.classList.contains('id-1')) {
            parent.classList.remove('id-1');
            parent.classList.add(cat_id);
        } else {
            parent.classList.add(cat_id);
        }

    }
}
function toggleClass() {
    if (!this.classList.contains('active')) {
        
        let all = document.querySelectorAll('.active');
        let allArray = [];
        //Collect Array Data
        Array.from(all).forEach(function (e) {
            allArray.push(e);
            return allArray;
        })
        for (let all of allArray) {
            all.classList.remove('active');
        }
        this.classList.add('active');
    }
}

// Array Declarations
var products = document.querySelectorAll('.product');
var productArray = [];

//Collect Array Data
Array.from(products).forEach(function (e) {
    productArray.push(e);
    return productArray;
})

for (var prod of productArray) {
    ProductCategory(prod);
}

// Array Declarations
var category = document.querySelectorAll('.controller');
var categoryArray = [];

//Collect Array Data
Array.from(category).forEach(function (e) {
    categoryArray.push(e);
    return categoryArray;
})

for (var cat of categoryArray) {
    cat.addEventListener('click', toggleClass);
}