import React from 'react';

interface User {
  nama: string;
  umur: number;
}

const UserList: React.FC = () => {
  const users: User[] = [
    {
      nama: 'diwa',
      umur: 22
    },
    {
      nama: 'john',
      umur: 67
    }
  ];

  return (
    <div style={{ padding: '20px', border: '1px solid #ccc', borderRadius: '8px', margin: '20px 0' }}>
      <h2>Daftar User</h2>
      <ul style={{ listStyle: 'none', padding: 0 }}>
        {users.map((user, index) => (
          <li 
            key={index}
            style={{
              padding: '10px',
              margin: '10px 0',
              backgroundColor: '#f5f5f5',
              borderRadius: '5px'
            }}
          >
            <strong>Nama:</strong> {user.nama} | <strong>Umur:</strong> {user.umur}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default UserList;

