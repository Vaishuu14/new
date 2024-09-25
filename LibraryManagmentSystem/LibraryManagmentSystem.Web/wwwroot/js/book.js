﻿const uri = 'https://localhost:7207/api/book';
let books = [];

async function getBooks() {
    try {
        debugger;
        const response = await fetch(`${uri}/list`);
        const data = await response.json();
        books = data;
        _displayBooks(data);
    } catch (error) {
        console.error('Unable to get books.', error);
    }
}
async function addBook() {
    const addTitleTextbox = document.getElementById('add-title');
    const addAuthorTextbox = document.getElementById('add-author');
    const addIsbnTextbox = document.getElementById('add-isbn');
    const addPublishedDateTextbox = document.getElementById('add-publishedDate');
    const addNumberOfCopiesTextbox = document.getElementById('add-numberOfCopies');

    const book = {
        title: addTitleTextbox.value.trim(),
        author: addAuthorTextbox.value.trim(),
        isbn: addIsbnTextbox.value.trim(),
        publishedDate: addPublishedDateTextbox.value,
        numberOfCopies: parseInt(addNumberOfCopiesTextbox.value, 10)
    };

    try {
        const response = await fetch(`${uri}/create`, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(book)
        });

        if (response.ok) {
            getBooks();
            addTitleTextbox.value = '';
            addAuthorTextbox.value = '';
            addIsbnTextbox.value = '';
            addPublishedDateTextbox.value = '';
            addNumberOfCopiesTextbox.value = '';
        } else {
            console.error('Unable to add book.');
            const errorText = await response.text();
            console.error(errorText);
        }
    } catch (error) {
        console.error('Unable to add book.', error);
    }
}

async function deleteBook(id) {
    try {
        const response = await fetch(`${uri}/delete/${id}`, {
            method: 'DELETE'
        });

        if (response.ok) {
            getBooks();
        } else {
            console.error('Unable to delete book.');
        }
    } catch (error) {
        console.error('Unable to delete book.', error);
    }
}

function displayEditForm(id) {
    const book = books.find(book => book.id === id);

    document.getElementById('edit-id').value = book.id;
    document.getElementById('edit-title').value = book.title;
    document.getElementById('edit-author').value = book.author;
    document.getElementById('edit-isbn').value = book.isbn;
    document.getElementById('edit-publishedDate').value = new Date(book.publishedDate).toISOString().split('T')[0];
    document.getElementById('edit-numberOfCopies').value = book.numberOfCopies;
    document.getElementById('editForm').style.display = 'block';
}

async function updateBook() {
    const bookId = document.getElementById('edit-id').value;
    const bookTitle = document.getElementById('edit-title').value.trim();
    const bookAuthor = document.getElementById('edit-author').value.trim();
    const bookIsbn = document.getElementById('edit-isbn').value.trim();
    const bookPublishedDate = document.getElementById('edit-publishedDate').value;
    const bookNumberOfCopies = document.getElementById('edit-numberOfCopies').value;

    const book = {
        id: parseInt(bookId, 10),
        title: bookTitle,
        author: bookAuthor,
        isbn: bookIsbn,
        publishedDate: new Date(bookPublishedDate).toISOString(),
        numberOfCopies: parseInt(bookNumberOfCopies, 10)
    };

    try {
        const response = await fetch(`${uri}/update`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(book)
        });

        if (response.ok) {
            getBooks();
            closeInput();
        } else {
            console.error('Unable to update book.');
        }
    } catch (error) {
        console.error('Unable to update book.', error);
    }
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayBooks(data) {
    const tBody = document.getElementById('books');
    tBody.innerHTML = '';

    data.forEach(book => {
        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let titleTextNode = document.createTextNode(book.title);
        td1.appendChild(titleTextNode);

        let td2 = tr.insertCell(1);
        let authorTextNode = document.createTextNode(book.author);
        td2.appendChild(authorTextNode);

        let td3 = tr.insertCell(2);
        let isbnTextNode = document.createTextNode(book.isbn);
        td3.appendChild(isbnTextNode);

        let td4 = tr.insertCell(3);
        let publishedDateTextNode = document.createTextNode(new Date(book.publishedDate).toLocaleDateString());
        td4.appendChild(publishedDateTextNode);

        let td5 = tr.insertCell(4);
        let numberOfCopiesTextNode = document.createTextNode(book.numberOfCopies);
        td5.appendChild(numberOfCopiesTextNode);

        let td6 = tr.insertCell(5);
        let editButton = document.createElement('button');
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${book.id})`);
        td6.appendChild(editButton);

        let td7 = tr.insertCell(6);
        let deleteButton = document.createElement('button');
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteBook(${book.id})`);
        td7.appendChild(deleteButton);
    });

    const counter = document.getElementById('counter');
    const name = data.length === 1 ? 'book' : 'books';
    counter.innerText = `${data.length} ${name}`;
}
getBooks();

