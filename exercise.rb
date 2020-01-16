wires = []
4.times do
  puts 'Escolha um fio'
  cuts = gets.chomp.to_s
  wires << cuts
end

rules = {
  'branco' => 'branco preto',
  'vermelho' => 'branco preto roxo laranja vermelho',
  'preto' => 'branco verde laranja',
  'laranja' => 'branco roxo verde laranja',
  'verde' => 'preto roxo verde vermelho',
  'roxo' => 'roxo verde laranja branco'
}

wires.each_with_index do |item, index|
  if rules[item].include?(wires[index + 1])
    puts 'Bomba explodiu'
    abort
  end

  break if index + 1 == wires.length - 1
end
puts 'Bomba desarmada'
