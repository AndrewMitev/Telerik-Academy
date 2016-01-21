var chatDb = require('./chat-database');

chatDb.registerUser({user:'DonchoMinkov', password:'123456'});

chatDb.registerUser({user: 'Spiderman', password:'jane'});

chatDb.sendMessage({
    from: 'DonchoMinkov',
    to: 'Spiderman',
    text: 'Hello from the other side.'
});

chatDb.sendMessage({
    from: 'Spiderman',
    to: 'DonchoMinkov',
    text: 'hnqqq.'
});

chatDb.sendMessage({
    from: 'Nikola',
    to: 'DonchoMinkov',
    text: 'Hello from the other side.'
});

chatDb.getMessages({
    with: 'DonchoMinkov',
    and: 'Spiderman'
});