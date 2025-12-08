import Welcome from '@/components/Welcome';
import Counter from '@/components/Counter';
import UserList from '@/components/UserList';
import InputName from '@/components/InputName';
import Counterwithstyle from '@/components/Counterwithstyle';

export default function Home() {
  return (
    <main style={{ maxWidth: '800px', margin: '0 auto', padding: '20px' }}>
      <Welcome />
      <Counter />
      <UserList />
      <InputName />
      
    </main>
  );
}

